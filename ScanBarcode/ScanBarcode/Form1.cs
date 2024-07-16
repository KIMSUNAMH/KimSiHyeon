using ScanBarcode.ObjectClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasTMS.ObjectClass;
using ZrLib.Config;  // IniManager 사용할수 있게하는 dll
using ZrLib.Security;
using ZrLib.Sys;

namespace ScanBarcode
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        FormLogin formlog = new FormLogin();

        //Log4Net
        public static readonly log4net.ILog localLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // 프로퍼시 속성
        private Properties.Settings Settings = new Properties.Settings();

        // 로그인폼
        private ScanBarcode.FormLogin formLogin;

        // 사용자 정보
        public UserInfo userInfo = new UserInfo();

        // 작업확인 변수
        private bool ScanStart = false;

        // 핸드스캐너 연결 확인
        private bool isScannerConnected = false;

        // DB정보
        public ObjectClass.DatabaseConn uniDatabase;
        private string uniConnUrl;


        // DB 연결
        public IniManager zrIniManager;
        public SysUtils sysUtils = new SysUtils(); //ZrLib.Sys, getCurrentDir()를 사용할수 있는 선언문
        private object sqlConn;

        //작섭상태 코드명 배열
        public String[] arrayWorkStauts;
        private DataSet ds;

        private SerialPort serialPort;
        private string scanBarcode;
        private string gsCode = "?";


        // Gtin 부터 일련번호까지 바코 변수 생성
        String strGtin = String.Empty;
        String strExpData = String.Empty;
        String strLot = String.Empty;
        String strSn = String.Empty;

        // 프로세스바 변수 값
        int cnt = 0;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();

            // 프로그램 환경설정 ini 파일 존재여부 체크
            zrIniManager = new IniManager(SysUtils.getCurrentDir() + "\\config.ini");

            InitConfiguration();

            uniDatabase = new ObjectClass.DatabaseConn(uniConnUrl);
            if (uniDatabase == null)
            {
                uniDatabase.DatabaseClose();
            }

            ds = uniDatabase.ReadData("SELECT * FROM VIEW_CODE WHERE GU='PT2' ORDER BY CODE", "작업상태 코드명 목록 검색 오류");
            if (ds == null)
            {
                return;
            }
            arrayWorkStauts = new String[ds.Tables[0].Rows.Count];
            if (ds.Tables[0].Rows.Count > 0)
            {
                int i = 0;
                foreach (DataRow dRow in ds.Tables[0].Rows)
                {
                    arrayWorkStauts[i++] = dRow["NAME"].ToString();
                }


            }
            StatusChange("종료");


            // 프로세스바 설정 변수
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Position = 0;

            serialPort = new SerialPort();
            {
                serialPort.PortName = "COM3";
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.Encoding = Encoding.ASCII;

            };

            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
                isScannerConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open COM port :" + ex.Message);
                isScannerConnected = false;
            }

            GridControlColumnsAdd();

            localLog.Info( "프로그램" + formlog.getInteranllp());
        }

        // 환경설정파일
        String dbIpAddress = String.Empty;


        private void InitConfiguration()
        {
            String dbld, dbPw, dbCatalog;
            dbIpAddress = zrIniManager.ReadValue("DB", "dbAddress");
            dbCatalog = zrIniManager.ReadValue("DB", "dbCatalog");
            dbld = EncryptionSimple.Decrypt(zrIniManager.ReadValue("DB", "dbId"), "ZR"); //EncryptionSimple 코들를 사용하기 위해서는 ZrLib.Security; 를 생성해야 된다
            dbPw = EncryptionSimple.Decrypt(zrIniManager.ReadValue("DB", "dbPw"), "ZR");
            uniConnUrl = String.Format("provider=SQL Server;Current Language=Korean;Data Source=\"{0}\";Initial Catalog={1};Password={2};User ID={3};", dbIpAddress, dbCatalog, dbPw, dbld);

        }


        // 스캔시작 버튼
        private void btnStartWorkorder_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                isScannerConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open COM port :" + ex.Message);
                isScannerConnected = false;
            }


            if (!isScannerConnected)
            {
                MessageBox.Show("핸드스캐너가 연결되어 있지 않아 작업을 시작할수 없습니다");
                return;
            }
           
            ScanStart = true;
            StatusChange("작업중");
            

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!ScanStart)
            {
                MessageBox.Show("작업상태가 작업중인 상태만 바코드 스캔을 할수가 있습니다.");
                return;
            }

            // 수신된 데이터 읽기
            string barcodeData = serialPort.ReadExisting();
            scanBarcode = barcodeData;

            // 바코드 데이터가 줄바꿈으로 끝날 때까지 수신
            if (barcodeData != null)
            {
                // UI 스레드에서 실행하도록 Invoke 사용
                this.Invoke(new Action(() =>
                {
                    // 바코드 처리
                    BarcodeCheck(scanBarcode);

                    // 바코드 처리 하면서 프로세스바 업데이트
                    UpdateProgressBar();

                }));
            }
        }


        private void GridControlColumnsAdd()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SRN_GTIN");
            dt.Columns.Add("SRN_SERIAL");
            gridControl1.DataSource = dt;

        }

        private void UpdateProgressBar()
        {
            if (cnt >= 100)
            {
                progressBarControl1.Position = 100;
                Item_progress.Text = "100";
                cnt = 0;
            }
            else
            {
                cnt += 10;
                if (cnt > 100)
                {
                    cnt = 10;
                }

            }

            progressBarControl1.Position = cnt;
            Item_progress.Text = cnt.ToString();
        }

        public void BarcodeCheck(String scanBarcode)
        {

            scanBarcode = scanBarcode.Trim();


            // 바코드 데이터를 파싱하고 유효성을 검사
            if (ValidateItem(scanBarcode))
            {
                DataTable dt = gridControl1.DataSource as DataTable;
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("SRN_GTIN");
                    dt.Columns.Add("SRN_SERIAL");
                    gridControl1.DataSource = dt;
                }

                DataRow dr = dt.NewRow();
                dr["SRN_GTIN"] = strGtin;
                dr["SRN_SERIAL"] = strSn;
                dt.Rows.Add(dr);
            }

            // 바코드 데이터 초기화
            strGtin = String.Empty;
            strExpData = String.Empty;
            strLot = String.Empty;
            strSn = String.Empty;


        }

        private bool ValidateItem(string scanBarcode)
        {
            // 검사될 코드
            String strSplitData = scanBarcode;
            String strAi = String.Empty;
            String strAiData = String.Empty;

            if (strSplitData.Length > 60)
            {
                return false;
            }

            do
            {
                if (strSplitData.Length < 2)
                {
                    break;
                }

                strAi = strSplitData.Substring(0, 2);

                // GTIN
                if (strAi.Equals("01"))
                {
                    strAiData = strSplitData.Substring(2, 14);
                    strGtin = strAiData;
                    strSplitData = strSplitData.Substring(16, strSplitData.Length - 16);
                }
                // 유효기한
                else if (strAi.Equals("17"))
                {
                    strAiData = strSplitData.Substring(2, 6);
                    strExpData = strAiData;
                    strSplitData = strSplitData.Substring(8, strSplitData.Length - 8);
                }
                // LOT번호<GS> 값이 있는지 확인 (스케너에서 <GS>값을 ?로 치환하였음)
                else if (strAi.Equals("10"))
                {
                    int intGsIdx = strSplitData.IndexOf(gsCode);
                    int intMaxDigit = 0;
                    if (intGsIdx == -1 || intGsIdx > 22)
                    {
                        if (strSplitData.Length > 22)
                            intMaxDigit = 20;
                        else
                            intMaxDigit = strSplitData.Length - 2;

                        strAiData = strSplitData.Substring(2, intMaxDigit);
                        strLot = strAiData;
                        strSplitData = strSplitData.Substring(strAiData.Length + 2, strSplitData.Length - (strAiData.Length + 2));
                    }
                    else
                    {
                        strAiData = strSplitData.Substring(2, intGsIdx - 2);
                        strLot = strAiData;
                        strSplitData = strSplitData.Substring(strAiData.Length + 3, strSplitData.Length - (strAiData.Length + 3));
                    }
                }
                // 일련번호
                else if (strAi.Equals("21"))
                {
                    int intGsIdx = strSplitData.IndexOf(gsCode);
                    int intMaxDigit = 0;
                    if (intGsIdx == -1 || intGsIdx > 22)
                    {
                        if (strSplitData.Length > 22)
                            intMaxDigit = 20;
                        else
                            intMaxDigit = strSplitData.Length - 2;

                        strAiData = strSplitData.Substring(2, intMaxDigit);
                        strSn = strAiData;
                        strSplitData = strSplitData.Substring(strAiData.Length + 2, strSplitData.Length - (strAiData.Length + 2));
                    }
                    else
                    {
                        strAiData = strSplitData.Substring(2, intGsIdx - 2);
                        strSn = strAiData;
                        strSplitData = strSplitData.Substring(strAiData.Length + 3, strSplitData.Length - (strAiData.Length + 3));
                    }
                }
                else
                {
                    return false;
                }

            } while (strSplitData.Length > 0);

            return true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }

        MessageBoxForm msgFormShort = new MessageBoxForm(FormSize.Short);
        public void ShowMsgShort(string msgGu, string title)
        {
            if (msgGu.Equals("INFO"))
            {
                msgFormShort._MessageBoxIcon = MessageBoxIcon.Question;
            }

            msgFormShort.Text = title;
            msgFormShort.ShowDialog();
        }


       private void StatusChange(String status)
        {
            if (status.Equals("작업중"))
            {

                //화면구성
                labelControl_Wo_Status.Text = arrayWorkStauts[3];
               Wo_Status.BackgroundImage = ScanBarcode.Properties.Resources._164975___green_light_symbol_64;
                MessageBox.Show("작업이 시작되었습니다 이제 바코드를 스캔할수 있습니다");
                btnStartWorkorder.Enabled = false;

            }
            else if (status.Equals("종료"))
            {
                // 화면구성
                labelControl_Wo_Status.Text = "종료";
                Wo_Status.BackgroundImage = ScanBarcode.Properties.Resources._165042___bulb_idea_light_red_64;
                btnStartWorkorder.Enabled = true;
            }

        }

       
    }


}
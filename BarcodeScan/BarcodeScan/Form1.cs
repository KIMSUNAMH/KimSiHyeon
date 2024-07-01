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
using TasBTS.ObjectClass; // ObjectClass 폴더를 사용할수 있는개 using

namespace BarcodeScan
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private SerialPort serialPort;
        private string scanBarcode;
        private string gsCode = "?";
       
        // Gtin 부터 일련번호까지 바코 변수 생성
        String strGtin = String.Empty;
        String strExpData = String.Empty;
        String strLot = String.Empty;
        String strSn = String.Empty;

        
        


        int cnt = 0;


        public Form1()
        {
            InitializeComponent();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open COM port :" + ex.Message);
                
            }
        
          
            GridControlColumnsAdd();

            
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
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

    }
}

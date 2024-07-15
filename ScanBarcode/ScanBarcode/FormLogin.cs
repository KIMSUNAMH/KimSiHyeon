using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZrLib.Config;
using ZrLib.Sys;
using ZrLib.Security;
using DevExpress.XtraEditors; // XtraMessageBox를 사용할수 있는 using
using TasTMS.ObjectClass;

namespace ScanBarcode
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        // 사용자 정보
        public UserInfo userInfo = new UserInfo();

        // DB정보
        public ObjectClass.DatabaseConn uniDatabase;
        private string uniConnUrl;

        // DB 연결
        public IniManager zrIniManager;
        public SysUtils sysUtils = new SysUtils(); //ZrLib.Sys, getCurrentDir()를 사용할수 있는 선언문
        private object sqlConn;


        Properties.Settings Settings = new Properties.Settings();
        
        
        // 로그인 아이디 셋팅
        public FormLogin()
        {
            InitializeComponent();

            // 프로그램 환경설정 ini 파일 존재여부 체크
            zrIniManager = new IniManager(SysUtils.getCurrentDir() + "\\config.ini");

            InitConfiguration();

            uniDatabase = new ObjectClass.DatabaseConn(uniConnUrl);
            if (uniDatabase == null)
            {
                uniDatabase.DatabaseClose();
            }

            //  로그인 아이디 셋팅
            DataSet dsLogin = uniDatabase.ReadData("SELECT EMP_NAME 성명,EMP_GRADE 직급,EMP_ID 아이디,EMP_DEPT 부서명,EMP_PW 비밀번호 FROM EMP WHERE EMP_USE_YN = 'Y' ORDER BY EMP_NAME", "로그인 정보 검색 오류");
            if (dsLogin == null)
            {
                //parentForm.ForceCloseing(false);
                return;

            }
            LookUpEditLogin.Properties.DataSource = dsLogin.Tables[0];
            LookUpEditLogin.EditValue = null;
            LookUpEditLogin.EditValue = zrIniManager.ReadValue("INIT", "lastLoginUser");
        }

        // 환경설정파일
        String dbIpAddress = String.Empty;
        private Form1 mainForm;

        private void InitConfiguration()
        {
            String dbld, dbPw, dbCatalog;
            dbIpAddress = zrIniManager.ReadValue("DB", "dbAddress");
            dbCatalog = zrIniManager.ReadValue("DB", "dbCatalog");
            dbld = EncryptionSimple.Decrypt(zrIniManager.ReadValue("DB", "dbId"), "ZR");
            dbPw = EncryptionSimple.Decrypt(zrIniManager.ReadValue("DB", "dbPw"), "ZR");
            uniConnUrl = String.Format("provider=SQL Server;Current Language=Korean;Data Source=\"{0}\";Initial Catalog={1};Password={2};User ID={3};", dbIpAddress, dbCatalog, dbPw, dbld);

        }

        // 취소버튼
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            edtBoxLoginPw.Text = "";
            this.Close();
        }

        // 로그인 버튼
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            // 프로그램 환경설정 ini 파일 존재여부 체크
            zrIniManager = new IniManager(SysUtils.getCurrentDir() + "\\config.ini");

            InitConfiguration();

            uniDatabase = new ObjectClass.DatabaseConn(uniConnUrl);
            if (uniDatabase == null)
            {
                uniDatabase.DatabaseClose();
            }

            if (LookUpEditLogin.EditValue == null)
            {
                XtraMessageBox.Show("성명을 선택하세요", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            String strId = LookUpEditLogin.EditValue.ToString();
            String strPw = LookUpEditLogin.SelectedText;

            DataSet dsLogin = uniDatabase.ReadData(String.Format("SELECT e.*,EVT_EMP_DATE, DATEADD(MONTH, CAST(EMP_LIMIT_MONTH AS INT),EVT_EMP_DATE)EVT_LIMIT_DATE,DATEDIFF(\"dd\",GETDATE(), DATEADD(MONTH, CAST(EMP_LIMIT_MONTH AS INT), EVT_EMP_DATE))EVT_LIMIT_DAY,g.UGR_NAME FROM EMP e,EMP_EVENT v,USER_GROUP g WHERE e.EMP_ID = v.EVT_EMP_ID AND e.EMP_UGR_CODE = g.UGR_CODE AND EMP_ID = '{0}' AND EMP_PW = '{1}' AND EMP_USE_YN ='Y'", strId, edtBoxLoginPw.Text),"프로그램 로그인 처리 오류");
            if (dsLogin == null)
            {
                return;
            }

            if (dsLogin.Tables[0].Rows.Count == 0)
            {
                // 로그인 오류 횟수 증가
               uniDatabase.ExecuteQuery(String.Format("UPDATE EMP SET EMP_FAULT_CNT = EMP_FAULT_CNT+1 FROM EMP WHERE EMP_ID = {0}", strId), "비밀번호 오류 횟수 증가");

                XtraMessageBox.Show(String.Format("사용자 정보를 확인하세요", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop));
            }
            else
            {
                DataRow dRow = dsLogin.Tables[0].Rows[0];
                userInfo.id = dRow["EMP_ID"].ToString();
                userInfo.name = dRow["EMP_NAME"].ToString();
                userInfo.grade = dRow["EMP_GRADE"].ToString();
                userInfo.dept = dRow["EMP_DEPT"].ToString();
                userInfo.group = dRow["EMP_UGR_CODE"].ToString();
                userInfo.groupName = dRow["UGR_NAME"].ToString();

                int limitCnt = Convert.ToInt16(dRow["EMP_FAULT_CNT"].ToString()); // 비밀번호 오류 횟수
                int limitDay = Convert.ToInt16(dRow["EMP_LIMIT_MONTH"].ToString());// 비밀번호 유효기간

                String limitDate = String.Format("EMP_LIMIT_MONTH").ToString(); // 비밀번호 유효날짜

                if (limitCnt > 5)
                {
                    XtraMessageBox.Show(this, "로그인 오류 횟수가 5번이상 되어 로그인이 불가능합니다 \r\n 관리자에게 문의하여 비밀번호를 초기화하세요",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (limitDay < 0)
                {
                    XtraMessageBox.Show(this, String.Format("비밀번호 유효기간이({0} 까지)초고되어 로그인이 불가능합니다 \r\n 관리자에게 문의하여 비밀번호를 초기화하세요", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop));
                }

                if (limitDay < 21 && limitDay >=0)
                {
                    XtraMessageBox.Show(this, String.Format("비밀번호 유효일이 {0}일 남았습니다 \r\n 새로운 비밀번호를 변경하세요",limitDay, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop));
                }

                // 로그인 오류 횟수 초기화
                uniDatabase.ExecuteQuery(String.Format("UPDATE EMP SET EMP_FAULT_CNT = 0 FROM EMP WHERE EMP_ID = '{0}'", strId), "비밀번호 로그인 횟수 초기화 오류");

                edtBoxLoginPw.Text = "";

                mainForm = new Form1();
                mainForm.Show();

                this.Hide();
            }

        }
    }
}

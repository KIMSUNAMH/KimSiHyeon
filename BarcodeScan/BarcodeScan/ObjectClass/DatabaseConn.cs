using Devart.Data.Universal;// UniConnection
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeScan.ObjectClass
{
   public class DatabaseConn
    {
        private String dbConnUrl = "provider=SQL Server;Current Language=Korean;Data Source=\"{0}\";Initial Catalog={1};Password={2};User ID={3};";
        private UniConnection sqlConn; // UniConnection 을 생성하기 위해서는 Decart.Data.Universal dll 파일을 추가시켜야한다

        public DatabaseConn(String dbUrl) //dburl = provider=SQL Server;Current Language=Korean;Data Source="db.tascorp.co.kr,2433";Initial Catalog=Tasco2D_v2_PRACTICE;Password=#xktmzh$@&#7892;User ID=sa;
        {
            try
            {
                dbConnUrl = dbUrl;
                sqlConn = new UniConnection(dbConnUrl);
            }
            catch (Exception ue)
            {
                XtraMessageBox.Show(String.Format("DB 오류가 발생하였습니다.\n\n{0}", ue.Message), "DatabaseConn", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                
            }
        }
        public DatabaseConn(String dbIpAddress, String dbCatalog, String dbPw, String dbId)
        {
            try
            {
                dbConnUrl = String.Format(dbConnUrl, dbIpAddress, dbCatalog, dbPw, dbId);
                sqlConn = new UniConnection(dbConnUrl);
            }
            catch (Exception ue)
            {
                XtraMessageBox.Show(String.Format("DB오류가 발생하였습니다.\n\n{0}", ue.Message), "DatabaseConn", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                    
            } 
            
        }

        public void DatabaseOpen()
        {
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            catch (Exception ue)
            {
                XtraMessageBox.Show(String.Format("DB오류가 발생하였습니다.\n\n{0}", ue.Message),"DatabaseOpen", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
               
            }
            
        }

        public void DatabaseClose()
        {
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Open)
                {
                    sqlConn.Clone();
                }
            }
            catch (Exception ue)
            {

                XtraMessageBox.Show(String.Format("DB오류가 발생하였습니다.\n\n{0}", ue.Message), "DatabaseClose", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
            }
        
        
        }


        /// <summary>
        /// SELECT 쿼리 실행
        /// </summary>
        /// <param name="query"></param>
        /// <param name="errAlert"></param>
        /// <returns>결과 데이터 셋</returns>
        public DataSet ReadData(string query, String errAlert)
        {
            try
            {
                sqlConn.Open();

                UniDataAdapter sqlAdapter = new UniDataAdapter(query, dbConnUrl);
                DataSet nDataSet = new DataSet();
                UniCommandBuilder sqlCmdBuilder = new UniCommandBuilder(sqlAdapter);
                sqlAdapter.SelectCommand.CommandTimeout = 5000; // CommandTimeout을 실행시키기 위해서는 Devart.Data.dll 파일이 필요하다

                sqlAdapter.Fill(nDataSet);

                return nDataSet;


            }
            catch (Exception ue)
            {

                XtraMessageBox.Show(String.Format("{0}\n\n{1}", errAlert, query), "[ReadData]DB 검색 오류가 발생했습니다", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                return null;
            }
            finally
            {
                sqlConn.Close();
            }

            
        
        }
           
        
    }
}

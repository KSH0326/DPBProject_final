using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using Oracle.DataAccess.Client;

namespace windowProject_final_
{
    public partial class UserLoginForm : Form
    {
        private int intID; //ID 필드 설정
        private string strCommand;
        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }

        public UserLoginForm()
        {
            InitializeComponent();
        }
        

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (PhoneNumBox.Text == null)
            {
                MessageBox.Show("전화번호를 입력해주세요.");
            }

            else if (PwBox.Text == null)
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }

            else
            {
                odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                odpConn.Open();
                string strqry = "select * from users where phonenum =:phonenum";
                OracleCommand comm = new OracleCommand(strqry, odpConn);
                comm.Parameters.Add("phonenum", OracleDbType.Varchar2, 11);
                comm.Parameters["phonenum"].Value = PhoneNumBox.Text.Trim();
                OracleDataReader sr = comm.ExecuteReader();

                if (sr.Read())
                {
                    if (sr["password"].ToString() == PwBox.Text)
                    {
                        MainForm mainform = new MainForm();
                        mainform.Show();
                        sr.Close();
                        odpConn.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
                        MessageBox.Show(sr["password"].ToString() + " " + PwBox.Text);
                        sr.Close();
                        odpConn.Close();
                    }
                        

                    
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
                    sr.Close();
                    odpConn.Close();
                }
                    

            }
            
    }

        private void button1_Click(object sender, EventArgs e)
        {

            StartForm startForm = new StartForm();
            startForm.Show();
            this.Dispose();
        }
    }
}

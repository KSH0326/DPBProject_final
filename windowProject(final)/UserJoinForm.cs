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
    public partial class UserJoinForm : Form
    {

        private int intID; //ID 필드 설정
        private string strCommand;
        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }

        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";


                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from users", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
        private int INSERTRow()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            odpConn.Open();

            String inName = NameBox.Text.Trim(); //**
            String inPhone = IdBox.Text.Trim(); //**
            String inpasswd = PwBox.Text.Trim(); //**
            string strqry = "INSERT INTO users VALUES ("+ inPhone + ", " + inpasswd + ", '" + inName + "', 0, 4)"; // 적립금 0, 랭크 4
            MessageBox.Show(strqry);
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }
        public UserJoinForm()
        {
            InitializeComponent();
        }
        
        private void LOGIN_button_Click(object sender, EventArgs e)
        {
            String username = NameBox.Text;
            String userID = IdBox.Text;
            String userPW = PwBox.Text;
            String userPWCK = PwChBox.Text;
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show("이름을 입력해주세요");
                NameBox.Focus();
            }
            else if (String.IsNullOrEmpty(IdBox.Text))
            {
                MessageBox.Show("휴대폰번호를 입력해주세요");
                IdBox.Focus();
            }
            else if (String.IsNullOrEmpty(PwBox.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                PwBox.Focus();
            }
            else if (String.IsNullOrEmpty(PwChBox.Text))
            {
                MessageBox.Show("비밀번호를 다시 입력해주세요");
                PwChBox.Focus();
            }

            else if (PwBox.Text != PwChBox.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다. 비밀번호를 다시 입력해주세요.");
            }
            else
            {
            
                if (INSERTRow() > 0)
                {
                    odpConn.Close();
                    this.Dispose();
                    MessageBox.Show("회원가입이 완료되었습니다. 로그인 후 이용해주세요.");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else MessageBox.Show("오류로 인한 회원가입 실패!");
                odpConn.Close();
                this.Dispose();
            }

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
    }
}

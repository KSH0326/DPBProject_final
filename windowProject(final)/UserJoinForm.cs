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
            string strqry = "INSERT INTO phone VALUES ("+ inPhone + ", " + inpasswd + ", " + inName + ")";
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }
        public UserJoinForm()
        {
            InitializeComponent();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "74wa4lLLYMdKI7R22dI3xOYNnY5UFpznf9zb0htV",
            BasePath = "https://windowprogramming-final-work-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void LOGIN_button_Click(object sender, EventArgs e)
        {

            if (PwBox.Text == PwChBox.Text)
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("회원가입 완료!");
                }
                else MessageBox.Show("오류로 인한 회원가입 실패!");
                this.Close();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다!");
            }

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
    }
}

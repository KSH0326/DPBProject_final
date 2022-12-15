using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowProject_final_
{
    public partial class UserInoutForm : Form
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
                oda.SelectCommand = new OracleCommand("SELECT * from seat", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
        public UserInoutForm()
        {
            InitializeComponent();
        }

        private int INSERTRow(int i)//사용자 함수 : 입실
        {
            odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            odpConn.Open();
            int inid = i; //좌석번호

            string strqry = "INSERT INTO seat VALUES (sysdate, to_char(sysdate + 2/24, 'yy/mm/dd hh24:mi:ss'), " + inid + ")";
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }

        private int DELETERow(int i) //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            odpConn.Open();
            int getID = i; //** 좌석 번호
            string strqry = "DELETE FROM seat WHERE seatnum = " + getID; //구문

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery();
        }

        private void seat1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            //이미 좌석이 선택된 경우
            if (IsSelected == true)
            {
                DialogResult dr = MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    DELETERow(1);
                    this.Hide();
                    MessageBox.Show("1번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (dr == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                DialogResult dr = MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {

                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("1번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    INSERTRow(1);
                    IsSelected = true;
                    this.Close();

                }
                else if (dr == DialogResult.Cancel)
                {
                    //this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("2번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("2번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("3번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("3번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat4_Click_1(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("4번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("4번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("5번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("5번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("6번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("6번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("7번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("7번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("8번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("8번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
            seat9.BackColor = Color.LightGray;
        }

        private void UserInoutForm_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }
    }
}

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

        bool IsSelected = false;
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }
        private void showDataGridView() //사용자 정의 함수 : 그리드뷰 띄우기
        {
            try
            {
                odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";


                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT seatnum 좌석번호, entertime 입장시간, checkouttime 퇴장시간 from seat", odpConn);
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

        private Boolean ClickEvent(int seatnum, bool IsSelected, Button btn)
        {
            //이미 선택된 좌석을 클릭한 경우(퇴실)
            if (IsSelected == true)
            {
                DialogResult dialogResult = MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //퇴실 확인
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show(Convert.ToString(seatnum) + "번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    IsSelected = false;
                    btn.BackColor = SetColor(IsSelected); //입실/퇴실에 따라 좌석 색상 변경

                }
                //퇴실 취소
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("선택을 취소하였습니다.");
                }
            }

            //비어있던 좌석을 선택한 경우(입실)
            else if (IsSelected == false)
            {
                DialogResult dialogResult = MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //입실 확인
                if (dialogResult == DialogResult.OK)
                {
                    //MainForm mainform = new MainForm();
                    //mainform.Show();
                    btn.BackColor = Color.LightGray;
                    if (INSERTRow(seatnum) > 0)
                    {
                        MessageBox.Show(Convert.ToString(seatnum) + "번 좌석에 입실 처리 되었습니다.");
                        IsSelected = true;
                        btn.BackColor = SetColor(IsSelected); //입실/퇴실에 따라 좌석 색상 변경
                        //this.Dispose();
                    }
                    else MessageBox.Show("데이터 행이 추가되지 않음!");
                    
                }
                //입실 취소
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("선택을 취소하였습니다.");
                    btn.BackColor = SetColor(IsSelected); //입실/퇴실에 따라 좌석 색상 변경
                }
            }
            odpConn.Close();
            showDataGridView();
            return IsSelected;
        }

        private int INSERTRow(int i)//사용자 함수 : 추가
        {
            odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            odpConn.Open();
            int inid = i; //좌석번호

            string strqry = "INSERT INTO seat VALUES (sysdate, to_char(sysdate + 2/24, 'yy/mm/dd hh24:mi:ss'), " + inid + ", '0101111111')";
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }

        private int DELETERow(int i) //사용자 함수 정의 : 퇴실
        {
            odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            odpConn.Open();
            int getID = i; //** 좌석 번호
            string strqry = "DELETE FROM seat WHERE seatnum = " + getID; //구문
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery();
        }
        private Color SetColor(bool IsSelected) //색상 설정
        {
            Color selectedColor = Color.LightGray;
            if (IsSelected == false)
            {
                selectedColor = Color.PeachPuff;
                //MessageBox.Show("좌석이 선택되지 않았습니다.");
            }
            else if (IsSelected == true)
            {
                selectedColor = Color.LightGray;
                //MessageBox.Show("좌석이 선택되었습니다.");
            }
            return selectedColor;
        }


        private void seat1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            bool IsSelected1 = ClickEvent(1, IsSelected, seat1); //clickevent함수로 입실/퇴실 선택
            IsSelected = IsSelected1;

        }

        private void seat2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            bool IsSelected2 = ClickEvent(2, IsSelected, seat2);
            seat2.BackColor = SetColor(IsSelected2);
            IsSelected = IsSelected2;

        }

        private void seat3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            bool IsSelected3 = ClickEvent(3, IsSelected, seat3);
            IsSelected = IsSelected3;

        }

        private void seat4_Click_1(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            bool IsSelected4 = ClickEvent(4, IsSelected, seat4);
            IsSelected = IsSelected4;

        }

        private void seat5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            bool IsSelected5 = ClickEvent(5, IsSelected, seat5);
            seat5.BackColor = SetColor(IsSelected5);
            IsSelected = IsSelected5;

        }

        private void seat6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            bool IsSelected6 = ClickEvent(6, IsSelected, seat6);
            seat6.BackColor = SetColor(IsSelected6);
            IsSelected = IsSelected6;

        }

        private void seat7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            bool IsSelected7 = ClickEvent(7, IsSelected, seat7);
            seat7.BackColor = SetColor(IsSelected7);
            IsSelected = IsSelected7;

        }

        private void seat8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
            bool IsSelected8 = ClickEvent(8, IsSelected, seat8);
            seat8.BackColor = SetColor(IsSelected8);
            IsSelected = IsSelected8;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MainForm mainform = new MainForm();
            mainform.Show();
            this.Dispose();
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
            bool IsSelected9 = ClickEvent(9, IsSelected, seat9);
            seat9.BackColor = SetColor(IsSelected9);
            IsSelected = IsSelected9;

        }

        private void UserInoutForm_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }
    }
}

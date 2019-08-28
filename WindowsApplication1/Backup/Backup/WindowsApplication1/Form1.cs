using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    // Form 상속 받음
    public partial class Form1 : Form
    {
        // 데이타 필드
        private int balance = 0;                         // 현잔액
        private int withdrawal = 0;                      // 반환 금액
        private string out_cup = " 나왔습니다. ";        // 배출 음료
        
        //음료수변수
        private string cola = "  콜라  ";
        private string cider = " 사이다 ";
        private string fanta = "  환타  ";
        private string pro2 = "   2 %  ";
        private string saek = "  쌕쌕  ";
        
        //커피 변수
        private string milk = "밀크커피";
        private string sugar = "설탕커피";
        private string pream = "프림커피";
        private string black = "블랙커피";
        private string yulmu = " 율무차 ";
        
        //display 화면
        private string display_coin = "Inset Coin";
        private string display_low = "잔액 부족";
        private string display_out = " 나옴";
        private string display_do = " 나오는 중";
        private string display_with = " 잔액 반환"; 

        
        
        public Form1()
        {
            InitializeComponent();
        }
        
        // Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_display.Text = display_coin;
            txt_balance.Text = Convert.ToString(balance);
            txt_withdrawal.Text = Convert.ToString(withdrawal);
        }

        // ========== 동전 버튼 이벤트 =========

        //10원 버튼 클릭 이벤트
        private void bt_10_Click(object sender, EventArgs e)
        {
            balance = balance + 10;                         // 잔액에 10원 더함
            txt_balance.Text = Convert.ToString(balance);   // 잔액표시
        }

        //50원 버튼 클릭 이벤트
        private void bt_50_Click(object sender, EventArgs e)
        {
            balance = balance + 50;                         // 잔액에 50원 더함
            txt_balance.Text = Convert.ToString(balance);   // 잔액표시
        }

        //100원 버튼 클릭 이벤트
        private void bt_100_Click(object sender, EventArgs e)
        {
            balance = balance + 100;                        // 잔액에 100원 더함
            txt_balance.Text = Convert.ToString(balance);   // 잔액표시
        }

        //500원 버튼 클릭 이벤트
        private void bt_500_Click(object sender, EventArgs e)
        {
            balance = balance + 500;                        // 잔액에 500원 더함
            txt_balance.Text = Convert.ToString(balance);   // 잔액표시
        }

        //1000원 버튼 클릭 이벤트                           
        private void bt_1000_Click(object sender, EventArgs e)
        {
            balance = balance + 1000;                       // 잔액에 1000원 더함
            txt_balance.Text = Convert.ToString(balance);   // 잔액표시
        }


        // ========== 음료수 버튼 이벤트 =========

        //콜라 버튼 이벤트
        private void bt_cola_Click(object sender, EventArgs e)
        {
           play(600, cola);             //콜라 인자값을 넘겨 play 메소드 호출
        }

        //사이다 버튼 이벤트
        private void bt_cider_Click(object sender, EventArgs e)
        {
            play(600, cider);           //사이다 인자값을 넘겨 play 메소드 호출
        }

        //2% 버튼 이벤트
        private void bt_2pro_Click(object sender, EventArgs e)
        {
            play(550, pro2);            //2% 인자값을 넘겨 play 메소드 호출
        }

        //환타 버튼 이벤트
        private void bt_fanta_Click(object sender, EventArgs e)
        {
            play(550, fanta);           //환타 인자값을 넘겨 play 메소드 호출
        }

        //쌕쌕 버튼 이벤트
        private void bt_saek_Click(object sender, EventArgs e)
        {
            play(500, saek);            //쌕쌕 인자값을 넘겨 play 메소드 호출
        }

        // 밀크커피 버튼이벤트
        private void bt_milk_Click(object sender, EventArgs e)
        {
            play(200, milk);            //밀크커피 인자값을 넘겨 play 메소드 호출
        }

        // 설탕커피 버튼이벤트
        private void bt_sugar_Click(object sender, EventArgs e)
        {
            play(200, sugar);           //설탕커피 인자값을 넘겨 play 메소드 호출
        }

        // 프림커피 버튼이벤트
        private void bt_pream_Click(object sender, EventArgs e)
        {
            play(200, pream);           //프림커피 인자값을 넘겨 play 메소드 호출
        }

        // 블랙커피 버튼이벤트
        private void bt_black_Click(object sender, EventArgs e)
        {
            play(200, black);           //블랙커피 인자값을 넘겨 play 메소드 호출
        }

        // 율무차 버튼이벤트
        private void bt_yulmu_Click(object sender, EventArgs e)
        {
            play(150, yulmu);           //율무차 인자값을 넘겨 play 메소드 호출
        }

        // 반환 버튼 이벤트
        private void bt_withdraw_Click(object sender, EventArgs e)
        {
            withdrawal = balance;       // 잔액을 반환 값으로 
            balance = 0;                // 잔액을 0으로 초기

            // 잔액,반환값,디스플레이,배출구 출력
            txt_withdrawal.Text = Convert.ToString(withdrawal);
            txt_balance.Text = Convert.ToString(balance);
            txt_display.Text = display_with;
            txt_out.Text = "";
        }

        //프로그램을 종료하는 버튼 이벤트
        private void colseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램이 종료되었습니다.");
            this.Close();
        }

        //만든이 버튼 이벤트
        private void creatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작 : 안병재      \n만든일 : 2007/6/21    ");
        }
        


        
        //음료수 버튼시 호출되는 메소드
        private void play(int cost, string value)
        {
            //반환 금액 0으로 초기화            
            txt_withdrawal.Text = Convert.ToString(0);

            // 잔액과 음료수 가격 비교
            if(balance >= cost)
            {
                // 잔액에서 음료수 가격 뻄.
                balance -= cost;
                txt_balance.Text = Convert.ToString(balance);

                //progressBar1 진행
                for (int i = 0; i < progressBar1.Maximum; i++)
                {
                    txt_display.Text = value + display_do;
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(20);
                    Application.DoEvents();
 
                }

                //lcd 진행 표시
                txt_display.Text = value + display_out;
                
                //배출구 나오는 명령
                txt_out.Text += value + out_cup ;
      
      
            }else
            {
                txt_display.Text = display_low;               
            }
        }
    }
}


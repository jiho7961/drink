using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    // Form ��� ����
    public partial class Form1 : Form
    {
        // ����Ÿ �ʵ�
        private int balance = 0;                         // ���ܾ�
        private int withdrawal = 0;                      // ��ȯ �ݾ�
        private string out_cup = " ���Խ��ϴ�. ";        // ���� ����
        
        //���������
        private string cola = "  �ݶ�  ";
        private string cider = " ���̴� ";
        private string fanta = "  ȯŸ  ";
        private string pro2 = "   2 %  ";
        private string saek = "  �ٽ�  ";
        
        //Ŀ�� ����
        private string milk = "��ũĿ��";
        private string sugar = "����Ŀ��";
        private string pream = "����Ŀ��";
        private string black = "��Ŀ��";
        private string yulmu = " ������ ";
        
        //display ȭ��
        private string display_coin = "Inset Coin";
        private string display_low = "�ܾ� ����";
        private string display_out = " ����";
        private string display_do = " ������ ��";
        private string display_with = " �ܾ� ��ȯ"; 

        
        
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

        // ========== ���� ��ư �̺�Ʈ =========

        //10�� ��ư Ŭ�� �̺�Ʈ
        private void bt_10_Click(object sender, EventArgs e)
        {
            balance = balance + 10;                         // �ܾ׿� 10�� ����
            txt_balance.Text = Convert.ToString(balance);   // �ܾ�ǥ��
        }

        //50�� ��ư Ŭ�� �̺�Ʈ
        private void bt_50_Click(object sender, EventArgs e)
        {
            balance = balance + 50;                         // �ܾ׿� 50�� ����
            txt_balance.Text = Convert.ToString(balance);   // �ܾ�ǥ��
        }

        //100�� ��ư Ŭ�� �̺�Ʈ
        private void bt_100_Click(object sender, EventArgs e)
        {
            balance = balance + 100;                        // �ܾ׿� 100�� ����
            txt_balance.Text = Convert.ToString(balance);   // �ܾ�ǥ��
        }

        //500�� ��ư Ŭ�� �̺�Ʈ
        private void bt_500_Click(object sender, EventArgs e)
        {
            balance = balance + 500;                        // �ܾ׿� 500�� ����
            txt_balance.Text = Convert.ToString(balance);   // �ܾ�ǥ��
        }

        //1000�� ��ư Ŭ�� �̺�Ʈ                           
        private void bt_1000_Click(object sender, EventArgs e)
        {
            balance = balance + 1000;                       // �ܾ׿� 1000�� ����
            txt_balance.Text = Convert.ToString(balance);   // �ܾ�ǥ��
        }


        // ========== ����� ��ư �̺�Ʈ =========

        //�ݶ� ��ư �̺�Ʈ
        private void bt_cola_Click(object sender, EventArgs e)
        {
           play(600, cola);             //�ݶ� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        //���̴� ��ư �̺�Ʈ
        private void bt_cider_Click(object sender, EventArgs e)
        {
            play(600, cider);           //���̴� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        //2% ��ư �̺�Ʈ
        private void bt_2pro_Click(object sender, EventArgs e)
        {
            play(550, pro2);            //2% ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        //ȯŸ ��ư �̺�Ʈ
        private void bt_fanta_Click(object sender, EventArgs e)
        {
            play(550, fanta);           //ȯŸ ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        //�ٽ� ��ư �̺�Ʈ
        private void bt_saek_Click(object sender, EventArgs e)
        {
            play(500, saek);            //�ٽ� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ��ũĿ�� ��ư�̺�Ʈ
        private void bt_milk_Click(object sender, EventArgs e)
        {
            play(200, milk);            //��ũĿ�� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ����Ŀ�� ��ư�̺�Ʈ
        private void bt_sugar_Click(object sender, EventArgs e)
        {
            play(200, sugar);           //����Ŀ�� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ����Ŀ�� ��ư�̺�Ʈ
        private void bt_pream_Click(object sender, EventArgs e)
        {
            play(200, pream);           //����Ŀ�� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ��Ŀ�� ��ư�̺�Ʈ
        private void bt_black_Click(object sender, EventArgs e)
        {
            play(200, black);           //��Ŀ�� ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ������ ��ư�̺�Ʈ
        private void bt_yulmu_Click(object sender, EventArgs e)
        {
            play(150, yulmu);           //������ ���ڰ��� �Ѱ� play �޼ҵ� ȣ��
        }

        // ��ȯ ��ư �̺�Ʈ
        private void bt_withdraw_Click(object sender, EventArgs e)
        {
            withdrawal = balance;       // �ܾ��� ��ȯ ������ 
            balance = 0;                // �ܾ��� 0���� �ʱ�

            // �ܾ�,��ȯ��,���÷���,���ⱸ ���
            txt_withdrawal.Text = Convert.ToString(withdrawal);
            txt_balance.Text = Convert.ToString(balance);
            txt_display.Text = display_with;
            txt_out.Text = "";
        }

        //���α׷��� �����ϴ� ��ư �̺�Ʈ
        private void colseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���α׷��� ����Ǿ����ϴ�.");
            this.Close();
        }

        //������ ��ư �̺�Ʈ
        private void creatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� : �Ⱥ���      \n������ : 2007/6/21    ");
        }
        


        
        //����� ��ư�� ȣ��Ǵ� �޼ҵ�
        private void play(int cost, string value)
        {
            //��ȯ �ݾ� 0���� �ʱ�ȭ            
            txt_withdrawal.Text = Convert.ToString(0);

            // �ܾװ� ����� ���� ��
            if(balance >= cost)
            {
                // �ܾ׿��� ����� ���� �M.
                balance -= cost;
                txt_balance.Text = Convert.ToString(balance);

                //progressBar1 ����
                for (int i = 0; i < progressBar1.Maximum; i++)
                {
                    txt_display.Text = value + display_do;
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(20);
                    Application.DoEvents();
 
                }

                //lcd ���� ǥ��
                txt_display.Text = value + display_out;
                
                //���ⱸ ������ ���
                txt_out.Text += value + out_cup ;
      
      
            }else
            {
                txt_display.Text = display_low;               
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 박현서2017100922실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Enabled = false;
            button3.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Expand();
        }



        private void Expand() // 영역확대 메소드
        {

            if (panel1.Width < 300)
            {

                panel1.Size =
                    new Size(panel1.Size.Width * 11 / 10, panel1.Size.Height * 11 / 10);
                // 이전 배경 색상으로 변경
            }
            else
            {
                MessageBox.Show("최대 크기입니다.");
            }
            panel1.BackColor = panel1.ForeColor;
            panel1.BackColor = SystemColors.Control;
        }

        private void Reduce() // 영역축소 메소드
        {
            if (panel1.Width < 50)
            {
                MessageBox.Show("최소 크기입니다.");
            }
            else
            {
                panel1.Size =
                    new Size(panel1.Size.Width * 10 / 11, panel1.Size.Height * 10 / 11);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reduce();
        }


        private void panel1_Resize(object sender, EventArgs e) // 가로 좌표 고정
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height- button1.Width)/2;
        }


    }
}

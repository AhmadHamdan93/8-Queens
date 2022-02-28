using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess
{
    public partial class Form1 : Form
    {
        int x_step = 0;
        int y_step = 0;

        List<Node> solution;
        int current_index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queen q = new Queen();
            q.search();
            solution = q.getSolution();


            first_btn.Enabled = true;
            last_btn.Enabled = true;
            next_btn.Enabled = true;
            pri_btn.Enabled = true;
            label_total_sol.Text = solution.Count.ToString();
            label_id_sol.Text = "1";
            
            
            draw();
        }

        private void change_solution(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            switch (b.Tag.ToString())
            {
                case "1":
                    if (current_index < (solution.Count - 1))
                    {
                        current_index++;
                        change_solution(current_index);
                    }
                    break;
                case "3": 
                    current_index = solution.Count - 1; 
                    change_solution(current_index);
                    break;
                case "4": 
                    current_index=0;
                    change_solution(current_index);
                    break;
                case "2":
                    if (current_index > 0)
                    {
                        current_index--;
                        change_solution(current_index);
                    }
                    break;
                default: break;
            }
            draw();
        }
        
        void change_solution(int idx)
        {
            label_id_sol.Text = "" + (idx+1);
        }

        void draw()
        {
            // ---------------
            pictureBox1.Image = null;
            pictureBox1.Update();
            pictureBox1.Refresh();
            // -------------------------

            Graphics g = pictureBox1.CreateGraphics();


            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;
            find_steps();

            Rectangle r1 = new Rectangle(0, 0, wid , high );
            SolidBrush brush1 = new SolidBrush(Color.Tomato);
            g.FillRectangle(brush1, r1);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    drawRectangle(i, j, g);
                }
            }

            drawQueen(g);
            drawIndex(g);
            

        }
        void x_step_draw(int x, int y, Graphics g)
        {
            int high = pictureBox1.Height;

            int new_x = 10 + x_step * x;
            int new_y = 10 + y_step * y;//high - 10 - (y_step * y);



            Color color = Color.Blue;
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, new_x, new_y, 3, 3);
            // ---------------------
            Font myFont = new Font("Arial", 7);
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            if (x != 0)
            {
                g.DrawString("" + x, myFont, brush1, new_x - 2, new_y - 10);
            }

        }
        void y_step_draw(int x, int y, Graphics g)
        {
            int high = pictureBox1.Height;

            int new_x = 10 + x_step * x;
            int new_y = 10 + y_step * y; //high - 10 - (y_step * y);

            Color color = Color.Blue;
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, new_x, new_y, 3, 3);
            // ---------------------
            Font myFont = new Font("Arial", 7);
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            if (y != 0)
            {
                g.DrawString("" + y, myFont, brush1, new_x - 10, new_y - 5);
            }

        }
        void drawRectangle(int x, int y, Graphics g)
        {
            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;

            int new_x = (20 + x_step * x);
            int new_y = (20 + y_step * y);
            x++; y++;
            int new_x1 = (20 + x_step * x);
            int new_y1 = (20 + y_step * y);
            
            Color color = Color.Black;
            if ((x + y) % 2 == 0)
            {
                color = Color.Black;
            }
            else
            {
                color = Color.WhiteSmoke;
            }

            

            SolidBrush brush = new SolidBrush(color);
            Rectangle r = new Rectangle(new_x, new_y, new_x1 - new_x, new_y1 - new_y);
            g.FillRectangle(brush,r);
            

        }
        void find_steps()
        {
            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;

            x_step = (wid - 40) / 8;    //(x_max + 1);
            y_step = (high - 40) / 8;   //(y_max + 1);

        }
        void drawQueen(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                int j = solution[current_index].row[i];
                drawCircle(i, j, g);
            }
        }
        void drawCircle(int x, int y, Graphics g)
        {
            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;

            int new_x = (20 + x_step * x);
            int new_y = (20 + y_step * y);
            x++; y++;
            int new_x1 = (20 + x_step * x);
            int new_y1 = (20 + y_step * y);
            int x_mean = (new_x + new_x1) / 2;
            int y_mean = (new_y + new_y1) / 2;

            int x_square = (new_x1 - new_x) / 5;
            int y_square = (new_y1 - new_y) / 5;

            Color color = Color.YellowGreen;
            SolidBrush brush = new SolidBrush(color);
            Rectangle r = new Rectangle(new_x + x_square, new_y + y_square, x_mean - new_x, x_mean - new_x);
            g.FillEllipse(brush, r);
        }
        void drawIndex(Graphics g)
        {
            int high = pictureBox1.Height;
            
            

            Font myFont = new Font("Arial", 14);
            SolidBrush brush1 = new SolidBrush(Color.White);
            Char[] a = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            for (int i = 1; i <= 8; i++)
            {
                int num_x = 10 + x_step * 0;
                int num_x1 = 10 + x_step * 8;
                int num_y = 10 + y_step * i;
                g.DrawString("" + (9 - i), myFont, brush1, num_x - 7, num_y - 30);
                g.DrawString("" + (9 - i), myFont, brush1, num_x1 + 10, num_y - 30);

                int letter_x = 10 + x_step * i;
                int letter_y1 = 10 + y_step * 8;
                int letter_y = 10 + y_step * 0;
                g.DrawString("" + a[i - 1], myFont, brush1, letter_x - 40, 0);
                g.DrawString("" + a[i - 1], myFont, brush1, letter_x - 40, letter_y1+7);
            }
                
            
        }
    }
}

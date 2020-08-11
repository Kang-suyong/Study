using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Study
{
    class Program : Form
    {

        static void Main()
        {
            Button Player = new Button();
            Button select0 = new Button();
            Button select1 = new Button();
            Button select2 = new Button();
            Button select3 = new Button();   
            Program pr = new Program(); 
            Random rand = new Random();

            pr.Form(pr);
            pr.ControlSelect0(select0);
            pr.ControlSelect1(select1);
            pr.ControlSelect2(select2);
            pr.ControlSelect3(select3);


            pr.ControlMe(Player);
            

            pr.Controls.Add(Player);
            Player.Click += (object sender, EventArgs e) =>
           {
               MessageBox.Show("정답!");

           };

            Application.Run(pr);
        }
        public void ControlSelect3(Button Player)
        {
            Random rand = new Random();
            Player.Width = 100;
            Player.Height = 50;
            Player.Left = rand.Next(0, 500);
            Player.Top = rand.Next(0, 500);
            Player.BackColor = Color.FromArgb(rand.Next(4, 100), rand.Next(4, 100), rand.Next(4, 100));

            Controls.Add(Player);

        }
        public void ControlSelect2(Button Player)
        {
            Random rand = new Random();
            Player.Width = 100;
            Player.Height = 50;
            Player.Left = rand.Next(0, 500);
            Player.Top = rand.Next(0, 500);
            Player.BackColor = Color.FromArgb(rand.Next(4, 100), rand.Next(4, 100), rand.Next(4, 100));

            Controls.Add(Player);

        }
        public void ControlSelect0(Button Player)
        {
            Random rand = new Random();
            Player.Width = 100;
            Player.Height = 50;
            Player.Left = rand.Next(0, 500);
            Player.Top = rand.Next(0, 500);
            Player.BackColor = Color.FromArgb(rand.Next(4, 100), rand.Next(4, 100), rand.Next(4, 100));

            Controls.Add(Player);

        }

        public void ControlSelect1(Button Player)
        {
            Random rand = new Random();
            Player.Width = 100;
            Player.Height = 50;
            Player.Left = rand.Next(0, 500);
            Player.Top = rand.Next(0, 500);
            Player.BackColor = Color.FromArgb(rand.Next(4, 100), rand.Next(4, 100), rand.Next(4, 100));

            Controls.Add(Player);

        }
       
        public void ControlMe(Button Player)
        {
            Player.Width = 300;
            Player.Height = 100;
            Player.Left = 750;
            Player.Top = 80;
            Player.BackColor = Color.White;
            Player.Text = "이 중에서 가장 하얀 버튼을 눌러주세요. ";
            
        }


        public void Form(Program pr)
        {
            pr.Width = 1920;
            pr.Height = 1200;
            pr.Text = "예제";

        }

    }
}

            
        
      
       
       
   


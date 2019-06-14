using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyuu0614
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();

        int time = 100 * 5;

        int[] velx = new int[3];
        int[] vely = new int[3];
        
        public Form1()
        {
            InitializeComponent();
            for(int i=0;i<3;i++)
            {
                velx[i] = rand.Next(-10, 11);
                vely[i] = rand.Next(-10, 11);
            }

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += velx[0];
            label1.Top += vely[0];
            label1.Left += velx[0];
            label1.Top += velx[0];
            if (label1.Left <= 0)
            {
                velx[0] = -velx[0];
            }
        }
    }
}

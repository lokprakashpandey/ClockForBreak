using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_For_Break
{
    
    public partial class Form1 : Form
    {
        Timer t;
        int m=20, s=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();

            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            this.UseWaitCursor = true;
            t.Start();
            
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if(m == 0)
            {
                lblTime.Text = "Time Up";
                return;
            }
            if (s == 0)
            {
                m -= 1;
                s = 59;
            }
            else
            {
                s -= 1;
            }

            
            string time = "";

            if (m<10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s<10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            lblTime.Text = time;
            //System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");

        }
    }
}

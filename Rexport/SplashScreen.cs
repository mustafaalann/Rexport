using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Rexport
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if(panel2.Width >= 720)
            {
                timer1.Stop();
                Home h1 = new Home();
                h1.Show();
                this.Hide();
               
            }

        }
        

    }
}

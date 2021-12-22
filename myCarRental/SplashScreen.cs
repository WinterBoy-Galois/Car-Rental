using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCarRental
{
    public partial class SplashScreen : Form
    {
        
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {if (rectangleShape2.Width < 489)
            {
                try
                {
                    rectangleShape2.Width += 1;
                    if (rectangleShape2.Width >= 489)
                    {
                        timer1.Stop();

                        this.Hide();
                        Login.Instance.ShowDialog();
                        this.Close();

                    }
                    


                }
                catch (Exception)
                {
                    return;
                    
                }
            }
            

            
        }

        private void SplashScreen_Load_1(object sender, EventArgs e)
        {
                     

        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
           
        }
    }
}

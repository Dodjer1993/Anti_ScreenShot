using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anti_ScreenShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        Form2 frm = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            i += 1;
            if (i % 2 == 0) 
            {
                pictureBox1.BackColor = Color.Blue; 
                button1.Text = "ON";
                frm.Hide();
                
                
            }
            else
            { 
                pictureBox1.BackColor = Color.Black;
                button1.Text = "OF";
                frm.Owner = this;
                frm.Show();
                
            }
            
        }


    }
}

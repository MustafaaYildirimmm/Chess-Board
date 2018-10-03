using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int asciiDegeri = 65;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Label lbl = new Label();
                    lbl.Width = 50;
                    lbl.Height = 50;
                    lbl.Left = 75 + 50 * k;
                    lbl.Top = 75 + 50 * i;
                    lbl.Text = Convert.ToChar(asciiDegeri+k).ToString() + (8 - i).ToString();
                    if ((i+k)%2==0)
                    {
                        lbl.BackColor = Color.White;
                    }
                    else
                    {
                        lbl.BackColor = Color.Black;
                        lbl.ForeColor = Color.White;
                    }
                    this.Controls.Add(lbl);
                }
               
            }  
        }
    }
}

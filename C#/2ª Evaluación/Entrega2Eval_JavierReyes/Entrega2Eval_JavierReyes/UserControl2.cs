﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Entrega2Eval_JavierReyes
{
    public partial class UserControl2 : UserControl
    {
        public bool bstate1, bstate2, bstate3, bstate4, bstate5;
        public UserControl2()
        {
            ResetState();
            InitializeComponent();
        }

        private void ResetState()
        {
            bstate1 = false;
            bstate2 = false;
            bstate3 = false;
            bstate4 = false;
            bstate5 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bstate1)
            {
                button1.BackColor = Color.Black;
                bstate1 = false;
            }
            else
            {
                button1.BackColor = Color.FromArgb(172, 0, 0);
                bstate1 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bstate2)
            {
                button2.BackColor = Color.Black;
                bstate2 = false;
            }
            else
            {
                button2.BackColor = Color.FromArgb(172, 0, 0);
                bstate2 = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bstate3)
            {
                button3.BackColor = Color.Black;
                bstate3 = false;
            }
            else
            {
                button3.BackColor = Color.FromArgb(172, 0, 0);
                bstate3 = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bstate4)
            {
                button4.BackColor = Color.Black;
                bstate4 = false;
            }
            else
            {
                button4.BackColor = Color.FromArgb(172, 0, 0);
                bstate4 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bstate5)
            {
                button5.BackColor = Color.Black;
                bstate5 = false;
            }
            else
            {
                button5.BackColor = Color.FromArgb(172, 0, 0);
                bstate5 = true;
            }
        }

    }
}

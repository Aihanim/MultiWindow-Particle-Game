using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
   
        public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();

                buttonWinColor.Click += buttonWinColor_Click;
                buttonLoseColor.Click += buttonLoseColor_Click;

                buttonSave.Click += buttonSave_Click;
                buttonCancel.Click += buttonCancel_Click;

                radioCount60.Checked = true;
                radioSize15.Checked = true;

                panelWinColor.BackColor = Form1.col.WinColor;
                panelLoseColor.BackColor = Form1.col.LoseColor;
            }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void buttonWinColor_Click(object sender, EventArgs e)
            {
                colorDialog1.Color = panelWinColor.BackColor;

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    panelWinColor.BackColor = colorDialog1.Color;
                }
            }

            private void buttonLoseColor_Click(object sender, EventArgs e)
            {
                colorDialog1.Color = panelLoseColor.BackColor;

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    panelLoseColor.BackColor = colorDialog1.Color;
                }
            }

            private void buttonSave_Click(object sender, EventArgs e)
            {
                if (radioCount30.Checked)
                    Form1.col.Count = 30;
                else if (radioCount60.Checked)
                    Form1.col.Count = 60;
                else if (radioCount90.Checked)
                    Form1.col.Count = 90;
                

                if (radioSize10.Checked)
                    Form1.col.Size = 10;
                else if (radioSize15.Checked)
                    Form1.col.Size = 15;
                else if (radioSize20.Checked)
                    Form1.col.Size = 20;

                Form1.col.WinColor = panelWinColor.BackColor;
                Form1.col.LoseColor = panelLoseColor.BackColor;

                DialogResult = DialogResult.OK;

                Close();
            }

            private void buttonCancel_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }

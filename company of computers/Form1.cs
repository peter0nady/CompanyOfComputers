using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace company_of_computers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblcomtyp_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxone.Checked)
            {
                progressBar1.Value += 1;
                checkboxmany.Checked = false;
            }
            listboxreq.Items.Clear();
            listboxreq.Items.Add("need one computer");
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxmany.Checked)
            {
                progressBar1.Value += 1;
                checkboxone.Checked = false;
            }
            listboxreq.Items.Clear();
            listboxreq.Items.Add("need many computers");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnhp.Checked)
            {
                progressBar1.Value += 1;
                radiobtntoshipa.Checked = false;
                radiobtndell.Checked = false;
                radiobtnappel.Checked = false;
                radiobtnassis.Checked = false;
                listboxreq.Items.Remove("APPEL");
                listboxreq.Items.Remove("DELL");
                listboxreq.Items.Remove("TOSHIPA");
                listboxreq.Items.Remove("ASSIS");
                listboxreq.Items.Add("HP");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblrequirements_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radiobtncash.Checked)
            {
                progressBar1.Value += 1;
                radiobtncredit.Checked=false;
                radiobtnbank.Checked=false;
                listboxreq.Items.Remove("PAYMENT: CREDIT CARD");
                listboxreq.Items.Remove("PAYMENT: BANK ACCOUNT");
                listboxreq.Items.Add("PAYMENT: CASH");
            }
        }

        private void radiobtndell_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtndell.Checked)
            {
                progressBar1.Value += 1;
                radiobtntoshipa.Checked = false;
                radiobtnhp.Checked = false;
                radiobtnappel.Checked = false;
                radiobtnassis.Checked = false;
                listboxreq.Items.Remove("HP");
                listboxreq.Items.Remove("TOSHIPA");
                listboxreq.Items.Remove("APPEL");
                listboxreq.Items.Remove("ASSIS");
                listboxreq.Items.Add("DELL");
            }
        }

        private void radiobtnappel_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnappel.Checked)
            {
                progressBar1.Value += 1;
                radiobtntoshipa.Checked = false;
                radiobtndell.Checked = false;
                radiobtnhp.Checked = false;
                radiobtnassis.Checked = false;
                listboxreq.Items.Remove("HP");
                listboxreq.Items.Remove("DELL");
                listboxreq.Items.Remove("TOSHIPA");
                listboxreq.Items.Remove("ASSIS");
                listboxreq.Items.Add("APPEL");
            }
        }

        private void radiobtntoshipa_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtntoshipa.Checked)
            {
                progressBar1.Value += 1;
                radiobtnhp.Checked = false;
                radiobtndell.Checked = false;
                radiobtnappel.Checked = false;
                radiobtnassis.Checked = false;
                listboxreq.Items.Remove("HP");
                listboxreq.Items.Remove("DELL");
                listboxreq.Items.Remove("APPEL");
                listboxreq.Items.Remove("ASSIS");
                listboxreq.Items.Add("TOSHIPA");
            }
        }

        private void radiobtnassis_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnassis.Checked)
            {
                progressBar1.Value += 1;
                radiobtntoshipa.Checked = false;
                radiobtndell.Checked = false;
                radiobtnappel.Checked = false;
                radiobtnhp.Checked = false;
                listboxreq.Items.Remove("HP");
                listboxreq.Items.Remove("DELL");
                listboxreq.Items.Remove("TOSHIPA");
                listboxreq.Items.Remove("APPEL");
                listboxreq.Items.Add("ASSIS");
            }
        }

        private void comboboxscreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxscreen.SelectedItem);
        }

        private void comboboxhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxhd.SelectedItem);
           
        }

        private void comboboxkeyboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxkeyboard.SelectedItem);
            
        }

        private void comboboxmouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxmouse.SelectedItem);
            
        }

        private void comboboxproccessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxproccessor.SelectedIndex);
           
        }

        private void comboboxram_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxreq.Items.Add(comboboxram.SelectedItem);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radiobtncredit_CheckedChanged(object sender, EventArgs e)
        {
          if(radiobtncredit.Checked)
            {
                progressBar1.Value += 1;
                radiobtncash.Checked=false;
                radiobtnbank.Checked=false;
                listboxreq.Items.Remove("PAYMENT: CASH");
                listboxreq.Items.Remove("PAYMENT: BANK ACCOUNT");
                listboxreq.Items.Add("PAYMENT: CREDIT CARD");
          }
        }

        private void radiobtnbank_CheckedChanged(object sender, EventArgs e)
        {
        if(radiobtnbank.Checked)
            {
                progressBar1.Value += 1;
                radiobtncredit.Checked=false;
                radiobtncash.Checked=false;
                listboxreq.Items.Remove("PAYMENT: CREDIT CARD");
                listboxreq.Items.Remove("PAYMENT: CASH");
                listboxreq.Items.Add("PAYMENT: BANK ACCOUNT");
            }
        }

        private void lblcost_Click(object sender, EventArgs e)
        {
            
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            int a, b, c, d, g, f, sum;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            g = 0;
            f = 0;
            sum = 0;
            if (comboboxscreen.SelectedItem.ToString() == "CRT")
            {
                a = 200;
                progressBar1.Value += 1;

            }
            else if (comboboxscreen.SelectedItem.ToString() == "LCD")
            {
                a = 300;
                progressBar1.Value += 1;
            }
            else if (comboboxscreen.SelectedItem.ToString() == "TFT")
            {
                a = 500;
                progressBar1.Value += 1;
            }
            else if (comboboxscreen.SelectedItem.ToString() == "Plasma")
            {
                a = 700;
                progressBar1.Value += 1;
            }

            if (comboboxhd.SelectedItem.ToString() == "HDD")
            {
                d = 200;
                progressBar1.Value += 1;
            }
            else if (comboboxhd.SelectedItem.ToString() == "SSD")
            {
                d = 300;
                progressBar1.Value += 1;
            }
            else if (comboboxhd.SelectedItem.ToString() == "SSHD")
            {
                d = 400;
                progressBar1.Value += 1;
            }
            if (comboboxkeyboard.SelectedItem.ToString() == "wirier keyboard")
            {
                b = 10;
                progressBar1.Value += 1;
            }
            else if (comboboxkeyboard.SelectedItem.ToString() == "unwirier keyboard")
            {
                b = 20;
                progressBar1.Value += 1;
            }
            else if (comboboxkeyboard.SelectedItem.ToString() == "waterproof keyboard")
            {
                b = 30;
                progressBar1.Value += 1;
            }
            if (comboboxmouse.SelectedItem.ToString() == "SCROLL MOUS")
            {
                c = 10;
                progressBar1.Value += 1;
            }
            else if (comboboxmouse.SelectedItem.ToString() == "NORMAL")
            {
                c = 20;
                progressBar1.Value += 1;
            }
            else if (comboboxmouse.SelectedItem.ToString() == "UNWIRIER MOUSE")
            {
                c = 30;
                progressBar1.Value += 1;
            }
            if (comboboxproccessor.SelectedItem.ToString() == "pentium 4")
            {
                f = 50;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "pentium D")
            {
                f = 80;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "intel Dual core")
            {
                f = 100;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "intel core 2 Duo")
            {
                f = 120;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "intel core Duo")
            {
                f = 140;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "intel core 2 Extreme")
            {
                f = 160;
                progressBar1.Value += 1;
            }
            else if (comboboxproccessor.SelectedItem.ToString() == "intel Xeon")
            {
                f = 200;
                progressBar1.Value += 1;
            }
            if (comboboxram.SelectedItem.ToString() == "1Gegabayt")
            {
                g = 100;
                progressBar1.Value += 1;
            }
            else if (comboboxram.SelectedItem.ToString() == "2Gegabayt")
            {
                g = 150;
                progressBar1.Value += 1;
            }
            else if (comboboxram.SelectedItem.ToString() == "3Gegabayt")
            {
                g = 200;
                progressBar1.Value += 1;
            }
            else if (comboboxram.SelectedItem.ToString() == "4Gegabayt")
            {
                g = 250;
                progressBar1.Value += 1;
            }
            sum = (a + b + c + d + g + f);
            lbltotal.Text = sum.ToString();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txttellnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you ");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 12)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(listboxreq.Text);
                    sw.Close();
                    fs.Close();
                }
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                progressBar1.Value += 1;
                txtaddress.Focus();
                listboxreq.Items.Add(txtname.Text);
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                progressBar1.Value += 1;
                txttellnum.Focus();
                listboxreq.Items.Add(txtaddress.Text);
            }
        }

        private void txttellnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                progressBar1.Value += 1;
                listboxreq.Items.Add(txttellnum.Text);
            }
        }
    }
}

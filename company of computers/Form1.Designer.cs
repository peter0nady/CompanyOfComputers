namespace company_of_computers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbltelnum = new System.Windows.Forms.Label();
            this.txttellnum = new System.Windows.Forms.TextBox();
            this.checkboxone = new System.Windows.Forms.CheckBox();
            this.checkboxmany = new System.Windows.Forms.CheckBox();
            this.radiobtnhp = new System.Windows.Forms.RadioButton();
            this.radiobtndell = new System.Windows.Forms.RadioButton();
            this.radiobtnappel = new System.Windows.Forms.RadioButton();
            this.radiobtntoshipa = new System.Windows.Forms.RadioButton();
            this.radiobtnassis = new System.Windows.Forms.RadioButton();
            this.comboboxscreen = new System.Windows.Forms.ComboBox();
            this.comboboxkeyboard = new System.Windows.Forms.ComboBox();
            this.comboboxram = new System.Windows.Forms.ComboBox();
            this.comboboxproccessor = new System.Windows.Forms.ComboBox();
            this.comboboxhd = new System.Windows.Forms.ComboBox();
            this.comboboxmouse = new System.Windows.Forms.ComboBox();
            this.listboxreq = new System.Windows.Forms.ListBox();
            this.lblrequirements = new System.Windows.Forms.Label();
            this.radiobtncash = new System.Windows.Forms.RadioButton();
            this.radiobtncredit = new System.Windows.Forms.RadioButton();
            this.radiobtnbank = new System.Windows.Forms.RadioButton();
            this.lblcost = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(56, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(179, 18);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(50, 13);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Address:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(235, 15);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            this.txtaddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddress_KeyPress);
            // 
            // lbltelnum
            // 
            this.lbltelnum.AutoSize = true;
            this.lbltelnum.Location = new System.Drawing.Point(364, 18);
            this.lbltelnum.Name = "lbltelnum";
            this.lbltelnum.Size = new System.Drawing.Size(53, 13);
            this.lbltelnum.TabIndex = 4;
            this.lbltelnum.Text = "Tell_num:";
            // 
            // txttellnum
            // 
            this.txttellnum.Location = new System.Drawing.Point(427, 18);
            this.txttellnum.Name = "txttellnum";
            this.txttellnum.Size = new System.Drawing.Size(100, 20);
            this.txttellnum.TabIndex = 5;
            this.txttellnum.TextChanged += new System.EventHandler(this.txttellnum_TextChanged);
            this.txttellnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttellnum_KeyPress);
            // 
            // checkboxone
            // 
            this.checkboxone.AutoSize = true;
            this.checkboxone.Location = new System.Drawing.Point(107, 44);
            this.checkboxone.Name = "checkboxone";
            this.checkboxone.Size = new System.Drawing.Size(143, 17);
            this.checkboxone.TabIndex = 7;
            this.checkboxone.Text = "Need only one computer";
            this.checkboxone.UseVisualStyleBackColor = true;
            this.checkboxone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkboxmany
            // 
            this.checkboxmany.AutoSize = true;
            this.checkboxmany.Location = new System.Drawing.Point(313, 44);
            this.checkboxmany.Name = "checkboxmany";
            this.checkboxmany.Size = new System.Drawing.Size(133, 17);
            this.checkboxmany.TabIndex = 8;
            this.checkboxmany.Text = "Need many computers";
            this.checkboxmany.UseVisualStyleBackColor = true;
            this.checkboxmany.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radiobtnhp
            // 
            this.radiobtnhp.AutoSize = true;
            this.radiobtnhp.Location = new System.Drawing.Point(21, 30);
            this.radiobtnhp.Name = "radiobtnhp";
            this.radiobtnhp.Size = new System.Drawing.Size(38, 17);
            this.radiobtnhp.TabIndex = 9;
            this.radiobtnhp.TabStop = true;
            this.radiobtnhp.Text = "HP";
            this.radiobtnhp.UseVisualStyleBackColor = true;
            this.radiobtnhp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiobtndell
            // 
            this.radiobtndell.AutoSize = true;
            this.radiobtndell.Location = new System.Drawing.Point(282, 30);
            this.radiobtndell.Name = "radiobtndell";
            this.radiobtndell.Size = new System.Drawing.Size(48, 17);
            this.radiobtndell.TabIndex = 10;
            this.radiobtndell.TabStop = true;
            this.radiobtndell.Text = "DELL";
            this.radiobtndell.UseVisualStyleBackColor = true;
            this.radiobtndell.CheckedChanged += new System.EventHandler(this.radiobtndell_CheckedChanged);
            // 
            // radiobtnappel
            // 
            this.radiobtnappel.AutoSize = true;
            this.radiobtnappel.Location = new System.Drawing.Point(108, 30);
            this.radiobtnappel.Name = "radiobtnappel";
            this.radiobtnappel.Size = new System.Drawing.Size(55, 17);
            this.radiobtnappel.TabIndex = 11;
            this.radiobtnappel.TabStop = true;
            this.radiobtnappel.Text = "APPEL";
            this.radiobtnappel.UseVisualStyleBackColor = true;
            this.radiobtnappel.CheckedChanged += new System.EventHandler(this.radiobtnappel_CheckedChanged);
            // 
            // radiobtntoshipa
            // 
            this.radiobtntoshipa.AutoSize = true;
            this.radiobtntoshipa.Location = new System.Drawing.Point(379, 30);
            this.radiobtntoshipa.Name = "radiobtntoshipa";
            this.radiobtntoshipa.Size = new System.Drawing.Size(69, 17);
            this.radiobtntoshipa.TabIndex = 12;
            this.radiobtntoshipa.TabStop = true;
            this.radiobtntoshipa.Text = "TOSHIPA";
            this.radiobtntoshipa.UseVisualStyleBackColor = true;
            this.radiobtntoshipa.CheckedChanged += new System.EventHandler(this.radiobtntoshipa_CheckedChanged);
            // 
            // radiobtnassis
            // 
            this.radiobtnassis.AutoSize = true;
            this.radiobtnassis.Location = new System.Drawing.Point(191, 30);
            this.radiobtnassis.Name = "radiobtnassis";
            this.radiobtnassis.Size = new System.Drawing.Size(54, 17);
            this.radiobtnassis.TabIndex = 13;
            this.radiobtnassis.TabStop = true;
            this.radiobtnassis.Text = "ASSIS";
            this.radiobtnassis.UseVisualStyleBackColor = true;
            this.radiobtnassis.CheckedChanged += new System.EventHandler(this.radiobtnassis_CheckedChanged);
            // 
            // comboboxscreen
            // 
            this.comboboxscreen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxscreen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxscreen.FormattingEnabled = true;
            this.comboboxscreen.Items.AddRange(new object[] {
            "CRT",
            "LCD",
            "TFT",
            "Plasma"});
            this.comboboxscreen.Location = new System.Drawing.Point(11, 16);
            this.comboboxscreen.Name = "comboboxscreen";
            this.comboboxscreen.Size = new System.Drawing.Size(121, 21);
            this.comboboxscreen.TabIndex = 14;
            this.comboboxscreen.Text = "Screen";
            this.comboboxscreen.SelectedIndexChanged += new System.EventHandler(this.comboboxscreen_SelectedIndexChanged);
            // 
            // comboboxkeyboard
            // 
            this.comboboxkeyboard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxkeyboard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxkeyboard.FormattingEnabled = true;
            this.comboboxkeyboard.Items.AddRange(new object[] {
            "wirier keyboard",
            "unwirier keyboard",
            "waterproof keyboard"});
            this.comboboxkeyboard.Location = new System.Drawing.Point(221, 16);
            this.comboboxkeyboard.Name = "comboboxkeyboard";
            this.comboboxkeyboard.Size = new System.Drawing.Size(121, 21);
            this.comboboxkeyboard.TabIndex = 15;
            this.comboboxkeyboard.Text = "Key board ";
            this.comboboxkeyboard.SelectedIndexChanged += new System.EventHandler(this.comboboxkeyboard_SelectedIndexChanged);
            // 
            // comboboxram
            // 
            this.comboboxram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxram.FormattingEnabled = true;
            this.comboboxram.Items.AddRange(new object[] {
            "1Gegabayt",
            "2Gegabaty",
            "3Gegabayt",
            "4Gegabyte"});
            this.comboboxram.Location = new System.Drawing.Point(415, 48);
            this.comboboxram.Name = "comboboxram";
            this.comboboxram.Size = new System.Drawing.Size(121, 21);
            this.comboboxram.TabIndex = 16;
            this.comboboxram.Text = "Ram Size";
            this.comboboxram.SelectedIndexChanged += new System.EventHandler(this.comboboxram_SelectedIndexChanged);
            // 
            // comboboxproccessor
            // 
            this.comboboxproccessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxproccessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxproccessor.FormattingEnabled = true;
            this.comboboxproccessor.Items.AddRange(new object[] {
            "pentium 4",
            "pentium D",
            "intel core 2 Duo",
            "intel Dual core",
            "intel core Duo",
            "intel core 2 Extreme",
            "intel Xeon"});
            this.comboboxproccessor.Location = new System.Drawing.Point(11, 48);
            this.comboboxproccessor.Name = "comboboxproccessor";
            this.comboboxproccessor.Size = new System.Drawing.Size(121, 21);
            this.comboboxproccessor.TabIndex = 17;
            this.comboboxproccessor.Text = "Processors Type";
            this.comboboxproccessor.SelectedIndexChanged += new System.EventHandler(this.comboboxproccessor_SelectedIndexChanged);
            // 
            // comboboxhd
            // 
            this.comboboxhd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxhd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxhd.FormattingEnabled = true;
            this.comboboxhd.Items.AddRange(new object[] {
            "HDD",
            "SSD",
            "SSHD"});
            this.comboboxhd.Location = new System.Drawing.Point(221, 48);
            this.comboboxhd.Name = "comboboxhd";
            this.comboboxhd.Size = new System.Drawing.Size(121, 21);
            this.comboboxhd.TabIndex = 18;
            this.comboboxhd.Text = "Hard Disk";
            this.comboboxhd.SelectedIndexChanged += new System.EventHandler(this.comboboxhd_SelectedIndexChanged);
            // 
            // comboboxmouse
            // 
            this.comboboxmouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxmouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxmouse.FormattingEnabled = true;
            this.comboboxmouse.Items.AddRange(new object[] {
            "NORMAL",
            "SCROLL MOUSE",
            "UNWIRIER MOUS"});
            this.comboboxmouse.Location = new System.Drawing.Point(415, 16);
            this.comboboxmouse.Name = "comboboxmouse";
            this.comboboxmouse.Size = new System.Drawing.Size(121, 21);
            this.comboboxmouse.TabIndex = 19;
            this.comboboxmouse.Text = "Mous Type";
            this.comboboxmouse.SelectedIndexChanged += new System.EventHandler(this.comboboxmouse_SelectedIndexChanged);
            // 
            // listboxreq
            // 
            this.listboxreq.FormattingEnabled = true;
            this.listboxreq.Location = new System.Drawing.Point(427, 240);
            this.listboxreq.Name = "listboxreq";
            this.listboxreq.Size = new System.Drawing.Size(133, 134);
            this.listboxreq.TabIndex = 20;
            this.listboxreq.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblrequirements
            // 
            this.lblrequirements.AutoSize = true;
            this.lblrequirements.Location = new System.Drawing.Point(466, 224);
            this.lblrequirements.Name = "lblrequirements";
            this.lblrequirements.Size = new System.Drawing.Size(85, 13);
            this.lblrequirements.TabIndex = 21;
            this.lblrequirements.Text = "REQUIREMENTS";
            this.lblrequirements.Click += new System.EventHandler(this.lblrequirements_Click);
            // 
            // radiobtncash
            // 
            this.radiobtncash.AutoSize = true;
            this.radiobtncash.Location = new System.Drawing.Point(15, 19);
            this.radiobtncash.Name = "radiobtncash";
            this.radiobtncash.Size = new System.Drawing.Size(52, 17);
            this.radiobtncash.TabIndex = 24;
            this.radiobtncash.TabStop = true;
            this.radiobtncash.Text = "CASH";
            this.radiobtncash.UseVisualStyleBackColor = true;
            this.radiobtncash.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radiobtncredit
            // 
            this.radiobtncredit.AutoSize = true;
            this.radiobtncredit.Location = new System.Drawing.Point(15, 42);
            this.radiobtncredit.Name = "radiobtncredit";
            this.radiobtncredit.Size = new System.Drawing.Size(80, 17);
            this.radiobtncredit.TabIndex = 25;
            this.radiobtncredit.TabStop = true;
            this.radiobtncredit.Text = "Credit Card";
            this.radiobtncredit.UseVisualStyleBackColor = true;
            this.radiobtncredit.CheckedChanged += new System.EventHandler(this.radiobtncredit_CheckedChanged);
            // 
            // radiobtnbank
            // 
            this.radiobtnbank.AutoSize = true;
            this.radiobtnbank.Location = new System.Drawing.Point(13, 65);
            this.radiobtnbank.Name = "radiobtnbank";
            this.radiobtnbank.Size = new System.Drawing.Size(90, 17);
            this.radiobtnbank.TabIndex = 26;
            this.radiobtnbank.TabStop = true;
            this.radiobtnbank.Text = "Bank Account";
            this.radiobtnbank.UseVisualStyleBackColor = true;
            this.radiobtnbank.CheckedChanged += new System.EventHandler(this.radiobtnbank_CheckedChanged);
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Location = new System.Drawing.Point(411, 377);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(47, 13);
            this.lblcost.TabIndex = 27;
            this.lblcost.Text = "Costing:";
            this.lblcost.Click += new System.EventHandler(this.lblcost_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(475, 377);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(85, 13);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "_____________";
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(15, 391);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(135, 42);
            this.btnorder.TabIndex = 29;
            this.btnorder.Text = "total of order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(427, 410);
            this.progressBar1.Maximum = 12;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.Step = 0;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 30;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboboxscreen);
            this.panel1.Controls.Add(this.comboboxproccessor);
            this.panel1.Controls.Add(this.comboboxkeyboard);
            this.panel1.Controls.Add(this.comboboxhd);
            this.panel1.Controls.Add(this.comboboxram);
            this.panel1.Controls.Add(this.comboboxmouse);
            this.panel1.Location = new System.Drawing.Point(15, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 79);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(445, 439);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(141, 42);
            this.btncancle.TabIndex = 32;
            this.btncancle.Text = "cancle order";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(172, 389);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 44);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "save order";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnhp);
            this.groupBox1.Controls.Add(this.radiobtndell);
            this.groupBox1.Controls.Add(this.radiobtnappel);
            this.groupBox1.Controls.Add(this.radiobtntoshipa);
            this.groupBox1.Controls.Add(this.radiobtnassis);
            this.groupBox1.Location = new System.Drawing.Point(15, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 63);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computer Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtncash);
            this.groupBox2.Controls.Add(this.radiobtncredit);
            this.groupBox2.Controls.Add(this.radiobtnbank);
            this.groupBox2.Location = new System.Drawing.Point(15, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 110);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblrequirements);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.listboxreq);
            this.Controls.Add(this.checkboxmany);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.checkboxone);
            this.Controls.Add(this.txttellnum);
            this.Controls.Add(this.lbltelnum);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbltelnum;
        private System.Windows.Forms.TextBox txttellnum;
        private System.Windows.Forms.CheckBox checkboxone;
        private System.Windows.Forms.CheckBox checkboxmany;
        private System.Windows.Forms.RadioButton radiobtnhp;
        private System.Windows.Forms.RadioButton radiobtndell;
        private System.Windows.Forms.RadioButton radiobtnappel;
        private System.Windows.Forms.RadioButton radiobtntoshipa;
        private System.Windows.Forms.RadioButton radiobtnassis;
        private System.Windows.Forms.ComboBox comboboxscreen;
        private System.Windows.Forms.ComboBox comboboxkeyboard;
        private System.Windows.Forms.ComboBox comboboxram;
        private System.Windows.Forms.ComboBox comboboxproccessor;
        private System.Windows.Forms.ComboBox comboboxhd;
        private System.Windows.Forms.ComboBox comboboxmouse;
        private System.Windows.Forms.ListBox listboxreq;
        private System.Windows.Forms.Label lblrequirements;
        private System.Windows.Forms.RadioButton radiobtncash;
        private System.Windows.Forms.RadioButton radiobtncredit;
        private System.Windows.Forms.RadioButton radiobtnbank;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


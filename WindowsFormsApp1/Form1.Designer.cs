namespace WindowsFormsApp1
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lbFakultet = new System.Windows.Forms.ListBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.nupIspit = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.vozackadozvola = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbMjestoRodjenja = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.mcKalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nupIspit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(243, 205);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(65, 79);
            this.btnPotvrdi.TabIndex = 41;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // lbFakultet
            // 
            this.lbFakultet.FormattingEnabled = true;
            this.lbFakultet.Items.AddRange(new object[] {
            "FESB",
            "PMF",
            "Ekonomski",
            "Pravni",
            "Građevinski",
            "Medicinski",
            "DIF"});
            this.lbFakultet.Location = new System.Drawing.Point(97, 215);
            this.lbFakultet.Name = "lbFakultet";
            this.lbFakultet.Size = new System.Drawing.Size(124, 69);
            this.lbFakultet.TabIndex = 40;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(46, 215);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 39;
            this.Label7.Text = "Fakultet";
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Location = new System.Drawing.Point(104, 185);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(61, 17);
            this.rbZensko.TabIndex = 38;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Žensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Location = new System.Drawing.Point(104, 162);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(57, 17);
            this.rbMusko.TabIndex = 37;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Muško";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(70, 162);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Spol";
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Location = new System.Drawing.Point(104, 136);
            this.MaskedTextBox1.Mask = "(999)000-00-00";
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox1.TabIndex = 35;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(58, 136);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 13);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Mobilni";
            // 
            // nupIspit
            // 
            this.nupIspit.Location = new System.Drawing.Point(107, 110);
            this.nupIspit.Name = "nupIspit";
            this.nupIspit.Size = new System.Drawing.Size(68, 20);
            this.nupIspit.TabIndex = 33;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 107);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 13);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Ukupan broj ispita";
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(221, 87);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(34, 17);
            this.cbD.TabIndex = 31;
            this.cbD.Text = "D";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(182, 87);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 17);
            this.cbC.TabIndex = 30;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(143, 87);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(33, 17);
            this.cbB.TabIndex = 29;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(104, 87);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(33, 17);
            this.cbA.TabIndex = 28;
            this.cbA.Text = "A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // vozackadozvola
            // 
            this.vozackadozvola.AutoSize = true;
            this.vozackadozvola.Location = new System.Drawing.Point(9, 84);
            this.vozackadozvola.Name = "vozackadozvola";
            this.vozackadozvola.Size = new System.Drawing.Size(89, 13);
            this.vozackadozvola.TabIndex = 27;
            this.vozackadozvola.Text = "Vozacka dozvola";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(90, 61);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(202, 20);
            this.dtpDatumRodjenja.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "datum rođenja";
            // 
            // cbMjestoRodjenja
            // 
            this.cbMjestoRodjenja.FormattingEnabled = true;
            this.cbMjestoRodjenja.Items.AddRange(new object[] {
            "Split",
            "Solin",
            "Dugopolje",
            "Zadar",
            "Imotski",
            "Sinj"});
            this.cbMjestoRodjenja.Location = new System.Drawing.Point(91, 34);
            this.cbMjestoRodjenja.Name = "cbMjestoRodjenja";
            this.cbMjestoRodjenja.Size = new System.Drawing.Size(202, 21);
            this.cbMjestoRodjenja.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "mjesto rođenja";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(91, 10);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 22;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Ime i Prezime";
            // 
            // mcKalendar
            // 
            this.mcKalendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.mcKalendar.Location = new System.Drawing.Point(382, 0);
            this.mcKalendar.Name = "mcKalendar";
            this.mcKalendar.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 308);
            this.Controls.Add(this.mcKalendar);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lbFakultet);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.rbZensko);
            this.Controls.Add(this.rbMusko);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.MaskedTextBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.nupIspit);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.vozackadozvola);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbMjestoRodjenja);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupIspit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPotvrdi;
        internal System.Windows.Forms.ListBox lbFakultet;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.RadioButton rbZensko;
        internal System.Windows.Forms.RadioButton rbMusko;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown nupIspit;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox cbD;
        internal System.Windows.Forms.CheckBox cbC;
        internal System.Windows.Forms.CheckBox cbB;
        internal System.Windows.Forms.CheckBox cbA;
        internal System.Windows.Forms.Label vozackadozvola;
        internal System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbMjestoRodjenja;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtIme;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MonthCalendar mcKalendar;
    }
}


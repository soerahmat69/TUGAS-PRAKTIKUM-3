using System;

namespace P3_4_1204017
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama                  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir      :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(251, 70);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(100, 20);
            this.nama.TabIndex = 3;
            this.nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbJK.Items.AddRange(new object[] {
            "PEREMPUAN",
            "LAKI-LAKI"});
            this.cbJK.Location = new System.Drawing.Point(247, 104);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(135, 21);
            this.cbJK.TabIndex = 4;
            this.cbJK.Text = "-- Pilih Jenis Kelamin --";
            this.cbJK.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(247, 137);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(200, 20);
            this.dtTglLahir.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKomposer);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbKonduktor);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Location = new System.Drawing.Point(16, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(137, 139);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(73, 17);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(137, 99);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(137, 59);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(51, 17);
            this.cbDrum.TabIndex = 5;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            this.cbDrum.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(137, 19);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbKonduktor.Location = new System.Drawing.Point(6, 139);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbKonduktor.UseVisualStyleBackColor = true;
            this.cbKonduktor.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(6, 99);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(80, 17);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(6, 59);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(6, 19);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Location = new System.Drawing.Point(276, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 181);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(7, 32);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(171, 17);
            this.rbJadwal1.TabIndex = 4;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin &&  Selasa , 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(7, 130);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(129, 17);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu 13.00 -  17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(7, 98);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(169, 17);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(7, 67);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(161, 17);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Senin && Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(182, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Tampilkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(283, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Selesai ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Label label4;
    }
}


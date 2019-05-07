namespace AsyncFormExample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestClick = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblRenk = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProccessFileAsync = new System.Windows.Forms.Button();
            this.btnProccessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRenk);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Controls.Add(this.btnTestClick);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test İşlemleri";
            // 
            // btnTestClick
            // 
            this.btnTestClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestClick.Location = new System.Drawing.Point(16, 53);
            this.btnTestClick.Name = "btnTestClick";
            this.btnTestClick.Size = new System.Drawing.Size(233, 56);
            this.btnTestClick.TabIndex = 6;
            this.btnTestClick.Text = "Tıkla";
            this.btnTestClick.UseVisualStyleBackColor = true;
            this.btnTestClick.Click += new System.EventHandler(this.btnTestClick_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(16, 139);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 20);
            this.lblTest.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(364, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Kırmızı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(465, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 29);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Mavi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(271, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 29);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Siyah";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenk.Location = new System.Drawing.Point(578, 69);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(125, 25);
            this.lblRenk.TabIndex = 11;
            this.lblRenk.Text = "Siyah Seçildi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProccessFileAsync);
            this.groupBox2.Controls.Add(this.btnProccessFile);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplamalar";
            // 
            // btnProccessFileAsync
            // 
            this.btnProccessFileAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProccessFileAsync.Location = new System.Drawing.Point(293, 41);
            this.btnProccessFileAsync.Name = "btnProccessFileAsync";
            this.btnProccessFileAsync.Size = new System.Drawing.Size(233, 56);
            this.btnProccessFileAsync.TabIndex = 10;
            this.btnProccessFileAsync.Text = "Asenkron Hesapla";
            this.btnProccessFileAsync.UseVisualStyleBackColor = true;
            this.btnProccessFileAsync.Click += new System.EventHandler(this.btnProccessFileAsync_Click);
            this.btnProccessFileAsync.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnProccessFileAsync_MouseDown);
            // 
            // btnProccessFile
            // 
            this.btnProccessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProccessFile.Location = new System.Drawing.Point(20, 41);
            this.btnProccessFile.Name = "btnProccessFile";
            this.btnProccessFile.Size = new System.Drawing.Size(233, 56);
            this.btnProccessFile.TabIndex = 9;
            this.btnProccessFile.Text = "Senkron Hesapla";
            this.btnProccessFile.UseVisualStyleBackColor = true;
            this.btnProccessFile.Click += new System.EventHandler(this.btnProccessFile_Click);
            this.btnProccessFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnProccessFile_MouseDown);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(52, 147);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 25);
            this.lblCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dosya İçindeki Karakter Sayısını Hesaplama (Async - Await)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnTestClick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProccessFileAsync;
        private System.Windows.Forms.Button btnProccessFile;
        private System.Windows.Forms.Label lblCount;
    }
}


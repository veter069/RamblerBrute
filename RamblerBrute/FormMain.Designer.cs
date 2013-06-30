namespace RamblerBrute
{
    partial class BtnStart
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnStart));
            this.source = new System.Windows.Forms.Button();
            this.proxy = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.txtDelimeter = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.Cbproxytype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GUI = new System.Windows.Forms.Timer(this.components);
            this.nThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(8, 12);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(91, 23);
            this.source.TabIndex = 0;
            this.source.Text = "Source";
            this.source.UseVisualStyleBackColor = true;
            this.source.Click += new System.EventHandler(this.source_Click);
            // 
            // proxy
            // 
            this.proxy.Location = new System.Drawing.Point(105, 12);
            this.proxy.Name = "proxy";
            this.proxy.Size = new System.Drawing.Size(97, 23);
            this.proxy.TabIndex = 1;
            this.proxy.Text = "Proxy";
            this.proxy.UseVisualStyleBackColor = true;
            this.proxy.Click += new System.EventHandler(this.proxy_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(161, 77);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(41, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // txtDelimeter
            // 
            this.txtDelimeter.Location = new System.Drawing.Point(70, 38);
            this.txtDelimeter.MaxLength = 1;
            this.txtDelimeter.Name = "txtDelimeter";
            this.txtDelimeter.Size = new System.Drawing.Size(12, 21);
            this.txtDelimeter.TabIndex = 3;
            this.txtDelimeter.Text = ";";
            this.txtDelimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelimeter.TextChanged += new System.EventHandler(this.txtDelimeter_TextChanged);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLog.Location = new System.Drawing.Point(208, 28);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(110, 73);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "Source: 0\r\nProxy: 0\r\nGood: 0\r\nBad: 0\r\nPPS: 0\r\n";
            // 
            // Cbproxytype
            // 
            this.Cbproxytype.FormattingEnabled = true;
            this.Cbproxytype.Items.AddRange(new object[] {
            "HTTP",
            "Socks 4",
            "Socks 5"});
            this.Cbproxytype.Location = new System.Drawing.Point(143, 38);
            this.Cbproxytype.Name = "Cbproxytype";
            this.Cbproxytype.Size = new System.Drawing.Size(59, 21);
            this.Cbproxytype.TabIndex = 5;
            this.Cbproxytype.Text = "HTTP";
            this.Cbproxytype.SelectedIndexChanged += new System.EventHandler(this.proxytype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delimiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Statistic:";
            // 
            // GUI
            // 
            this.GUI.Enabled = true;
            this.GUI.Interval = 1000;
            this.GUI.Tick += new System.EventHandler(this.GUI_Tick);
            // 
            // nThreads
            // 
            this.nThreads.Location = new System.Drawing.Point(105, 79);
            this.nThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.Name = "nThreads";
            this.nThreads.Size = new System.Drawing.Size(50, 21);
            this.nThreads.TabIndex = 9;
            this.nThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.ValueChanged += new System.EventHandler(this.nThreads_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Threads:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 109);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nThreads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbproxytype);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDelimeter);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.proxy);
            this.Controls.Add(this.source);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BtnStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rambler Brute";
            this.Load += new System.EventHandler(this.BtnStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button source;
        private System.Windows.Forms.Button proxy;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox txtDelimeter;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox Cbproxytype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer GUI;
        private System.Windows.Forms.NumericUpDown nThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


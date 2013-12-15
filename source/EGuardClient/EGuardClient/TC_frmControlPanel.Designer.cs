namespace EGuardClient
{
    partial class TC_frmControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TC_frmControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTimeControl = new System.Windows.Forms.Button();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.NumericUpDown();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblTimeControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(302, 363);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(26, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTimeControl
            // 
            this.btnTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeControl.Location = new System.Drawing.Point(500, 219);
            this.btnTimeControl.Name = "btnTimeControl";
            this.btnTimeControl.Size = new System.Drawing.Size(112, 23);
            this.btnTimeControl.TabIndex = 25;
            this.btnTimeControl.Text = "Save Day/Time";
            this.btnTimeControl.UseVisualStyleBackColor = true;
            this.btnTimeControl.Click += new System.EventHandler(this.btnTimeControl_Click);
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(343, 203);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(60, 13);
            this.lblTimeEnd.TabIndex = 24;
            this.lblTimeEnd.Text = "End Time";
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(318, 219);
            this.timeEnd.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(120, 20);
            this.timeEnd.TabIndex = 23;
            this.timeEnd.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(198, 203);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(61, 13);
            this.lblTime1.TabIndex = 22;
            this.lblTime1.Text = "StartTime";
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(182, 219);
            this.timeStart.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(120, 20);
            this.timeStart.TabIndex = 21;
            this.timeStart.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(71, 203);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 20;
            this.lblDays.Text = "Days";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.checkedListBox1.Location = new System.Drawing.Point(26, 219);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 109);
            this.checkedListBox1.TabIndex = 19;
            // 
            // lblTimeControl
            // 
            this.lblTimeControl.AutoSize = true;
            this.lblTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeControl.Location = new System.Drawing.Point(261, 174);
            this.lblTimeControl.Name = "lblTimeControl";
            this.lblTimeControl.Size = new System.Drawing.Size(100, 17);
            this.lblTimeControl.TabIndex = 18;
            this.lblTimeControl.Text = "Time Control";
            // 
            // TC_frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 524);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimeControl);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblTimeControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TC_frmControlPanel";
            this.Text = "EGuard Time Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTimeControl;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.NumericUpDown timeEnd;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.NumericUpDown timeStart;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblTimeControl;
    }
}
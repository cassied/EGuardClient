namespace EGuardClient
{
    partial class frmControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblURLs = new System.Windows.Forms.Label();
            this.lvSuggestedURLs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBlockedURLs = new System.Windows.Forms.ListView();
            this.lblBlockedURLs = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnRemoveBlock = new System.Windows.Forms.Button();
            this.lblTimeControl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.NumericUpDown();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.NumericUpDown();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.btnTimeControl = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblURLs
            // 
            this.lblURLs.AutoSize = true;
            this.lblURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLs.Location = new System.Drawing.Point(253, 172);
            this.lblURLs.Name = "lblURLs";
            this.lblURLs.Size = new System.Drawing.Size(136, 17);
            this.lblURLs.TabIndex = 1;
            this.lblURLs.Text = "URL Management";
            // 
            // lvSuggestedURLs
            // 
            this.lvSuggestedURLs.Location = new System.Drawing.Point(29, 222);
            this.lvSuggestedURLs.Name = "lvSuggestedURLs";
            this.lvSuggestedURLs.Size = new System.Drawing.Size(260, 97);
            this.lvSuggestedURLs.TabIndex = 2;
            this.lvSuggestedURLs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suggested Blocked URLs";
            // 
            // lvBlockedURLs
            // 
            this.lvBlockedURLs.Location = new System.Drawing.Point(393, 222);
            this.lvBlockedURLs.Name = "lvBlockedURLs";
            this.lvBlockedURLs.Size = new System.Drawing.Size(260, 97);
            this.lvBlockedURLs.TabIndex = 4;
            this.lvBlockedURLs.UseCompatibleStateImageBehavior = false;
            // 
            // lblBlockedURLs
            // 
            this.lblBlockedURLs.AutoSize = true;
            this.lblBlockedURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockedURLs.Location = new System.Drawing.Point(466, 206);
            this.lblBlockedURLs.Name = "lblBlockedURLs";
            this.lblBlockedURLs.Size = new System.Drawing.Size(88, 13);
            this.lblBlockedURLs.TabIndex = 5;
            this.lblBlockedURLs.Text = "Blocked URLs";
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.Location = new System.Drawing.Point(302, 237);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 6;
            this.btnBlock.Text = ">>";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBlock
            // 
            this.btnRemoveBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBlock.Location = new System.Drawing.Point(302, 261);
            this.btnRemoveBlock.Name = "btnRemoveBlock";
            this.btnRemoveBlock.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBlock.TabIndex = 7;
            this.btnRemoveBlock.Text = "<<";
            this.btnRemoveBlock.UseVisualStyleBackColor = true;
            // 
            // lblTimeControl
            // 
            this.lblTimeControl.AutoSize = true;
            this.lblTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeControl.Location = new System.Drawing.Point(277, 343);
            this.lblTimeControl.Name = "lblTimeControl";
            this.lblTimeControl.Size = new System.Drawing.Size(100, 17);
            this.lblTimeControl.TabIndex = 8;
            this.lblTimeControl.Text = "Time Control";
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
            this.checkedListBox1.Location = new System.Drawing.Point(42, 388);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 109);
            this.checkedListBox1.TabIndex = 9;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(87, 372);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 10;
            this.lblDays.Text = "Days";
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(198, 388);
            this.timeStart.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(120, 20);
            this.timeStart.TabIndex = 11;
            this.timeStart.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(214, 372);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(61, 13);
            this.lblTime1.TabIndex = 12;
            this.lblTime1.Text = "StartTime";
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(334, 388);
            this.timeEnd.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(120, 20);
            this.timeEnd.TabIndex = 13;
            this.timeEnd.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(359, 372);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(60, 13);
            this.lblTimeEnd.TabIndex = 14;
            this.lblTimeEnd.Text = "End Time";
            // 
            // btnTimeControl
            // 
            this.btnTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeControl.Location = new System.Drawing.Point(516, 388);
            this.btnTimeControl.Name = "btnTimeControl";
            this.btnTimeControl.Size = new System.Drawing.Size(112, 23);
            this.btnTimeControl.TabIndex = 15;
            this.btnTimeControl.Text = "Save Day/Time";
            this.btnTimeControl.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(293, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 544);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimeControl);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblTimeControl);
            this.Controls.Add(this.btnRemoveBlock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lblBlockedURLs);
            this.Controls.Add(this.lvBlockedURLs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSuggestedURLs);
            this.Controls.Add(this.lblURLs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblURLs;
        private System.Windows.Forms.ListView lvSuggestedURLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvBlockedURLs;
        private System.Windows.Forms.Label lblBlockedURLs;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnRemoveBlock;
        private System.Windows.Forms.Label lblTimeControl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown timeStart;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.NumericUpDown timeEnd;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Button btnTimeControl;
        private System.Windows.Forms.Button btnExit;
    }
}
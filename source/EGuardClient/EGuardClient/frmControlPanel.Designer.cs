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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lvBlockedURLs = new System.Windows.Forms.ListBox();
            this.lvSuggestedURLs = new System.Windows.Forms.ListBox();
            this.lvSuggestedCats = new System.Windows.Forms.ListBox();
            this.lvBlockedCats = new System.Windows.Forms.ListBox();
            this.btnUnblockCat = new System.Windows.Forms.Button();
            this.btnBlockCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewURL = new System.Windows.Forms.TextBox();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.lblNewURL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblURLs
            // 
            this.lblURLs.AutoSize = true;
            this.lblURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLs.Location = new System.Drawing.Point(265, 168);
            this.lblURLs.Name = "lblURLs";
            this.lblURLs.Size = new System.Drawing.Size(136, 17);
            this.lblURLs.TabIndex = 1;
            this.lblURLs.Text = "URL Management";
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
            this.btnBlock.Location = new System.Drawing.Point(297, 232);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 6;
            this.btnBlock.Text = ">>";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnRemoveBlock
            // 
            this.btnRemoveBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBlock.Location = new System.Drawing.Point(297, 261);
            this.btnRemoveBlock.Name = "btnRemoveBlock";
            this.btnRemoveBlock.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBlock.TabIndex = 7;
            this.btnRemoveBlock.Text = "<<";
            this.btnRemoveBlock.UseVisualStyleBackColor = true;
            this.btnRemoveBlock.Click += new System.EventHandler(this.btnRemoveBlock_Click);
            // 
            // lblTimeControl
            // 
            this.lblTimeControl.AutoSize = true;
            this.lblTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeControl.Location = new System.Drawing.Point(281, 558);
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
            this.checkedListBox1.Location = new System.Drawing.Point(46, 603);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 109);
            this.checkedListBox1.TabIndex = 9;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(91, 587);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 10;
            this.lblDays.Text = "Days";
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(202, 603);
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
            this.lblTime1.Location = new System.Drawing.Point(218, 587);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(61, 13);
            this.lblTime1.TabIndex = 12;
            this.lblTime1.Text = "StartTime";
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(338, 603);
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
            this.lblTimeEnd.Location = new System.Drawing.Point(363, 587);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(60, 13);
            this.lblTimeEnd.TabIndex = 14;
            this.lblTimeEnd.Text = "End Time";
            // 
            // btnTimeControl
            // 
            this.btnTimeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeControl.Location = new System.Drawing.Point(520, 603);
            this.btnTimeControl.Name = "btnTimeControl";
            this.btnTimeControl.Size = new System.Drawing.Size(112, 23);
            this.btnTimeControl.TabIndex = 15;
            this.btnTimeControl.Text = "Save Day/Time";
            this.btnTimeControl.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(297, 724);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvBlockedURLs
            // 
            this.lvBlockedURLs.FormattingEnabled = true;
            this.lvBlockedURLs.Location = new System.Drawing.Point(402, 224);
            this.lvBlockedURLs.Name = "lvBlockedURLs";
            this.lvBlockedURLs.Size = new System.Drawing.Size(244, 95);
            this.lvBlockedURLs.TabIndex = 17;
            // 
            // lvSuggestedURLs
            // 
            this.lvSuggestedURLs.FormattingEnabled = true;
            this.lvSuggestedURLs.Location = new System.Drawing.Point(21, 224);
            this.lvSuggestedURLs.Name = "lvSuggestedURLs";
            this.lvSuggestedURLs.Size = new System.Drawing.Size(244, 95);
            this.lvSuggestedURLs.TabIndex = 18;
            this.lvSuggestedURLs.SelectedIndexChanged += new System.EventHandler(this.lvSuggestedURLs_SelectedIndexChanged);
            // 
            // lvSuggestedCats
            // 
            this.lvSuggestedCats.FormattingEnabled = true;
            this.lvSuggestedCats.Location = new System.Drawing.Point(21, 415);
            this.lvSuggestedCats.Name = "lvSuggestedCats";
            this.lvSuggestedCats.Size = new System.Drawing.Size(244, 95);
            this.lvSuggestedCats.TabIndex = 19;
            // 
            // lvBlockedCats
            // 
            this.lvBlockedCats.FormattingEnabled = true;
            this.lvBlockedCats.Location = new System.Drawing.Point(402, 415);
            this.lvBlockedCats.Name = "lvBlockedCats";
            this.lvBlockedCats.Size = new System.Drawing.Size(244, 95);
            this.lvBlockedCats.TabIndex = 20;
            // 
            // btnUnblockCat
            // 
            this.btnUnblockCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblockCat.Location = new System.Drawing.Point(297, 459);
            this.btnUnblockCat.Name = "btnUnblockCat";
            this.btnUnblockCat.Size = new System.Drawing.Size(75, 23);
            this.btnUnblockCat.TabIndex = 22;
            this.btnUnblockCat.Text = "<<";
            this.btnUnblockCat.UseVisualStyleBackColor = true;
            this.btnUnblockCat.Click += new System.EventHandler(this.btnUnblockCat_Click);
            // 
            // btnBlockCat
            // 
            this.btnBlockCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockCat.Location = new System.Drawing.Point(297, 430);
            this.btnBlockCat.Name = "btnBlockCat";
            this.btnBlockCat.Size = new System.Drawing.Size(75, 23);
            this.btnBlockCat.TabIndex = 21;
            this.btnBlockCat.Text = ">>";
            this.btnBlockCat.UseVisualStyleBackColor = true;
            this.btnBlockCat.Click += new System.EventHandler(this.btnBlockCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Category Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Blocked Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Suggested Blocked Categories";
            // 
            // txtNewURL
            // 
            this.txtNewURL.Location = new System.Drawing.Point(268, 337);
            this.txtNewURL.Name = "txtNewURL";
            this.txtNewURL.Size = new System.Drawing.Size(283, 20);
            this.txtNewURL.TabIndex = 26;
            // 
            // btnAddURL
            // 
            this.btnAddURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddURL.Location = new System.Drawing.Point(560, 335);
            this.btnAddURL.Name = "btnAddURL";
            this.btnAddURL.Size = new System.Drawing.Size(86, 23);
            this.btnAddURL.TabIndex = 27;
            this.btnAddURL.Text = "Add URL";
            this.btnAddURL.UseVisualStyleBackColor = true;
            this.btnAddURL.Click += new System.EventHandler(this.btnAddURL_Click);
            // 
            // lblNewURL
            // 
            this.lblNewURL.AutoSize = true;
            this.lblNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewURL.Location = new System.Drawing.Point(18, 340);
            this.lblNewURL.Name = "lblNewURL";
            this.lblNewURL.Size = new System.Drawing.Size(244, 13);
            this.lblNewURL.TabIndex = 28;
            this.lblNewURL.Text = "Specify new blocked URL (ie.: abc.om)-->";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.test_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CatMGT_Click);
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNewURL);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.txtNewURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnblockCat);
            this.Controls.Add(this.btnBlockCat);
            this.Controls.Add(this.lvBlockedCats);
            this.Controls.Add(this.lvSuggestedCats);
            this.Controls.Add(this.lvSuggestedURLs);
            this.Controls.Add(this.lvBlockedURLs);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblURLs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblURLs;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ListBox lvBlockedURLs;
        private System.Windows.Forms.ListBox lvSuggestedURLs;
        private System.Windows.Forms.ListBox lvSuggestedCats;
        private System.Windows.Forms.ListBox lvBlockedCats;
        private System.Windows.Forms.Button btnUnblockCat;
        private System.Windows.Forms.Button btnBlockCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewURL;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.Label lblNewURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
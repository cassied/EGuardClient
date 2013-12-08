namespace EGuardClient
{
    partial class URL_frmControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URL_frmControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblURLs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBlockedURLs = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnRemoveBlock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvBlockedURLs = new System.Windows.Forms.ListBox();
            this.lvSuggestedURLs = new System.Windows.Forms.ListBox();
            this.txtNewURL = new System.Windows.Forms.TextBox();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.lblNewURL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(297, 380);
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
            // CD_frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 415);
            this.Controls.Add(this.lblNewURL);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.txtNewURL);
            this.Controls.Add(this.lvSuggestedURLs);
            this.Controls.Add(this.lvBlockedURLs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveBlock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lblBlockedURLs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblURLs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CD_frmControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lvBlockedURLs;
        private System.Windows.Forms.ListBox lvSuggestedURLs;
        private System.Windows.Forms.TextBox txtNewURL;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.Label lblNewURL;
    }
}
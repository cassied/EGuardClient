namespace EGuardClient
{
    partial class WORD_frmControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WORD_frmControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvSuggestedWords = new System.Windows.Forms.ListBox();
            this.lvBlockedWords = new System.Windows.Forms.ListBox();
            this.btnRemoveBlock = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lblBlockedURLs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblURLs = new System.Windows.Forms.Label();
            this.lblNewURL = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(232, 377);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(142, 23);
            this.btnMenu.TabIndex = 33;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(43, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvSuggestedWords
            // 
            this.lvSuggestedWords.Enabled = false;
            this.lvSuggestedWords.FormattingEnabled = true;
            this.lvSuggestedWords.Location = new System.Drawing.Point(31, 209);
            this.lvSuggestedWords.Name = "lvSuggestedWords";
            this.lvSuggestedWords.Size = new System.Drawing.Size(211, 95);
            this.lvSuggestedWords.TabIndex = 35;
            // 
            // lvBlockedWords
            // 
            this.lvBlockedWords.FormattingEnabled = true;
            this.lvBlockedWords.Location = new System.Drawing.Point(378, 209);
            this.lvBlockedWords.Name = "lvBlockedWords";
            this.lvBlockedWords.Size = new System.Drawing.Size(195, 95);
            this.lvBlockedWords.TabIndex = 36;
            // 
            // btnRemoveBlock
            // 
            this.btnRemoveBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBlock.Location = new System.Drawing.Point(274, 255);
            this.btnRemoveBlock.Name = "btnRemoveBlock";
            this.btnRemoveBlock.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBlock.TabIndex = 38;
            this.btnRemoveBlock.Text = "<<";
            this.btnRemoveBlock.UseVisualStyleBackColor = true;
            this.btnRemoveBlock.Click += new System.EventHandler(this.btnRemoveBlock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.Location = new System.Drawing.Point(274, 226);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 37;
            this.btnBlock.Text = ">>";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // lblBlockedURLs
            // 
            this.lblBlockedURLs.AutoSize = true;
            this.lblBlockedURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockedURLs.Location = new System.Drawing.Point(413, 189);
            this.lblBlockedURLs.Name = "lblBlockedURLs";
            this.lblBlockedURLs.Size = new System.Drawing.Size(93, 13);
            this.lblBlockedURLs.TabIndex = 41;
            this.lblBlockedURLs.Text = "Blocked Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Suggested Blocked Words";
            // 
            // lblURLs
            // 
            this.lblURLs.AutoSize = true;
            this.lblURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLs.Location = new System.Drawing.Point(245, 161);
            this.lblURLs.Name = "lblURLs";
            this.lblURLs.Size = new System.Drawing.Size(143, 17);
            this.lblURLs.TabIndex = 39;
            this.lblURLs.Text = "Word Management";
            // 
            // lblNewURL
            // 
            this.lblNewURL.AutoSize = true;
            this.lblNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewURL.Location = new System.Drawing.Point(22, 324);
            this.lblNewURL.Name = "lblNewURL";
            this.lblNewURL.Size = new System.Drawing.Size(159, 13);
            this.lblNewURL.TabIndex = 44;
            this.lblNewURL.Text = "Specify new blocked Word";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWord.Location = new System.Drawing.Point(489, 319);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(100, 23);
            this.btnAddWord.TabIndex = 43;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(211, 321);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(272, 20);
            this.txtNewWord.TabIndex = 42;
            // 
            // WORD_frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 519);
            this.Controls.Add(this.lblNewURL);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtNewWord);
            this.Controls.Add(this.lblBlockedURLs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblURLs);
            this.Controls.Add(this.btnRemoveBlock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lvBlockedWords);
            this.Controls.Add(this.lvSuggestedWords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WORD_frmControlPanel";
            this.Text = "WORD_frmControlPanel";
            this.Load += new System.EventHandler(this.WORD_frmControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lvSuggestedWords;
        private System.Windows.Forms.ListBox lvBlockedWords;
        private System.Windows.Forms.Button btnRemoveBlock;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label lblBlockedURLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblURLs;
        private System.Windows.Forms.Label lblNewURL;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.TextBox txtNewWord;
    }
}
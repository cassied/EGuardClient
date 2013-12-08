namespace EGuardClient
{
    partial class CAT_frmControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAT_frmControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvSuggestedCats = new System.Windows.Forms.ListBox();
            this.lvBlockedCats = new System.Windows.Forms.ListBox();
            this.btnUnblockCat = new System.Windows.Forms.Button();
            this.btnBlockCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNewURL = new System.Windows.Forms.Label();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.txtNewCat = new System.Windows.Forms.TextBox();
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
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(300, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvSuggestedCats
            // 
            this.lvSuggestedCats.FormattingEnabled = true;
            this.lvSuggestedCats.Location = new System.Drawing.Point(24, 217);
            this.lvSuggestedCats.Name = "lvSuggestedCats";
            this.lvSuggestedCats.Size = new System.Drawing.Size(244, 95);
            this.lvSuggestedCats.TabIndex = 19;
            // 
            // lvBlockedCats
            // 
            this.lvBlockedCats.FormattingEnabled = true;
            this.lvBlockedCats.Location = new System.Drawing.Point(405, 217);
            this.lvBlockedCats.Name = "lvBlockedCats";
            this.lvBlockedCats.Size = new System.Drawing.Size(244, 95);
            this.lvBlockedCats.TabIndex = 20;
            // 
            // btnUnblockCat
            // 
            this.btnUnblockCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblockCat.Location = new System.Drawing.Point(300, 261);
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
            this.btnBlockCat.Location = new System.Drawing.Point(300, 232);
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
            this.label2.Location = new System.Drawing.Point(256, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Category Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Blocked Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Suggested Blocked Categories";
            // 
            // lblNewURL
            // 
            this.lblNewURL.AutoSize = true;
            this.lblNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewURL.Location = new System.Drawing.Point(45, 326);
            this.lblNewURL.Name = "lblNewURL";
            this.lblNewURL.Size = new System.Drawing.Size(183, 13);
            this.lblNewURL.TabIndex = 31;
            this.lblNewURL.Text = "Specify new blocked Category ";
            // 
            // btnAddURL
            // 
            this.btnAddURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddURL.Location = new System.Drawing.Point(512, 321);
            this.btnAddURL.Name = "btnAddURL";
            this.btnAddURL.Size = new System.Drawing.Size(100, 23);
            this.btnAddURL.TabIndex = 30;
            this.btnAddURL.Text = "Add Category";
            this.btnAddURL.UseVisualStyleBackColor = true;
            this.btnAddURL.Click += new System.EventHandler(this.AddCat_click);
            // 
            // txtNewCat
            // 
            this.txtNewCat.Location = new System.Drawing.Point(234, 323);
            this.txtNewCat.Name = "txtNewCat";
            this.txtNewCat.Size = new System.Drawing.Size(272, 20);
            this.txtNewCat.TabIndex = 29;
            // 
            // CAT_frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 389);
            this.Controls.Add(this.lblNewURL);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.txtNewCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnblockCat);
            this.Controls.Add(this.btnBlockCat);
            this.Controls.Add(this.lvBlockedCats);
            this.Controls.Add(this.lvSuggestedCats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAT_frmControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lvSuggestedCats;
        private System.Windows.Forms.ListBox lvBlockedCats;
        private System.Windows.Forms.Button btnUnblockCat;
        private System.Windows.Forms.Button btnBlockCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNewURL;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.TextBox txtNewCat;
    }
}
namespace EGuardClient
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageURLs = new System.Windows.Forms.Button();
            this.btnManageCATs = new System.Windows.Forms.Button();
            this.btnManageTC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageURLs
            // 
            this.btnManageURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageURLs.Location = new System.Drawing.Point(202, 206);
            this.btnManageURLs.Name = "btnManageURLs";
            this.btnManageURLs.Size = new System.Drawing.Size(204, 23);
            this.btnManageURLs.TabIndex = 3;
            this.btnManageURLs.Text = "Manage URLs";
            this.btnManageURLs.UseVisualStyleBackColor = true;
            this.btnManageURLs.Click += new System.EventHandler(this.btnManageURLs_Click);
            // 
            // btnManageCATs
            // 
            this.btnManageCATs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCATs.Location = new System.Drawing.Point(202, 247);
            this.btnManageCATs.Name = "btnManageCATs";
            this.btnManageCATs.Size = new System.Drawing.Size(204, 23);
            this.btnManageCATs.TabIndex = 4;
            this.btnManageCATs.Text = "Manage Categories";
            this.btnManageCATs.UseVisualStyleBackColor = true;
            this.btnManageCATs.Click += new System.EventHandler(this.btnManageCATs_Click_1);
            // 
            // btnManageTC
            // 
            this.btnManageTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTC.Location = new System.Drawing.Point(202, 326);
            this.btnManageTC.Name = "btnManageTC";
            this.btnManageTC.Size = new System.Drawing.Size(204, 23);
            this.btnManageTC.TabIndex = 5;
            this.btnManageTC.Text = "Configure Time Control";
            this.btnManageTC.UseVisualStyleBackColor = true;
            this.btnManageTC.Click += new System.EventHandler(this.btnManageTC_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(41, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWords
            // 
            this.btnWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWords.Location = new System.Drawing.Point(202, 286);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(204, 23);
            this.btnWords.TabIndex = 18;
            this.btnWords.Text = "Manage Blocked Words";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 463);
            this.Controls.Add(this.btnWords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManageTC);
            this.Controls.Add(this.btnManageCATs);
            this.Controls.Add(this.btnManageURLs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "EGuard Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageURLs;
        private System.Windows.Forms.Button btnManageCATs;
        private System.Windows.Forms.Button btnManageTC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWords;
    }
}
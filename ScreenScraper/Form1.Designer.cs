namespace ScreenScraper
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblSourceDump = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(12, 34);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(33, 17);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL:";
            // 
            // lblSourceDump
            // 
            this.lblSourceDump.AutoSize = true;
            this.lblSourceDump.Location = new System.Drawing.Point(12, 110);
            this.lblSourceDump.Name = "lblSourceDump";
            this.lblSourceDump.Size = new System.Drawing.Size(44, 13);
            this.lblSourceDump.TabIndex = 1;
            this.lblSourceDump.Text = "Source:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(51, 31);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(432, 20);
            this.tbURL.TabIndex = 2;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(171, 68);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(163, 23);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch Url Source";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(171, 130);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse Source Code";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lblSourceDump);
            this.Controls.Add(this.lblUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblSourceDump;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnParse;
    }
}


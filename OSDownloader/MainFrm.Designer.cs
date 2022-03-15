namespace OSDownloader
{
    partial class MainFrm
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
            this.groupBoxOSList = new System.Windows.Forms.GroupBox();
            this.listBoxOSList = new System.Windows.Forms.ListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblBrace = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBoxOSList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOSList
            // 
            this.groupBoxOSList.Controls.Add(this.listBoxOSList);
            this.groupBoxOSList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOSList.Name = "groupBoxOSList";
            this.groupBoxOSList.Size = new System.Drawing.Size(776, 355);
            this.groupBoxOSList.TabIndex = 0;
            this.groupBoxOSList.TabStop = false;
            this.groupBoxOSList.Text = "OS List";
            // 
            // listBoxOSList
            // 
            this.listBoxOSList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOSList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOSList.FormattingEnabled = true;
            this.listBoxOSList.ItemHeight = 20;
            this.listBoxOSList.Location = new System.Drawing.Point(3, 16);
            this.listBoxOSList.Name = "listBoxOSList";
            this.listBoxOSList.Size = new System.Drawing.Size(770, 336);
            this.listBoxOSList.TabIndex = 4;
            this.listBoxOSList.SelectedIndexChanged += new System.EventHandler(this.listBoxOSList_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(713, 373);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 386);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(28, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Info:";
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Location = new System.Drawing.Point(116, 386);
            this.lblReceive.Margin = new System.Windows.Forms.Padding(0);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(0, 13);
            this.lblReceive.TabIndex = 4;
            // 
            // lblBrace
            // 
            this.lblBrace.AutoSize = true;
            this.lblBrace.Location = new System.Drawing.Point(173, 386);
            this.lblBrace.Margin = new System.Windows.Forms.Padding(0);
            this.lblBrace.Name = "lblBrace";
            this.lblBrace.Size = new System.Drawing.Size(0, 13);
            this.lblBrace.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(183, 386);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 6;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBrace);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.groupBoxOSList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::OSDownloader.Properties.Resources.os_downloader_logo;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Operating System Downloader";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.groupBoxOSList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOSList;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox listBoxOSList;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblBrace;
        private System.Windows.Forms.Label lblTotal;
    }
}


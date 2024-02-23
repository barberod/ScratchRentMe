namespace ScratchRentMe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.toastPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Red;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.MinimumSize = new System.Drawing.Size(650, 60);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 60);
            this.headerPanel.TabIndex = 100;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Red;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 390);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.footerPanel.MinimumSize = new System.Drawing.Size(650, 60);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(800, 60);
            this.footerPanel.TabIndex = 101;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.Cyan;
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 90);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarPanel.MaximumSize = new System.Drawing.Size(200, 220);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(200, 220);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 220);
            this.sidebarPanel.TabIndex = 102;
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.accentPanel.Location = new System.Drawing.Point(750, 90);
            this.accentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.accentPanel.MaximumSize = new System.Drawing.Size(50, 220);
            this.accentPanel.MinimumSize = new System.Drawing.Size(50, 220);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(50, 220);
            this.accentPanel.TabIndex = 103;
            // 
            // bodyPanel
            // 
            this.bodyPanel.AutoScroll = true;
            this.bodyPanel.BackColor = System.Drawing.Color.Lime;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(200, 90);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(550, 300);
            this.bodyPanel.TabIndex = 104;
            // 
            // toastPanel
            // 
            this.toastPanel.BackColor = System.Drawing.Color.Yellow;
            this.toastPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toastPanel.Location = new System.Drawing.Point(0, 60);
            this.toastPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toastPanel.MinimumSize = new System.Drawing.Size(650, 30);
            this.toastPanel.Name = "toastPanel";
            this.toastPanel.Size = new System.Drawing.Size(800, 30);
            this.toastPanel.TabIndex = 105;
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.accentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.toastPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 370);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scratch Rent Me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel toastPanel;
    }
}


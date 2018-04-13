namespace DemoXML
{
    partial class frmTestPlat
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openForLINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terraformGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inernetGatewayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.instanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.terraformGenerateToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(431, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openForLINQToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // openForLINQToolStripMenuItem
            // 
            this.openForLINQToolStripMenuItem.Name = "openForLINQToolStripMenuItem";
            this.openForLINQToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openForLINQToolStripMenuItem.Text = "Open for LINQ";
            this.openForLINQToolStripMenuItem.Click += new System.EventHandler(this.openForLINQToolStripMenuItem_Click);
            // 
            // terraformGenerateToolStripMenuItem
            // 
            this.terraformGenerateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vPCToolStripMenuItem,
            this.subnetToolStripMenuItem,
            this.securityGroupToolStripMenuItem,
            this.inernetGatewayToolStripMenuItem,
            this.instanceToolStripMenuItem});
            this.terraformGenerateToolStripMenuItem.Enabled = false;
            this.terraformGenerateToolStripMenuItem.Name = "terraformGenerateToolStripMenuItem";
            this.terraformGenerateToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.terraformGenerateToolStripMenuItem.Text = "Terraform Generate";
            this.terraformGenerateToolStripMenuItem.Click += new System.EventHandler(this.terraformGenerateToolStripMenuItem_Click);
            // 
            // vPCToolStripMenuItem
            // 
            this.vPCToolStripMenuItem.Name = "vPCToolStripMenuItem";
            this.vPCToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.vPCToolStripMenuItem.Text = "VPC";
            this.vPCToolStripMenuItem.Click += new System.EventHandler(this.vPCToolStripMenuItem_Click);
            // 
            // subnetToolStripMenuItem
            // 
            this.subnetToolStripMenuItem.Name = "subnetToolStripMenuItem";
            this.subnetToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.subnetToolStripMenuItem.Text = "Subnet";
            this.subnetToolStripMenuItem.Click += new System.EventHandler(this.subnetToolStripMenuItem_Click);
            // 
            // securityGroupToolStripMenuItem
            // 
            this.securityGroupToolStripMenuItem.Name = "securityGroupToolStripMenuItem";
            this.securityGroupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.securityGroupToolStripMenuItem.Text = "Security Group";
            this.securityGroupToolStripMenuItem.Click += new System.EventHandler(this.securityGroupToolStripMenuItem_Click);
            // 
            // inernetGatewayToolStripMenuItem
            // 
            this.inernetGatewayToolStripMenuItem.Name = "inernetGatewayToolStripMenuItem";
            this.inernetGatewayToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inernetGatewayToolStripMenuItem.Text = "Inernet Gateway";
            this.inernetGatewayToolStripMenuItem.Click += new System.EventHandler(this.inernetGatewayToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 113);
            this.dataGridView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 192);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(431, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // instanceToolStripMenuItem
            // 
            this.instanceToolStripMenuItem.Name = "instanceToolStripMenuItem";
            this.instanceToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.instanceToolStripMenuItem.Text = "Instance";
            this.instanceToolStripMenuItem.Click += new System.EventHandler(this.instanceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 337);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem openForLINQToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem terraformGenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inernetGatewayToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem instanceToolStripMenuItem;
    }
}


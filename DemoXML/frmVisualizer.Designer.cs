namespace DemoXML
{
    partial class frmVisualizer
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
            this.tvwStructure = new System.Windows.Forms.TreeView();
            this.btnReload = new System.Windows.Forms.Button();
            this.prgPropGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwStructure
            // 
            this.tvwStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwStructure.Location = new System.Drawing.Point(3, 41);
            this.tvwStructure.Name = "tvwStructure";
            this.tvwStructure.Size = new System.Drawing.Size(212, 353);
            this.tvwStructure.TabIndex = 0;
            this.tvwStructure.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwStructure_BeforeSelect);
            this.tvwStructure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwStructure_AfterSelect);
            this.tvwStructure.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwStructure_NodeMouseClick);
            this.tvwStructure.Click += new System.EventHandler(this.tvwStructure_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(3, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(212, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Load/ Refresh";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // prgPropGrid
            // 
            this.prgPropGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgPropGrid.Location = new System.Drawing.Point(3, 9);
            this.prgPropGrid.Name = "prgPropGrid";
            this.prgPropGrid.Size = new System.Drawing.Size(433, 385);
            this.prgPropGrid.TabIndex = 2;
            this.prgPropGrid.Click += new System.EventHandler(this.prgPropGrid_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReload);
            this.splitContainer1.Panel1.Controls.Add(this.tvwStructure);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.prgPropGrid);
            this.splitContainer1.Size = new System.Drawing.Size(661, 397);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 3;
            // 
            // frmVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 395);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmVisualizer";
            this.Text = "AWS Service Visualizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwStructure;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PropertyGrid prgPropGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
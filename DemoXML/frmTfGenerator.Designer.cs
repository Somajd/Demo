namespace DemoXML
{
    partial class frmTfGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawFilename = new System.Windows.Forms.Button();
            this.txtDrawFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.txtVariableFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTfGenerate = new System.Windows.Forms.Button();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.btnOpenFldr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrawFilename);
            this.groupBox1.Controls.Add(this.txtDrawFilename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnDrawFilename
            // 
            this.btnDrawFilename.Location = new System.Drawing.Point(181, 33);
            this.btnDrawFilename.Name = "btnDrawFilename";
            this.btnDrawFilename.Size = new System.Drawing.Size(29, 19);
            this.btnDrawFilename.TabIndex = 4;
            this.btnDrawFilename.Text = "...";
            this.btnDrawFilename.UseVisualStyleBackColor = true;
            this.btnDrawFilename.Click += new System.EventHandler(this.btnDrawFilename_Click);
            // 
            // txtDrawFilename
            // 
            this.txtDrawFilename.Location = new System.Drawing.Point(19, 33);
            this.txtDrawFilename.Name = "txtDrawFilename";
            this.txtDrawFilename.Size = new System.Drawing.Size(158, 20);
            this.txtDrawFilename.TabIndex = 3;
            this.txtDrawFilename.Leave += new System.EventHandler(this.txtDrawFilename_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Draw IO Filename";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOutputFolder);
            this.groupBox2.Controls.Add(this.txtVariableFilename);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOutputFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(181, 34);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(29, 19);
            this.btnOutputFolder.TabIndex = 8;
            this.btnOutputFolder.Text = "...";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // txtVariableFilename
            // 
            this.txtVariableFilename.Enabled = false;
            this.txtVariableFilename.Location = new System.Drawing.Point(19, 74);
            this.txtVariableFilename.Name = "txtVariableFilename";
            this.txtVariableFilename.Size = new System.Drawing.Size(191, 20);
            this.txtVariableFilename.TabIndex = 7;
            this.txtVariableFilename.Text = "(optional)";
            this.txtVariableFilename.Leave += new System.EventHandler(this.txtVariableFilename_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variable Filename";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(19, 33);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(158, 20);
            this.txtOutputFolder.TabIndex = 5;
            this.txtOutputFolder.Leave += new System.EventHandler(this.txtOutputFolder_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Folder";
            // 
            // btnTfGenerate
            // 
            this.btnTfGenerate.Location = new System.Drawing.Point(17, 194);
            this.btnTfGenerate.Name = "btnTfGenerate";
            this.btnTfGenerate.Size = new System.Drawing.Size(210, 30);
            this.btnTfGenerate.TabIndex = 2;
            this.btnTfGenerate.Text = "Generate Terraform";
            this.btnTfGenerate.UseVisualStyleBackColor = true;
            this.btnTfGenerate.Click += new System.EventHandler(this.btnTfGenerate_Click);
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtxtOutput.ForeColor = System.Drawing.Color.Yellow;
            this.rtxtOutput.Location = new System.Drawing.Point(238, 18);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(233, 170);
            this.rtxtOutput.TabIndex = 3;
            this.rtxtOutput.Text = "";
            // 
            // btnOpenFldr
            // 
            this.btnOpenFldr.Location = new System.Drawing.Point(393, 198);
            this.btnOpenFldr.Name = "btnOpenFldr";
            this.btnOpenFldr.Size = new System.Drawing.Size(77, 25);
            this.btnOpenFldr.TabIndex = 4;
            this.btnOpenFldr.Text = "Open Folder";
            this.btnOpenFldr.UseVisualStyleBackColor = true;
            this.btnOpenFldr.Click += new System.EventHandler(this.btnOpenFldr_Click);
            // 
            // frmTfGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 232);
            this.Controls.Add(this.btnOpenFldr);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.btnTfGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTfGenerator";
            this.Text = "Terraform Generator";
            this.Load += new System.EventHandler(this.frmTfGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDrawFilename;
        private System.Windows.Forms.TextBox txtDrawFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txtVariableFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTfGenerate;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Button btnOpenFldr;
    }
}
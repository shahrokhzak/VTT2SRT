
namespace VTT2SRT_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.path_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.subFolder_cbx = new System.Windows.Forms.CheckBox();
            this.overwrite_cbx = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse_btn
            // 
            this.Browse_btn.Location = new System.Drawing.Point(12, 206);
            this.Browse_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(82, 22);
            this.Browse_btn.TabIndex = 0;
            this.Browse_btn.Text = "Browse";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(459, 168);
            this.textBox1.TabIndex = 1;
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(387, 206);
            this.convert_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(82, 22);
            this.convert_btn.TabIndex = 2;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.path_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "Path:";
            // 
            // path_lbl
            // 
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(0, 17);
            this.path_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subFolder_cbx
            // 
            this.subFolder_cbx.AutoSize = true;
            this.subFolder_cbx.Checked = true;
            this.subFolder_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subFolder_cbx.Location = new System.Drawing.Point(12, 182);
            this.subFolder_cbx.Name = "subFolder_cbx";
            this.subFolder_cbx.Size = new System.Drawing.Size(126, 19);
            this.subFolder_cbx.TabIndex = 4;
            this.subFolder_cbx.Text = "Include SubFolders";
            this.subFolder_cbx.UseVisualStyleBackColor = true;
            // 
            // overwrite_cbx
            // 
            this.overwrite_cbx.AutoSize = true;
            this.overwrite_cbx.Checked = true;
            this.overwrite_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwrite_cbx.Location = new System.Drawing.Point(364, 182);
            this.overwrite_cbx.Name = "overwrite_cbx";
            this.overwrite_cbx.Size = new System.Drawing.Size(105, 19);
            this.overwrite_cbx.TabIndex = 5;
            this.overwrite_cbx.Text = "OverWrite File?";
            this.overwrite_cbx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 263);
            this.Controls.Add(this.overwrite_cbx);
            this.Controls.Add(this.subFolder_cbx);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Browse_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel path_lbl;
        private System.Windows.Forms.CheckBox subFolder_cbx;
        private System.Windows.Forms.CheckBox overwrite_cbx;
    }
}


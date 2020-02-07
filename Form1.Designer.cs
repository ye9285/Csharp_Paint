namespace WindowsFormsApp1
{
    partial class Form_Paint
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Paint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Black = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Red = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Yellow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Green = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Eraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_8pt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_18pt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_28pt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_allClear = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Black,
            this.toolStripButton_Red,
            this.toolStripButton_Yellow,
            this.toolStripButton_Green,
            this.toolStripButton_Eraser,
            this.toolStripSeparator1,
            this.toolStripButton_8pt,
            this.toolStripButton_18pt,
            this.toolStripButton_28pt,
            this.toolStripSeparator2,
            this.toolStripButton_allClear});
            this.toolStrip1.Location = new System.Drawing.Point(1838, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(66, 1042);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton_Black
            // 
            this.toolStripButton_Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Black.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStripButton_Black.ForeColor = System.Drawing.Color.Black;
            //this.toolStripButton_Black.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Black.Image")));
            this.toolStripButton_Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Black.Name = "toolStripButton_Black";
            this.toolStripButton_Black.Size = new System.Drawing.Size(63, 40);
            this.toolStripButton_Black.Text = "●";
            this.toolStripButton_Black.ToolTipText = "Black";
            this.toolStripButton_Black.Click += new System.EventHandler(this.toolStripButton_Black_Click);
            // 
            // toolStripButton_Red
            // 
            this.toolStripButton_Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Red.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStripButton_Red.ForeColor = System.Drawing.Color.Red;
            //this.toolStripButton_Red.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Red.Image")));
            this.toolStripButton_Red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Red.Name = "toolStripButton_Red";
            this.toolStripButton_Red.Size = new System.Drawing.Size(63, 40);
            this.toolStripButton_Red.Text = "●";
            this.toolStripButton_Red.ToolTipText = "Red";
            this.toolStripButton_Red.Click += new System.EventHandler(this.toolStripButton_Red_Click);
            // 
            // toolStripButton_Yellow
            // 
            this.toolStripButton_Yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Yellow.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStripButton_Yellow.ForeColor = System.Drawing.Color.Yellow;
            //this.toolStripButton_Yellow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Yellow.Image")));
            this.toolStripButton_Yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Yellow.Name = "toolStripButton_Yellow";
            this.toolStripButton_Yellow.Size = new System.Drawing.Size(63, 40);
            this.toolStripButton_Yellow.Text = "●";
            this.toolStripButton_Yellow.ToolTipText = "Yellow";
            this.toolStripButton_Yellow.Click += new System.EventHandler(this.toolStripButton_Yellow_Click);
            // 
            // toolStripButton_Green
            // 
            this.toolStripButton_Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Green.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStripButton_Green.ForeColor = System.Drawing.Color.Lime;
            //this.toolStripButton_Green.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Green.Image")));
            this.toolStripButton_Green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Green.Name = "toolStripButton_Green";
            this.toolStripButton_Green.Size = new System.Drawing.Size(63, 40);
            this.toolStripButton_Green.Text = "●";
            this.toolStripButton_Green.ToolTipText = "Green";
            this.toolStripButton_Green.Click += new System.EventHandler(this.toolStripButton_Green_Click);
            // 
            // toolStripButton_Eraser
            // 
            this.toolStripButton_Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_Eraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Eraser.Image")));
            this.toolStripButton_Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Eraser.Name = "toolStripButton_Eraser";
            this.toolStripButton_Eraser.Size = new System.Drawing.Size(63, 20);
            this.toolStripButton_Eraser.Text = "Eraser";
            this.toolStripButton_Eraser.Visible = false;
            this.toolStripButton_Eraser.Click += new System.EventHandler(this.toolStripButton_Eraser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(63, 6);
            // 
            // toolStripButton_8pt
            // 
            this.toolStripButton_8pt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_8pt.Font = new System.Drawing.Font("メイリオ", 8F);
            //this.toolStripButton_8pt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_8pt.Image")));
            this.toolStripButton_8pt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_8pt.Name = "toolStripButton_8pt";
            this.toolStripButton_8pt.Size = new System.Drawing.Size(63, 21);
            this.toolStripButton_8pt.Text = "●";
            this.toolStripButton_8pt.ToolTipText = "Small";
            this.toolStripButton_8pt.Click += new System.EventHandler(this.toolStripButton_8pt_Click);
            // 
            // toolStripButton_18pt
            // 
            this.toolStripButton_18pt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_18pt.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            //this.toolStripButton_18pt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_18pt.Image")));
            this.toolStripButton_18pt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_18pt.Name = "toolStripButton_18pt";
            this.toolStripButton_18pt.Size = new System.Drawing.Size(63, 40);
            this.toolStripButton_18pt.Text = "●";
            this.toolStripButton_18pt.ToolTipText = "Medium";
            this.toolStripButton_18pt.Click += new System.EventHandler(this.toolStripButton_18pt_Click);
            // 
            // toolStripButton_28pt
            // 
            this.toolStripButton_28pt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_28pt.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            //this.toolStripButton_28pt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_28pt.Image")));
            this.toolStripButton_28pt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_28pt.Name = "toolStripButton_28pt";
            this.toolStripButton_28pt.Size = new System.Drawing.Size(63, 59);
            this.toolStripButton_28pt.Text = "●";
            this.toolStripButton_28pt.ToolTipText = "Large";
            this.toolStripButton_28pt.Click += new System.EventHandler(this.toolStripButton_28pt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(63, 6);
            // 
            // toolStripButton_allClear
            // 
            this.toolStripButton_allClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_allClear.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            //this.toolStripButton_allClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_allClear.Image")));
            this.toolStripButton_allClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_allClear.Name = "toolStripButton_allClear";
            this.toolStripButton_allClear.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton_allClear.Text = "全消去";
            this.toolStripButton_allClear.ToolTipText = "All Clear";
            this.toolStripButton_allClear.Click += new System.EventHandler(this.toolStripButton_allClear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItem_Setting
            // 
            this.ToolStripMenuItem_Setting.Name = "ToolStripMenuItem_Setting";
            this.ToolStripMenuItem_Setting.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Setting.Text = "設定";
            this.ToolStripMenuItem_Setting.Click += new System.EventHandler(this.ToolStripMenuItem_Setting_Click);
            // 
            // Form_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Black;
        private System.Windows.Forms.ToolStripButton toolStripButton_Red;
        private System.Windows.Forms.ToolStripButton toolStripButton_Yellow;
        private System.Windows.Forms.ToolStripButton toolStripButton_Green;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_18pt;
        private System.Windows.Forms.ToolStripButton toolStripButton_28pt;
        private System.Windows.Forms.ToolStripButton toolStripButton_8pt;
        private System.Windows.Forms.ToolStripButton toolStripButton_Eraser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting;
        private System.Windows.Forms.ToolStripButton toolStripButton_allClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


namespace WindowsFormsApp1
{
    partial class Form_Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_FormSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Erase = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.setting_save_btn = new System.Windows.Forms.Button();
            this.setting_cancel_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_toolbar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Erase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "画面のサイズ";
            // 
            // cmb_FormSize
            // 
            this.cmb_FormSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FormSize.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_FormSize.FormattingEnabled = true;
            this.cmb_FormSize.Items.AddRange(new object[] {
            "1024×768 (XGA)",
            "1280×720 (HD 720)",
            "1920×1080 (Full HD)",
            "1920×1200 (WUXGA)"});
            this.cmb_FormSize.Location = new System.Drawing.Point(170, 44);
            this.cmb_FormSize.Name = "cmb_FormSize";
            this.cmb_FormSize.Size = new System.Drawing.Size(184, 24);
            this.cmb_FormSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "線が消えるまでの時間";
            // 
            // num_Erase
            // 
            this.num_Erase.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_Erase.Location = new System.Drawing.Point(198, 88);
            this.num_Erase.Name = "num_Erase";
            this.num_Erase.Size = new System.Drawing.Size(50, 23);
            this.num_Erase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(254, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒";
            // 
            // setting_save_btn
            // 
            this.setting_save_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.setting_save_btn.Location = new System.Drawing.Point(56, 236);
            this.setting_save_btn.Name = "setting_save_btn";
            this.setting_save_btn.Size = new System.Drawing.Size(98, 31);
            this.setting_save_btn.TabIndex = 5;
            this.setting_save_btn.Text = "保存";
            this.setting_save_btn.UseVisualStyleBackColor = true;
            this.setting_save_btn.Click += new System.EventHandler(this.Setting_save_btn_Click);
            // 
            // setting_cancel_btn
            // 
            this.setting_cancel_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.setting_cancel_btn.Location = new System.Drawing.Point(250, 236);
            this.setting_cancel_btn.Name = "setting_cancel_btn";
            this.setting_cancel_btn.Size = new System.Drawing.Size(97, 31);
            this.setting_cancel_btn.TabIndex = 6;
            this.setting_cancel_btn.Text = "キャンセル";
            this.setting_cancel_btn.UseVisualStyleBackColor = true;
            this.setting_cancel_btn.Click += new System.EventHandler(this.Setting_cancel_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(277, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "（※0で無効）";
            // 
            // checkBox_toolbar
            // 
            this.checkBox_toolbar.AutoSize = true;
            this.checkBox_toolbar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_toolbar.Location = new System.Drawing.Point(46, 129);
            this.checkBox_toolbar.Name = "checkBox_toolbar";
            this.checkBox_toolbar.Size = new System.Drawing.Size(162, 20);
            this.checkBox_toolbar.TabIndex = 8;
            this.checkBox_toolbar.Text = "ツールバーを表示する";
            this.checkBox_toolbar.UseVisualStyleBackColor = true;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 318);
            this.Controls.Add(this.checkBox_toolbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setting_cancel_btn);
            this.Controls.Add(this.setting_save_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_Erase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_FormSize);
            this.Controls.Add(this.label1);
            this.Name = "Form_Setting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Erase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_FormSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Erase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setting_save_btn;
        private System.Windows.Forms.Button setting_cancel_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_toolbar;
    }
}
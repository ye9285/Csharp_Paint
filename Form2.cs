using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Setting : System.Windows.Forms.Form
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            if((FormSize.width==1024)&&(FormSize.height==768))
            {
                cmb_FormSize.SelectedIndex = 0;
            }
            else if((FormSize.width == 1280)&&(FormSize.height == 720))
            {
                cmb_FormSize.SelectedIndex = 1;
            }
            else if ((FormSize.width == 1920) && (FormSize.height == 1080))
            {
                cmb_FormSize.SelectedIndex = 2;
            }
            else if ((FormSize.width == 1920) && (FormSize.height == 1200))
            {
                cmb_FormSize.SelectedIndex = 3;
            }

            num_Erase.Value = (decimal)data.waittime/1000;

            checkBox_toolbar.Checked = data.toolbar_flg;
        }

        private void Setting_save_btn_Click(object sender, EventArgs e)
        {
            switch (cmb_FormSize.SelectedIndex)
            {
                case 0:
                    FormSize.width = 1024;
                    FormSize.height = 768;
                    
                    break;

                case 1:
                    FormSize.width = 1280;
                    FormSize.height = 720;

                    break;

                case 2:
                    FormSize.width = 1920;
                    FormSize.height = 1080;

                    break;

                case 3:
                    FormSize.width = 1920;
                    FormSize.height = 1200;

                    break;
            }

            data.waittime = (int)num_Erase.Value;

            data.toolbar_flg = checkBox_toolbar.Checked;

            this.Close();

        }

        private void Setting_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

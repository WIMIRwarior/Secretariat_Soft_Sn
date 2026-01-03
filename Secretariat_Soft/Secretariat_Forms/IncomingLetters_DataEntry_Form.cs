using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft.Secretariat_Forms
{
    public partial class IncomingLetters_DataEntry_Form : Form
    {
        public IncomingLetters_DataEntry_Form()
        {
            InitializeComponent();
        }

        private void IncomingLetters_DataEntry_Form_Load(object sender, EventArgs e)
        {
            enable_add_edit_del_buttons();
        }

        void enable_add_edit_del_buttons()
        {
            this.Main_groupBox.Enabled = false;

            this.Cancel_Button.Enabled = false;
            this.Save_Button.Enabled = false;

            this.AddNew_Button.Enabled = true;
            this.Edit_Button.Enabled = true;
            this.Delete_Button.Enabled = true;
        }

        void disable_add_edit_del_buttons()
        {
            this.Main_groupBox.Enabled = true;

            this.Cancel_Button.Enabled = true;
            this.Save_Button.Enabled = true;

            this.AddNew_Button.Enabled = false;
            this.Edit_Button.Enabled = false;
            this.Delete_Button.Enabled = false;
        }

        void set_system_info()
        {
            this.SysDate_Label.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.SysTime_Label.Text = DateTime.Now.ToString("HH:mm:ss");
            //------------------------------------------------------------
            this.UserName_Label.Text = Secretariat_Soft.Properties.Settings.Default.User_Name;
            this.UserID_Label.Text = Secretariat_Soft.Properties.Settings.Default.User_ID.ToString();

        }

        private void AddNew_Button_Click(object sender, EventArgs e)
        {
            disable_add_edit_del_buttons();
            set_system_info();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            disable_add_edit_del_buttons();
            set_system_info();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            disable_add_edit_del_buttons();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            enable_add_edit_del_buttons();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            enable_add_edit_del_buttons();
        }

        private void label10_Click(object sender, EventArgs e)
        { }

        private void textBox8_TextChanged(object sender, EventArgs e)
        { }
    }
}

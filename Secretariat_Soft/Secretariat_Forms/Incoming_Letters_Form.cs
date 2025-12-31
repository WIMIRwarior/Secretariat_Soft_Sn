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
    public partial class Incoming_Letters_Form : Form
    {
        public Incoming_Letters_Form()
        {
            InitializeComponent();
        }

        private void Incoming_Letters_Form_Load(object sender, EventArgs e)
        {
            try
            {
                this.incoming_LettersTableAdapter1.Fill(this.letters1.Incoming_Letters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            update_position_text();
        }


        void update_position_text()
        {
            int position;
            position = Incoming_Letters_bindingSource.Position;
            position += 1;
            this.SelectedRowPosition_TextBox.Text = position.ToString();
            RecordsTotalNumber_TextBox.Text = "of "+Incoming_Letters_bindingSource.Count.ToString();
        }

        private void First_Button_Click(object sender, EventArgs e)
        {
            this.Incoming_Letters_bindingSource.MoveFirst();

            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            this.Incoming_Letters_bindingSource.MovePrevious();
            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            this.Incoming_Letters_bindingSource.MoveNext();
            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void Last_Button_Click(object sender, EventArgs e)
        {
            this.Incoming_Letters_bindingSource.MoveLast();
            //-------------------------
            update_position_text();
            //-------------------------
        }
    }
}

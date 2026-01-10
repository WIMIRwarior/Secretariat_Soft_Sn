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

        private int selectedID;


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
            RecordsTotalNumber_TextBox.Text = "of " + Incoming_Letters_bindingSource.Count.ToString();
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

        private void Search_Button_Click(object sender, EventArgs e)
        {
            this.Search_panel1.Visible = !(this.Search_panel1.Visible);
            this.Search_panel2.Visible = !(this.Search_panel2.Visible);
        }

        private void Search_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchID_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int searchID = 0;
                if (SearchID_textBox.Text.Length > 0)
                {
                    searchID = Int32.Parse(SearchID_textBox.Text);
                }
                this.incoming_LettersTableAdapter1.FillBy_ID(this.letters1.Incoming_Letters, searchID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void Search_Subject_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string SubjectPattern = "";
                if (Search_Subject_TextBox.Text.Length > 0)
                {
                    SubjectPattern = Search_Subject_TextBox.Text;
                }

                this.incoming_LettersTableAdapter1.FillBy_Subject(letters1.Incoming_Letters, SubjectPattern);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void Search_RegDate_button_Click(object sender, EventArgs e)
        {
            string SearchRegDateFrom = "";
            string SearchRegDateTo = "";
            if (SearchDateFrom_dateTimePicker.Value.ToString("yyyy-MM-dd").Length > 0)
            {
                SearchRegDateFrom = SearchDateFrom_dateTimePicker.Value.ToString("yyyy-MM-dd");
            }
            if (SearchDateTo_dateTimePicker.Value.ToString("yyyy-MM-dd").Length > 0)
            {
                SearchRegDateTo = SearchDateTo_dateTimePicker.Value.ToString("yyyy-MM-dd");
            }

            try
            {
                this.incoming_LettersTableAdapter1.FillBy_RegDate(letters1.Incoming_Letters, SearchRegDateFrom, SearchRegDateTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            //-------------------------
            update_position_text();
            //-------------------------
        }

        private void AddEditDoc_Button_Click(object sender, EventArgs e)
        {
            Secretariat_Forms.IncomingLetters_DataEntry_Form IL_DataEntry_Form;
            int Current_ID = -1;
            Current_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value);
            if (Current_ID != -1)
            {
                IL_DataEntry_Form = new IncomingLetters_DataEntry_Form(Current_ID);
            }
            else
            {
                IL_DataEntry_Form = new IncomingLetters_DataEntry_Form();
            }

            IL_DataEntry_Form.ShowDialog();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            this.incoming_LettersTableAdapter1.Fill(letters1.Incoming_Letters);
            update_position_text();
        }

        private void Incoming_Letters_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

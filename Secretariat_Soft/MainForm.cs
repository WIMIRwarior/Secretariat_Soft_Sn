using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource cancellationToken;



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load date to calendar.
            LoadDateToCalendar();
            //----------------------

            //Start the digital clock
            StartClockAsync();
            
            //-------------------------------------------------------

        }


        private async Task StartClockAsync()
        {
            cancellationToken = new CancellationTokenSource();
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

            try
            {
                while (await timer.WaitForNextTickAsync(cancellationToken.Token))
                {
                    var time = DateTime.Now.ToString("HH:mm");
                    UpdateClockOnUI(time);
                }
            }
            catch (OperationCanceledException)
            {
                //Timer stoped
            }
        }

        private void UpdateClockOnUI(string time)
        {
            if (time != null)
            {
                Digital_Clock_Label.Text = time;
            }
        }


        private void LoadDateToCalendar()
        {
            // Load date to calendar.
            this.Year_Num_Label.Text = DateTime.Now.ToString("yyyy");
            this.Month_Name_Label.Text = DateTime.Now.ToString("MMMM", CultureInfo.CurrentCulture);
            this.Day_Num_Label.Text = DateTime.Now.ToString("dd");
            this.Day_Name_Label.Text = DateTime.Now.ToString("dddd", CultureInfo.CurrentCulture);
            //----------------------------------------------------------
        }


        private void Close_Button_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
            this.Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}

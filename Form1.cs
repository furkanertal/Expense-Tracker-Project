using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeHazırlık1
{
    public partial class FormLoading : Form
    {

        private Timer timer;

        public FormLoading()
        {
            InitializeComponent();
            InitializeProgressBar(); // Call initialization method
        }

        private void InitializeProgressBar()
        {
            // Set ProgressBar properties
            ProgressBarLoading.Minimum = 0;
            ProgressBarLoading.Maximum = 100;
            ProgressBarLoading.Value = 0;

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 100; // Interval in milliseconds (100ms)
            timer.Tick += Timer_Tick; // Attach the Tick event handler
            timer.Start(); // Start the Timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gradually increase ProgressBar value
            if (ProgressBarLoading.Value < ProgressBarLoading.Maximum)
            {
                ProgressBarLoading.Value += 5
                    ; // Increment value by 10
            }
            else
            {
                timer.Stop(); // Stop the Timer when progress is complete

                FormLogin form2 = new FormLogin(); // Show Form2 and close the current loading form
                form2.Show(); // Show Form2
                this.Hide();// Hide the loading form
            }
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
        }



    }
}

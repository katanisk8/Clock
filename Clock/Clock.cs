using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        Label SecondsLabel = new Label();
        Label MinutesLabel = new Label();
        Label HoursLabel = new Label();

        public Clock()
        {
            InitializeComponent();
            SetHours();
            SetMinutes();
            SetSeconds();
            
            Text = DateTime.Now.ToString();

            ClockTimer.Start();
        }

        private void SetHours()
        {
            int x = 5;

            for (int i = 0; i <= 23; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(5, x);
                label.Font = new Font("Arial", 10);
                label.Text = i.ToString();

                Controls.Add(label);

                x += 36;
            }

            HoursLabel.AutoSize = true;
            HoursLabel.Location = new Point(35, DateTime.Now.Hour * 36 + 5);
            HoursLabel.Text = "------------------------------";

            Controls.Add(HoursLabel);
        }

        private void SetMinutes()
        {
            int x = 8;

            for (int i = 0; i <= 59; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(140, x);
                label.Font = new Font("Arial", 8);
                label.Text = i.ToString();

                Controls.Add(label);

                x += 14;
            }

            MinutesLabel.AutoSize = true;
            MinutesLabel.Location = new Point(160, DateTime.Now.Minute * 14 + 8);
            MinutesLabel.Text = "--------------------------";

            Controls.Add(MinutesLabel);
        }

        private void SetSeconds()
        {
            int x = 8;

            for (int i = 0; i <= 59; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(250, x);
                label.Font = new Font("Arial", 8);
                label.Text = i.ToString();

                Controls.Add(label);

                x += 14;
            }

            SecondsLabel.AutoSize = true;
            SecondsLabel.Location = new Point(270, DateTime.Now.Second * 14 + 8);
            SecondsLabel.Text = "------------------------------";

            Controls.Add(SecondsLabel);
        }

        

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
            
            SecondsLabel.Location = new Point(270, DateTime.Now.Second * 14 + 8);
            MinutesLabel.Location = new Point(160, DateTime.Now.Minute * 14 + 8);
            HoursLabel.Location = new Point(35, DateTime.Now.Hour * 36 + 5);
        }
    }
}

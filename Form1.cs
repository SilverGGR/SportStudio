using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changePanel(Panel changingPanel, Button changingButton, Point originalLocation, string changingText)
        {
            float bigScaleFactor = 2.1f;
            float smallScaleFactor = 0.4762f;
            SizeF bigScaleRatio = new SizeF(bigScaleFactor, bigScaleFactor);
            SizeF smallScaleRatio = new SizeF(smallScaleFactor, smallScaleFactor);

            if (changingButton.Width == 494)
            {
                changingPanel.Scale(bigScaleRatio);
                changingPanel.Location = new Point(8, 90);
                changingButton.Size = new Size(40, 30);
                changingButton.Text = "<-";
                changingPanel.BringToFront();
            }
            else
            {
                changingPanel.Scale(smallScaleRatio);
                changingPanel.Location = originalLocation;
                changingButton.Size = new Size(494, 244);
                changingButton.Text = changingText;
            }
        }

        private void buttonMuki_Click(object sender, EventArgs e)
        {
            changePanel(panelMuki, buttonMuki, new Point(26, 93), "Mukibude");
        }

        private void buttonSauna_Click(object sender, EventArgs e)
        {
            changePanel(panelSauna, buttonSauna, new Point(543, 93), "Sauna");
        }

        private void buttonCardio_Click(object sender, EventArgs e)
        {
            changePanel(panelCardio, buttonCardio, new Point(26, 352), "Cardio");
        }

        private void buttonWasser_Click(object sender, EventArgs e)
        {
            changePanel(panelWasser, buttonWasser, new Point(543, 352), "Wasser");
        }
    }
}
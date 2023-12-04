namespace SportStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMuki_Click(object sender, EventArgs e)
        {
            float bigScaleFactor = 2.0f;
            float smallScaleFactor = 0.5f;
            SizeF bigScaleRatio = new SizeF(bigScaleFactor, bigScaleFactor);
            SizeF smallScaleRatio = new SizeF(smallScaleFactor, smallScaleFactor);

            Point originalLocation = panelMuki.Location;
            if (buttonMuki.Width == 494)
            {
                panelMuki.Scale(bigScaleRatio);
                panelMuki.Location = originalLocation;
                buttonMuki.Size = new Size(40, 30);
                buttonMuki.Text = "<-";
                panelMuki.BringToFront();
            }
            else
            {
                panelMuki.Scale(smallScaleRatio);
                panelMuki.Location = originalLocation;
                buttonMuki.Size = new Size(494, 244);
                buttonMuki.Text = "Mukibude";
            }
        }

        private void buttonSauna_Click(object sender, EventArgs e)
        {

        }
    }
}
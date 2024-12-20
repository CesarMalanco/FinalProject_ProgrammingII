namespace WinFormsFinalProject
{
    public partial class FormLoadingScreen : Form
    {
        public FormLoadingScreen()
        {
            InitializeComponent();
        }

        private void FormLoadingScreen_Load(object sender, EventArgs e)
        {

        }
        // This function allows progress bar to load on screen
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarLoadingScreen.Value = progressBarLoadingScreen.Value + 1; // Value of loading percentage
            labelPercentage.Text = progressBarLoadingScreen.Value.ToString() + " %"; // Percentage on screen

            if (progressBarLoadingScreen.Value > 99) // Stops at 100 %
            {
                timer1.Enabled = false; // Stops timer
                FormCover cover = new FormCover(); // Creates instance for the cover
                this.Hide(); // Hide loading screen
                cover.ShowDialog(); // Show cover
                this.Close(); // Close loading screen
            }
        }

        private void labelPercentage_Click(object sender, EventArgs e)
        {

        }
    }
}

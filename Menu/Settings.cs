namespace OscorpGames
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            trackBarVolume.Value = (int)Properties.Settings.Default.Volume;
            UpdateText();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = (uint)trackBarVolume.Value;
            Properties.Settings.Default.Save();
            Close();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void UpdateText()
        {
            labelVolume.Text = $"Volume: {trackBarVolume.Value}";
        }
    }
}

using System.Runtime.InteropServices;

namespace OscorpGames
{
    public partial class Settings : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public Settings()
        {
            InitializeComponent();
            trackBarVolume.Value = (int)Properties.Settings.Default.Volume;
            UpdateVolume();
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
            UpdateVolume();
            UpdateText();
        }

        private void UpdateText()
        {
            labelVolume.Text = $"Volume: {trackBarVolume.Value}";
        }

        private void UpdateVolume()
        {
            // Calculate the volume that's being set
            int newVolume = ((ushort.MaxValue / trackBarVolume.Maximum) * trackBarVolume.Value);
            // Set the same volume for both the left and the right channels
            uint newVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, newVolumeAllChannels);
        }
    }
}

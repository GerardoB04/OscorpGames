namespace OscorpGames
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarVolume = new TrackBar();
            labelVolume = new Label();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(12, 37);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(776, 69);
            trackBarVolume.SmallChange = 5;
            trackBarVolume.TabIndex = 0;
            trackBarVolume.Value = 100;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(12, 9);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(76, 25);
            labelVolume.TabIndex = 1;
            labelVolume.Text = "Volume:\r\n";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(676, 404);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save & Close";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(labelVolume);
            Controls.Add(trackBarVolume);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarVolume;
        private Label labelVolume;
        private Button buttonSave;
    }
}
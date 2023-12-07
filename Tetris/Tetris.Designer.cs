namespace OscorpGames {
    partial class Tetris {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Tetris ) );
            ScoreLbl = new Label();
            LevelLbl = new Label();
            LinesLbl = new Label();
            BoardUI = new Panel();
            GameLoop = new System.Windows.Forms.Timer( components );
            Hold = new PictureBox();
            Next1 = new PictureBox();
            Next2 = new PictureBox();
            Next3 = new PictureBox();
            ARD = new TextBox();
            ARS = new TextBox();
            ( (System.ComponentModel.ISupportInitialize) Hold ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) Next1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) Next2 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) Next3 ).BeginInit();
            SuspendLayout();
            // 
            // ScoreLbl
            // 
            ScoreLbl.BackColor = Color.Transparent;
            ScoreLbl.Font = new Font( "Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point );
            ScoreLbl.ForeColor = Color.White;
            ScoreLbl.Location = new Point( 260, 313 );
            ScoreLbl.Name = "ScoreLbl";
            ScoreLbl.Size = new Size( 140, 46 );
            ScoreLbl.TabIndex = 0;
            ScoreLbl.Text = "0";
            ScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LevelLbl
            // 
            LevelLbl.BackColor = Color.Transparent;
            LevelLbl.Font = new Font( "Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point );
            LevelLbl.ForeColor = Color.White;
            LevelLbl.Location = new Point( 260, 436 );
            LevelLbl.Name = "LevelLbl";
            LevelLbl.Size = new Size( 140, 46 );
            LevelLbl.TabIndex = 1;
            LevelLbl.Text = "0";
            LevelLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinesLbl
            // 
            LinesLbl.BackColor = Color.Transparent;
            LinesLbl.Font = new Font( "Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point );
            LinesLbl.ForeColor = Color.White;
            LinesLbl.Location = new Point( 260, 562 );
            LinesLbl.Name = "LinesLbl";
            LinesLbl.Size = new Size( 140, 46 );
            LinesLbl.TabIndex = 2;
            LinesLbl.Text = "0";
            LinesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoardUI
            // 
            BoardUI.BackColor = Color.Transparent;
            BoardUI.Location = new Point( 501, 39 );
            BoardUI.Name = "BoardUI";
            BoardUI.Size = new Size( 300, 600 );
            BoardUI.TabIndex = 3;
            // 
            // GameLoop
            // 
            GameLoop.Enabled = true;
            GameLoop.Interval = 15;
            GameLoop.Tick +=  GameLoop_Tick ;
            // 
            // Hold
            // 
            Hold.BackColor = Color.Transparent;
            Hold.BackgroundImageLayout = ImageLayout.Center;
            Hold.Location = new Point( 232, 101 );
            Hold.Name = "Hold";
            Hold.Size = new Size( 194, 93 );
            Hold.SizeMode = PictureBoxSizeMode.CenterImage;
            Hold.TabIndex = 4;
            Hold.TabStop = false;
            // 
            // Next1
            // 
            Next1.BackColor = Color.Transparent;
            Next1.BackgroundImageLayout = ImageLayout.Center;
            Next1.Location = new Point( 866, 123 );
            Next1.Name = "Next1";
            Next1.Size = new Size( 194, 93 );
            Next1.SizeMode = PictureBoxSizeMode.CenterImage;
            Next1.TabIndex = 5;
            Next1.TabStop = false;
            // 
            // Next2
            // 
            Next2.BackColor = Color.Transparent;
            Next2.BackgroundImageLayout = ImageLayout.Center;
            Next2.Location = new Point( 866, 243 );
            Next2.Name = "Next2";
            Next2.Size = new Size( 194, 93 );
            Next2.SizeMode = PictureBoxSizeMode.CenterImage;
            Next2.TabIndex = 6;
            Next2.TabStop = false;
            // 
            // Next3
            // 
            Next3.BackColor = Color.Transparent;
            Next3.BackgroundImageLayout = ImageLayout.Center;
            Next3.Location = new Point( 866, 363 );
            Next3.Name = "Next3";
            Next3.Size = new Size( 194, 93 );
            Next3.SizeMode = PictureBoxSizeMode.CenterImage;
            Next3.TabIndex = 7;
            Next3.TabStop = false;
            // 
            // ARD
            // 
            ARD.BackColor = Color.FromArgb(   26,   26,   26 );
            ARD.BorderStyle = BorderStyle.None;
            ARD.Font = new Font( "Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point );
            ARD.ForeColor = SystemColors.InactiveBorder;
            ARD.Location = new Point( 971, 526 );
            ARD.Name = "ARD";
            ARD.Size = new Size( 79, 38 );
            ARD.TabIndex = 8;
            ARD.Text = "150";
            ARD.TextAlign = HorizontalAlignment.Center;
            ARD.TextChanged +=  checkCharacters ;
            ARD.KeyDown +=  TextKeyDown ;
            // 
            // ARS
            // 
            ARS.BackColor = Color.FromArgb(   26,   26,   26 );
            ARS.BorderStyle = BorderStyle.None;
            ARS.Font = new Font( "Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point );
            ARS.ForeColor = SystemColors.InactiveBorder;
            ARS.Location = new Point( 971, 579 );
            ARS.Name = "ARS";
            ARS.Size = new Size( 79, 38 );
            ARS.TabIndex = 9;
            ARS.Text = "50";
            ARS.TextAlign = HorizontalAlignment.Center;
            ARS.TextChanged +=  checkCharacters ;
            ARS.KeyDown +=  TextKeyDown ;
            // 
            // Tetris
            // 
            AutoScaleDimensions = new SizeF( 10F, 25F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image) resources.GetObject( "$this.BackgroundImage" );
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size( 1258, 664 );
            Controls.Add( ARS );
            Controls.Add( ARD );
            Controls.Add( Next3 );
            Controls.Add( Next2 );
            Controls.Add( Next1 );
            Controls.Add( Hold );
            Controls.Add( BoardUI );
            Controls.Add( LinesLbl );
            Controls.Add( LevelLbl );
            Controls.Add( ScoreLbl );
            DoubleBuffered = true;
            Name = "Tetris";
            Text = "Tetris";
            ( (System.ComponentModel.ISupportInitialize) Hold ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) Next1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) Next2 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) Next3 ).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label ScoreLbl;
        private Label LevelLbl;
        private Label LinesLbl;
        private Panel BoardUI;
        private System.Windows.Forms.Timer GameLoop;
        private PictureBox Hold;
        private PictureBox Next1;
        private PictureBox Next2;
        private PictureBox Next3;
        private TextBox ARD;
        private TextBox ARS;
    }
}
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
            SuspendLayout();
            // 
            // ScoreLbl
            // 
            ScoreLbl.BackColor = Color.Transparent;
            ScoreLbl.Font = new Font( "Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point );
            ScoreLbl.ForeColor = Color.White;
            ScoreLbl.Location = new Point( 260, 307 );
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
            LevelLbl.Location = new Point( 260, 430 );
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
            LinesLbl.Location = new Point( 260, 555 );
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
            GameLoop.Tick += GameLoop_Tick;
            // 
            // Tetris
            // 
            AutoScaleDimensions = new SizeF( 10F, 25F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)  resources.GetObject( "$this.BackgroundImage" ) ;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size( 1258, 664 );
            Controls.Add( BoardUI );
            Controls.Add( LinesLbl );
            Controls.Add( LevelLbl );
            Controls.Add( ScoreLbl );
            DoubleBuffered = true;
            Name = "Tetris";
            Text = "Tetris";
            ResumeLayout( false );
        }

        #endregion

        private Label ScoreLbl;
        private Label LevelLbl;
        private Label LinesLbl;
        private Panel BoardUI;
        private System.Windows.Forms.Timer GameLoop;
    }
}
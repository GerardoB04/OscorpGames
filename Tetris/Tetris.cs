
using Tetris;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace OscorpGames {

    public partial class Tetris : Form {

        private TetrisController controller = new TetrisController();

        public Tetris() {

            InitializeComponent();

            controller.BoardUI = BoardUI;

            controller.Start();

        }

        private void GameLoop_Tick( object sender, EventArgs e ) {

            if ( !controller.GameRunning ) return;

            controller.GameLoop();

            ScoreLbl.Text = controller.Score.ToString();
            LevelLbl.Text = controller.Level.ToString();
            LinesLbl.Text = controller.Lines.ToString();

            Next1.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[0]] );
            Next2.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[1]] );
            Next3.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[2]] );

        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData ) {

            if ( keyData == Keys.A )
                controller.MovePiece( -1 );
            else if ( keyData == Keys.D )
                controller.MovePiece( 1 );

            if ( keyData == Keys.Q )
                controller.RotatePiece( false );
            else if ( keyData == Keys.E )
                controller.RotatePiece( true );

            if ( keyData == Keys.S )
                controller.DropPiece();

            return base.ProcessCmdKey( ref msg, keyData );

        }

    }



}

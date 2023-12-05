
using Tetris;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace OscorpGames;

public partial class Tetris : Form {

    private TetrisController controller = new TetrisController();

    public Tetris() {

        InitializeComponent();

        controller.BoardUI = BoardUI;

        ScoreLbl.Text = "0";
        LevelLbl.Text = "0";
        LinesLbl.Text = "0";


        for ( int i = 0; i < controller.Display.GetLength( 0 ); i++ ) {

            for ( int j = 0; j < controller.Display.GetLength( 1 ); j++ ) {

                controller.Display[i, j] = new PictureBox();
                controller.Display[i, j].Size = new Size( 30, 30 );
                controller.Display[i, j].Location = new Point( i * 30, ( j - 2 ) * 30 );
                controller.Display[i, j].Image = null;

                BoardUI.Controls.Add( controller.Display[i, j] );

            }

        }

        controller.Start();

    }

    private void GameLoop_Tick( object sender, EventArgs e ) {

        if ( !controller.GameRunning ) {

            Next1.Image = null;
            Next2.Image = null;
            Next3.Image = null;
            Hold.Image = null;
            return;

        }

        controller.ShowBoard();
        controller.GameLoop();

        ScoreLbl.Text = controller.Score.ToString();
        LevelLbl.Text = controller.Level.ToString();
        LinesLbl.Text = controller.Lines.ToString();

        Next1.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[0]] );
        Next2.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[1]] );
        Next3.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.Pieces[2]] );

        if ( controller.HeldPiece != null )
            Hold.Image = Image.FromFile( controller.BasePath + "Full_" + controller.Paths[controller.HeldPiece.ID] );

    }

    protected override void OnKeyDown( KeyEventArgs e ) {
        base.OnKeyDown( e );

        if ( !controller.GameRunning ) {

            Next1.Image = null;
            Next2.Image = null;
            Next3.Image = null;
            Hold.Image = null;

            if ( e.KeyCode == Keys.Space ) controller.Start();
            return;

        }

        if ( e.KeyCode == Keys.Left )
            controller.MovePiece( -1 );
        else if ( e.KeyCode == Keys.Right )
            controller.MovePiece( 1 );

        if ( e.KeyCode == Keys.Z )
            controller.RotatePiece( false );
        else if ( e.KeyCode == Keys.Up )
            controller.RotatePiece( true );

        if ( e.KeyCode == Keys.Down )
            controller.DropPiece( 1 );

        if ( e.KeyCode == Keys.C )
            controller.HoldPiece();

        if ( e.KeyCode == Keys.Space )
            controller.HardDrop();

    }

}

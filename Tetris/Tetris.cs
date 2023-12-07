
using System.Reflection.PortableExecutable;
using Tetris;
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

        ARD.Enabled = !controller.GameRunning;
        ARS.Enabled = !controller.GameRunning;

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

    protected override void OnKeyUp( KeyEventArgs e ) {
        base.OnKeyUp( e );

        KeyManager.Instance.Remove( e.KeyCode );

        switch ( e.KeyCode ) {

            case Keys.Escape:

                controller.GameRunning = !controller.GameRunning;

                break;

        }

    }

    protected override void OnKeyDown( KeyEventArgs e ) {
        base.OnKeyDown( e );

        KeyManager.Instance.Add( e.KeyCode );

    }

    private void checkCharacters( object sender, EventArgs e ) {

        float.TryParse( ARD.Text, out controller.repeatDelay );
        float.TryParse( ARS.Text, out controller.repeatSpeed );

    }
    private void TextKeyDown( object sender, KeyEventArgs e ) {

        if ( e.KeyCode != Keys.Enter ) return;

        ARD.Enabled = false;
        ARS.Enabled = false;

    }

}

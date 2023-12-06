
using OscorpGames;
using System.Diagnostics;

namespace Tetris;

public class TetrisController {

    public Panel BoardUI;
    public PictureBox[,] Display = new PictureBox[10, 22];

    public string[] Paths = { "I.png", "O.png", "L.png", "J.png", "S.png", "Z.png", "T.png" };
    public string BasePath = " ../../../../../Tetris/Assets/";

    private int[,] _board = new int[10, 22];

    public List<int> Pieces = new List<int>();

    public TetrisPiece HeldPiece;
    public TetrisPiece Piece;
    private bool _pieceActive = false;

    private bool _swapped = false;

    public bool GameRunning = false;

    private Stopwatch timer = new Stopwatch();
    private float _dropRate = 0.5f;

    private Stopwatch repeat = new Stopwatch();
    public float repeatDelay = 170;
    public float repeatSpeed = 50;
    private bool repeatStart = true;
    private bool repeatFirst = true;

    public int Score = 0;
    public int Lines = 0;
    public int Level = 0;
    private bool _tetrisCombo = false;
    private int combo = 0;

    public void Start() {

        Reset();

        timer.Start();

        GameRunning = true;
        Update();

    }

    private void Reset() {

        _board = new int[10, 22];
        Score = 0;
        Lines = 0;
        Level = 0;
        _tetrisCombo = false;
        _dropRate = 0.5f;
        GameRunning = false;
        timer.Stop();

        repeat.Stop();
        repeatStart = true;
        repeatFirst = true;

        _pieceActive = false;
        Pieces = new List<int>();
        HeldPiece = null;

        var temp = new int[] { 0, 1, 2, 3, 4, 5, 6 }.ToList();

        for ( int i = 0; i < 7; i++ ) {

            int num = new Random().Next( temp.Count );
            Pieces.Add( temp[num] );
            temp.RemoveAt( num );

        }

        for ( int i = 0; i < Display.GetLength( 0 ); i++ )
            for ( int j = 0; j < Display.GetLength( 1 ); j++ )
                Display[i, j].Image = null;

    }

    public void HoldPiece() {

        if ( _swapped ) return;

        _swapped = true;
        ClearPiece();

        if ( HeldPiece == null ) {

            HeldPiece = new TetrisPiece( Piece.ID );

            int index = GetRandomPiece();
            Piece = new TetrisPiece( index );
            DrawPiece();

            return;

        }

        var temp = HeldPiece;
        HeldPiece = new TetrisPiece( Piece.ID );
        Piece = temp;

        DrawPiece();

    }

    private void Update() {

        if ( !_pieceActive ) {

            CheckClear();
            CheckLost();

            int index = GetRandomPiece();

            _pieceActive = true;
            Piece = new TetrisPiece( index );

            DrawPiece();

            return;

        }

        if ( timer.Elapsed.Seconds >= _dropRate ) {

            DropPiece();
            timer.Restart();

        }

    }

    public void HardDrop() {

        while ( _pieceActive ) DropPiece( 2 );

    }

    private void DrawGhost() {

        ClearPiece();

        var temp = Piece.GetGhost();
        bool running = true;

        while ( running ) {

            ClearPiece( temp );

            if ( CheckValidMove( 0, 1, temp ) ) temp.Position[1]++;
            else running = false;

            DrawPiece( temp );

        }

        DrawPiece();

    }

    private void CheckLost() {

        for ( int i = 0; i < _board.GetLength( 0 ); i++ ) {

            if ( _board[i, 1] > 0 ) {

                GameRunning = false;

                Leaderboard.SaveScore( new string[] { Score.ToString() }, Leaderboard.TETRIS_GAME_NAME );

                for ( int x = 0; x < Display.GetLength( 0 ); x++ )
                    for ( int j = 0; j < Display.GetLength( 1 ); j++ )
                        Display[x, j].Image = null;

                return;

            }

        }

    }

    private void CheckClear() {

        int count = 0;
        bool foundClear = false;

        for ( int i = 0; i < _board.GetLength( 1 ); i++ ) {

            bool clear = true;

            for ( int j = 0; j < _board.GetLength( 0 ); j++ ) {

                if ( _board[j, i] > 0 )
                    continue;

                clear = false;
                j = _board.GetLength( 0 );

            }

            if ( clear ) {

                ClearLine( i );
                Lines++;
                count++;

                Score += CalculateScore( count );

                Level = (int) MathF.Floor( Lines / 10 );
                _dropRate = 0.5f - ( Level / 100 );
                foundClear = true;

            }

        }

        if ( !foundClear ) combo = 0;

    }

    private int CalculateScore( int count ) {

        int score = 0;

        switch ( count ) {

            case 1: score = 100; _tetrisCombo = false; break;
            case 2: score = 300; _tetrisCombo = false; break;
            case 3: score = 500; _tetrisCombo = false; break;
            case 4:

                score = ( _tetrisCombo ) ? 800 : 1200;
                if ( !_tetrisCombo ) _tetrisCombo = true;

                break;


        }

        score *= ( Level + 1 );

        score += combo * 50 * ( Level + 1 );
        combo++;

        return score;

    }

    private void ClearLine( int line ) {

        for ( int i = line; i >= 1; i-- ) {

            for ( int j = 0; j < _board.GetLength( 0 ); j++ ) {

                _board[j, i] = _board[j, i - 1];

            }

        }

    }

    public void MovePiece( int dir ) {

        ClearPiece();

        if ( CheckValidMove( dir, 0 ) )
            Piece.Position[0] += dir;
        DrawPiece();


    }

    public void RotatePiece( bool cw ) {

        ClearPiece();

        Piece.Rotate( cw );
        if ( !CheckValidMove( 0, 0 ) )
            Piece.Rotate( !cw );

        DrawPiece();

    }

    private bool CheckValidMove( int x, int y, TetrisPiece piece = null ) {

        if ( piece == null ) piece = Piece;

        for ( int i = 0; i < piece.Piece.GetLength( 0 ); i++ ) {

            for ( int j = 0; j < piece.Piece.GetLength( 1 ); j++ ) {

                if ( !IsInBounds( i + piece.Position[0] + x, j + piece.Position[1] + y ) ) {

                    if ( piece.Piece[i, j] == 0 ) continue;

                    return false;

                }

                if ( _board[i + Piece.Position[0] + x, j + piece.Position[1] + y] > 0 )
                    if ( piece.Piece[i, j] != 0 )
                        return false;

            }

        }

        return true;

    }
    private void DrawPiece( TetrisPiece piece = null ) {

        if ( piece == null ) piece = Piece;

        for ( int i = 0; i < piece.Piece.GetLength( 0 ); i++ ) {

            for ( int j = 0; j < piece.Piece.GetLength( 1 ); j++ ) {

                if ( piece.Piece[i, j] == 0 ) continue;

                if ( !IsInBounds( i + piece.Position[0], j + piece.Position[1] ) )
                    continue;

                _board[i + piece.Position[0], j + piece.Position[1]] = piece.Piece[i, j];

            }

        }

    }

    private void ClearPiece( TetrisPiece piece = null ) {

        if ( piece == null ) piece = Piece;

        for ( int i = 0; i < piece.Piece.GetLength( 0 ); i++ ) {

            for ( int j = 0; j < piece.Piece.GetLength( 1 ); j++ ) {

                if ( piece.Piece[i, j] == 0 ) continue;
                if ( !IsInBounds( i + piece.Position[0], j + piece.Position[1] ) ) continue;
                _board[i + piece.Position[0], j + piece.Position[1]] = 0;

            }

        }

    }

    private bool IsInBounds( int x, int y ) {

        bool vertical = x < 0 || x >= _board.GetLength( 0 );
        bool horizontal = y < 0 || y >= _board.GetLength( 1 );

        return !( vertical || horizontal );

    }

    public void DropPiece( int manual = 0 ) {

        ClearPiece();

        if ( !CheckValidMove( 0, 1 ) ) {

            _pieceActive = false;
            _swapped = false;

        } else {

            Piece.Position[1]++;
            Score += manual;

        }

        DrawPiece();

    }

    public void ShowBoard() {

        if ( !GameRunning ) return;

        for ( int i = 0; i < Display.GetLength( 0 ); i++ )
            for ( int j = 0; j < Display.GetLength( 1 ); j++ )
                if ( _board[i, j] == -1 ) _board[i, j] = 0;

        DrawGhost();

        for ( int i = 0; i < Display.GetLength( 0 ); i++ ) {

            for ( int j = 0; j < Display.GetLength( 1 ); j++ ) {

                if ( _board[i, j] == 0 && Display[i, j].Image != null )
                    Display[i, j].Image = null;
                else if ( _board[i, j] > 0 )
                    Display[i, j].Image = Image.FromFile( BasePath + Paths[_board[i, j] - 1] );
                else if ( _board[i, j] != 0 )
                    Display[i, j].Image = Image.FromFile( BasePath + "Ghost.png" );


            }

        }

    }

    public void GameLoop() {

        if ( !GameRunning ) return;

        CheckInputs();

        Update();

    }

    private void CheckInputs() {

        if ( !GameRunning ) return;

        if ( KeyManager.Instance.IsPressed( Keys.Left ) && KeyManager.Instance.IsPressed( Keys.Right ) ) {

            repeat.Restart();
            repeat.Stop();
            repeatStart = true;
            repeatFirst = true;

        } else if ( !KeyManager.Instance.IsPressed( Keys.Left ) && !KeyManager.Instance.IsPressed( Keys.Right ) ) {

            repeat.Restart();
            repeat.Stop();
            repeatStart = true;
            repeatFirst = true;

        } else if ( KeyManager.Instance.IsPressed( Keys.Left ) ) {

            repeat.Start();

            if (repeatFirst) {

                MovePiece( -1 );
                repeatFirst = false;

            }

            if ( repeat.ElapsedMilliseconds > ( ( repeatStart ) ? repeatDelay : repeatSpeed ) ) {

                MovePiece( -1 );
                repeatStart = false;
                repeat.Restart();

            }

        } else if ( KeyManager.Instance.IsPressed( Keys.Right ) ) {

            repeat.Start();

            if ( repeatFirst ) {

                MovePiece( 1 );
                repeatFirst = false;

            }

            if ( repeat.ElapsedMilliseconds > ( ( repeatStart ) ? repeatDelay : repeatSpeed ) ) {

                MovePiece( 1 );
                repeatStart = false;
                repeat.Restart();

            }

        }

        if ( KeyManager.Instance.IsPressed( Keys.Down ) ) DropPiece( 1 );

        if ( KeyManager.Instance.IsPressed( Keys.Z, true ) ) RotatePiece( false );
        else if ( KeyManager.Instance.IsPressed( Keys.Up, true ) ) RotatePiece( true );

        if ( KeyManager.Instance.IsPressed( Keys.C, true ) ) HoldPiece();

        if ( KeyManager.Instance.IsPressed( Keys.Space, true ) ) HardDrop();

    }

    private int GetRandomPiece() {

        if ( Pieces.Count <= 4 ) {

            var temp = new int[] { 0, 1, 2, 3, 4, 5, 6 }.ToList();

            for ( int i = 0; i < 7; i++ ) {

                int num = new Random().Next( temp.Count );
                Pieces.Add( temp[num] );
                temp.RemoveAt( num );

            }

        }

        int result = Pieces[0];
        Pieces.RemoveAt( 0 );

        return result;

    }

}

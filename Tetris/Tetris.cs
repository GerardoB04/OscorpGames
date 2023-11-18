using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris;

namespace OscorpGames {

    public partial class Tetris : Form {

        private TetrisController controller = new TetrisController();

        public Tetris() {

            InitializeComponent();

            controller.BoardUI = BoardUI;

            controller.Start();

        }

        private void GameLoop_Tick( object sender, EventArgs e ) {

            controller.GameLoop();
            ScoreLbl.Text = controller.Score.ToString();
            LevelLbl.Text = controller.Level.ToString();
            LinesLbl.Text = controller.Lines.ToString();

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

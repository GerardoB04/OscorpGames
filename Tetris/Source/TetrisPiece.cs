﻿namespace Tetris;

public class TetrisPiece
{

    private int[,,] _pieces = {

        {

            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 }

        }, {

            { 0, 0, 0, 0},
            { 0, 2, 2, 0},
            { 0, 2, 2, 0},
            { 0, 0, 0, 0}

        }, {

            { 0, 3, 0, 0 },
            { 0, 3, 0, 0 },
            { 0, 3, 3, 0 },
            { 0, 0, 0, 0 }

        }, {

            { 0, 4, 4, 0 },
            { 0, 4, 0, 0 },
            { 0, 4, 0, 0 },
            { 0, 0, 0, 0 }

        }, {

            { 0, 0, 5, 0 },
            { 0, 5, 5, 0 },
            { 0, 5, 0, 0 },
            { 0, 0, 0, 0 }

        }, {

            { 0, 6, 0, 0 },
            { 0, 6, 6, 0 },
            { 0, 0, 6, 0 },
            { 0, 0, 0, 0 }

        }, {

            { 0, 0, 7, 0 },
            { 0, 7, 7, 0 },
            { 0, 0, 7, 0 },
            { 0, 0, 0, 0 }

        }

    };

    public int[,] Piece = new int[4, 4];
    public int[] Position = { 3, 0 };

    public int ID = -1;

    public TetrisPiece(int piece)
    {

        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                Piece[i, j] = _pieces[piece, i, j];

        ID = piece;

    }

    public void Rotate(bool cw = false)
    {

        int[,] newPiece = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j < 4; j++)
            {

                if (cw)
                    newPiece[3 - j, i] = Piece[i, j];
                else
                    newPiece[j, 3 - i] = Piece[i, j];

            }

        }

        Piece = newPiece;

    }

    public TetrisPiece GetGhost()
    {

        TetrisPiece piece = new TetrisPiece(ID);

        piece.Piece = (int[,])Piece.Clone();

        for (int i = 0; i < Piece.GetLength(0); i++)
            for (int j = 0; j < Piece.GetLength(1); j++)
                if (Piece[i, j] != 0) piece.Piece[i, j] = -1;


        piece.Position = (int[])Position.Clone();

        return piece;

    }

}

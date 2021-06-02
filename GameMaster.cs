using System;
using System.Collections.Generic;
using System.Text;

namespace ai_quarto
{
    public enum PieceTypes : byte
    {
        CHBH = 0,
        CHBN = 1,
        CHWH = 2,
        CHWN = 3,
        CLBH = 4,
        CLBN = 5,
        CLWH = 6,
        CLWN = 7,
        SHBH = 8,
        SHBN = 9,
        SHWH = 10,
        SHWN = 11,
        SLBH = 12,
        SLBN = 13,
        SLWH = 14,
        SLWN = 15,
    }

    class GameMaster
    {
        // field[x,y] = 0b00000000
        //   [7] = 0: no piece exists, 1: a piece exits
        //   [4-6] = reserved
        //   [3] = 0: circle, 1: square
        //   [2] = 0: high, 1: low
        //   [1] = 0: black, 1: white
        //   [0] = 0: with hole, 1: without hole
        public byte[,] field = new byte[4, 4];

        public bool[] used_piece = new bool[16];

        public byte next_piece = 0xFF;

        public System.Drawing.Bitmap[] bitmap_resources = new System.Drawing.Bitmap[16]
        {
            global::ai_quarto.Properties.Resources.CHBH,
            global::ai_quarto.Properties.Resources.CHBN,
            global::ai_quarto.Properties.Resources.CHWH,
            global::ai_quarto.Properties.Resources.CHWN,
            global::ai_quarto.Properties.Resources.CLBH,
            global::ai_quarto.Properties.Resources.CLBN,
            global::ai_quarto.Properties.Resources.CLWH,
            global::ai_quarto.Properties.Resources.CLWN,
            global::ai_quarto.Properties.Resources.SHBH,
            global::ai_quarto.Properties.Resources.SHBN,
            global::ai_quarto.Properties.Resources.SHWH,
            global::ai_quarto.Properties.Resources.SHWN,
            global::ai_quarto.Properties.Resources.SLBH,
            global::ai_quarto.Properties.Resources.SLBN,
            global::ai_quarto.Properties.Resources.SLWH,
            global::ai_quarto.Properties.Resources.SLWN
        };

        public Form1 form1;

        public GameMaster(Form1 form1)
        {
            this.form1 = form1;
        }

        private System.Drawing.Bitmap getResource(byte field_data)
        {
            if ((field_data & 0x80) == 0)
            {
                return global::ai_quarto.Properties.Resources.none;
            }
            else
            {
                return bitmap_resources[field_data & 0x0F];
            }
        }
        public void redrawFields()
        {
            form1.pictureBox_board_1.Image = getResource(field[0, 0]);
            form1.pictureBox_board_2.Image = getResource(field[1, 0]);
            form1.pictureBox_board_3.Image = getResource(field[2, 0]);
            form1.pictureBox_board_4.Image = getResource(field[3, 0]);
            form1.pictureBox_board_5.Image = getResource(field[0, 1]);
            form1.pictureBox_board_6.Image = getResource(field[1, 1]);
            form1.pictureBox_board_7.Image = getResource(field[2, 1]);
            form1.pictureBox_board_8.Image = getResource(field[3, 1]);
            form1.pictureBox_board_9.Image = getResource(field[0, 2]);
            form1.pictureBox_board_10.Image = getResource(field[1, 2]);
            form1.pictureBox_board_11.Image = getResource(field[2, 2]);
            form1.pictureBox_board_12.Image = getResource(field[3, 2]);
            form1.pictureBox_board_13.Image = getResource(field[0, 3]);
            form1.pictureBox_board_14.Image = getResource(field[1, 3]);
            form1.pictureBox_board_15.Image = getResource(field[2, 3]);
            form1.pictureBox_board_16.Image = getResource(field[3, 3]);
        }

        public bool putPiece(int x, int y)
        {
            if (next_piece != 0xFF && ((field[x, y] & 0x80) == 0))
            {
                field[x, y] = next_piece;
                field[x, y] |= 0x80;
                next_piece = 0xFF;
                form1.pictureBox_next.Image = global::ai_quarto.Properties.Resources.none;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setNextPiece(byte piece)
        {
            if (used_piece[piece] || next_piece != 0xFF)
            {
                return false;
            }
            else
            {
                next_piece = piece;
                used_piece[piece] = true;
                form1.pictureBox_next.Image = bitmap_resources[piece];
                return true;
            }
        }
    }
}

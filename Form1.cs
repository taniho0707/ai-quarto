using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_quarto
{
    public partial class Form1 : Form
    {
        GameMaster game_master;
        public Form1()
        {
            InitializeComponent();
            game_master = new GameMaster(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_stock_1_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CHBH))
            {
                this.pictureBox_stock_1.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_2_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CHBN))
            {
                this.pictureBox_stock_2.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_3_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CHWH))
            {
                this.pictureBox_stock_3.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_4_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CHWN))
            {
                this.pictureBox_stock_4.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_5_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CLBH))
            {
                this.pictureBox_stock_5.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_6_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CLBN))
            {
                this.pictureBox_stock_6.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_7_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CLWH))
            {
                this.pictureBox_stock_7.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_8_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.CLWN))
            {
                this.pictureBox_stock_8.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_9_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SHBH))
            {
                this.pictureBox_stock_9.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_10_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SHBN))
            {
                this.pictureBox_stock_10.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_11_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SHWH))
            {
                this.pictureBox_stock_11.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_12_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SHWN))
            {
                this.pictureBox_stock_12.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_13_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SLBH))
            {
                this.pictureBox_stock_13.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_14_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SLBN))
            {
                this.pictureBox_stock_14.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_15_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SLWH))
            {
                this.pictureBox_stock_15.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_stock_16_Click(object sender, EventArgs e)
        {
            if (game_master.setNextPiece((byte)PieceTypes.SLWN))
            {
                this.pictureBox_stock_16.Image = global::ai_quarto.Properties.Resources.none;
            }
        }

        private void pictureBox_board_1_Click(object sender, EventArgs e)
        {
            game_master.putPiece(0, 0);
            game_master.redrawFields();
        }

        private void pictureBox_board_2_Click(object sender, EventArgs e)
        {
            game_master.putPiece(1, 0);
            game_master.redrawFields();
        }

        private void pictureBox_board_3_Click(object sender, EventArgs e)
        {
            game_master.putPiece(2, 0);
            game_master.redrawFields();
        }

        private void pictureBox_board_4_Click(object sender, EventArgs e)
        {
            game_master.putPiece(3, 0);
            game_master.redrawFields();
        }

        private void pictureBox_board_5_Click(object sender, EventArgs e)
        {
            game_master.putPiece(0, 1);
            game_master.redrawFields();
        }

        private void pictureBox_board_6_Click(object sender, EventArgs e)
        {
            game_master.putPiece(1, 1);
            game_master.redrawFields();
        }

        private void pictureBox_board_7_Click(object sender, EventArgs e)
        {
            game_master.putPiece(2, 1);
            game_master.redrawFields();
        }

        private void pictureBox_board_8_Click(object sender, EventArgs e)
        {
            game_master.putPiece(3, 1);
            game_master.redrawFields();
        }

        private void pictureBox_board_9_Click(object sender, EventArgs e)
        {
            game_master.putPiece(0, 2);
            game_master.redrawFields();
        }

        private void pictureBox_board_10_Click(object sender, EventArgs e)
        {
            game_master.putPiece(1, 2);
            game_master.redrawFields();
        }

        private void pictureBox_board_11_Click(object sender, EventArgs e)
        {
            game_master.putPiece(2, 2);
            game_master.redrawFields();
        }

        private void pictureBox_board_12_Click(object sender, EventArgs e)
        {
            game_master.putPiece(3, 2);
            game_master.redrawFields();
        }

        private void pictureBox_board_13_Click(object sender, EventArgs e)
        {
            game_master.putPiece(0, 3);
            game_master.redrawFields();
        }

        private void pictureBox_board_14_Click(object sender, EventArgs e)
        {
            game_master.putPiece(1, 3);
            game_master.redrawFields();
        }

        private void pictureBox_board_15_Click(object sender, EventArgs e)
        {
            game_master.putPiece(2, 3);
            game_master.redrawFields();
        }

        private void pictureBox_board_16_Click(object sender, EventArgs e)
        {
            game_master.putPiece(3, 3);
            game_master.redrawFields();
        }
    }
}

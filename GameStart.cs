using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class FrmGameStart : Form
    {
        public FrmGameStart()
        {
            InitializeComponent();

        }
        // Method to activate the play button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Check which level button is selected
            if (rbtnEasy.Checked)
            {
                // Easy level selected
                FrmBoardGame boardGame = new FrmBoardGame(8, 0.1f);
                boardGame.Show();
                this.Hide();
            }
            else if (rbtnMedium.Checked)
            {
                // Medium level selected
                FrmBoardGame boardGame = new FrmBoardGame(16, 0.2f);
                boardGame.Show();
                this.Hide();
            }
            else if (rbtnDifficult.Checked)
            {
                // Difficult level selected
                FrmBoardGame boardGame = new FrmBoardGame(24, 0.3f);
                boardGame.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schere_Stein_Papier
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int playerTurn = random.Next(1, 4);
            int computerTurn = random.Next(1, 4);


            switch (playerTurn)
            {
                case 1:
                    pbSpieler.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Stein.jpg";
                    pbSpieler.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    pbSpieler.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Schere.jpg";
                    pbSpieler.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3:
                    pbSpieler.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Papier.jpg";
                    pbSpieler.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    break;
            }

            switch (computerTurn)
            {
                case 1:
                    pbGegner.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Stein.jpg";
                    pbGegner.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    pbGegner.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Schere.jpg";
                    pbGegner.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3:
                    pbGegner.ImageLocation = @"C:\Users\User\Downloads\SchereSteinPapier.Papier.jpg";
                    pbGegner.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    break;
            }

            BestimmeGewinner(playerTurn, computerTurn);
        }

        public void BestimmeGewinner(int playerScore, int computerScore)
        {
            if (playerScore == 1 && computerScore == 2)
            {
                lblSSP.Text = "Spieler gewinnt";
            }
            else if (playerScore == 1 && computerScore == 3)
            {
                lblSSP.Text = "Gegner gewinnt";
            }
            else if (playerScore == 1 && computerScore == 1)
            {
                lblSSP.Text = "Unentschieden";
            }
            else if (playerScore == 2 && computerScore == 1)
            {
                lblSSP.Text = "Gegner gewinnt";
            }
            else if (playerScore == 2 && computerScore == 3)
            {
                lblSSP.Text = "Spieler gewinnt";
            }
            else if (playerScore == 2 && computerScore == 2)
            {
                lblSSP.Text = "Unentschieden";
            }
            else if (playerScore == 3 && computerScore == 1)
            {
                lblSSP.Text = "Spieler gewinnt";
            }
            else if (playerScore == 3 && computerScore == 2)
            {
                lblSSP.Text = "Gegner gewinnt";
            }
            else if (playerScore == 3 && computerScore == 3)
            {
                lblSSP.Text = "Unentschieden";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball
{
    public partial class Form1 : Form
    {
        Simulator sim = new Simulator();
        int[] scores = new int[18];
        Label[] score = new Label[18];
        int inning;
        int finalScore1 = 0, finalScore2 = 0;




        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTeam1.Text = txtTeam1.Text;
            lblTeam2.Text = txtTeam2.Text;

           int hit = sim.hitOrStrike();
           

            while (inning < 19)
            {
                if (hit == 1)
                {
                    sim.Running();
                    for (int i = scores.Length; i != 0; i--)
                    {
                        score[i - 1].Text = scores[i - 1].ToString();

                    }
                }


                else if (hit == 0)
                {
                    sim.hitOrStrike();

                    inning = sim.checkInning();
                }
                else 
                { 
                
                }


            }

            scores = sim.getScores();
            for (int i = score.Length; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    finalScore1 = finalScore1 + scores[i - 1];

                }
                else
                    finalScore2 = finalScore2 + scores[i - 1];


            }
            lblTeam1ScoreFinal.Text = finalScore1.ToString();
            lblTeam2ScoreFinal.Text = finalScore2.ToString();

 
        }

        private void lblTeam2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score[0] = lblTeam1Score1;
            score[1] = lblTeam2Score1;
            score[2] = lblTeam1Score2;
            score[3] = lblTeam2Score2;
            score[4] = lblTeam1Score3;
            score[5] = lblTeam2Score3;
            score[6] = lblTeam1Score4;
            score[7] = lblTeam2Score4;
            score[8] = lblTeam1Score5;
            score[9] = lblTeam2Score5;
            score[10] = lblTeam1Score6;
            score[11] = lblTeam2Score6;
            score[12] = lblTeam1Score7;
            score[13] = lblTeam2Score7;
            score[14] = lblTeam1Score8;
            score[15] = lblTeam2Score8;
            score[16] = lblTeam1Score9;
            score[17] = lblTeam2Score9;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblTeam1ScoreFinal_Click(object sender, EventArgs e)
        {

        }

        private void lblTeam1Score3_Click(object sender, EventArgs e)
        {

        }
    }
}

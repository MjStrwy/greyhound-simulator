using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    public partial class Form1 : Form
    {
        //Initialize array of guys
        Guy[] guys = new Guy[3];

        //intialize array of greyhounds
        Greyhound[] GreyhoundArray = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();

            guys[0] = new Guy() { Money = 100, Name = "Joe", MyLabel= lblJoe, MyRadioButton = radioJoe };
            guys[1] = new Guy() { Money = 100, Name = "Bob", MyLabel = lblBob, MyRadioButton = radioBob };
            guys[2] = new Guy() { Money = 100, Name = "Al", MyLabel = lblAl, MyRadioButton = radioAl };
            foreach(Guy guy in guys)
                guy.PlaceBet(0, 0);

            //set the default bet name to Joe
            lblName.Text = guys[0].Name;

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = new Random()
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };
        
            updateForm();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            //reset dog positions
            foreach(Greyhound g in GreyhoundArray){
                g.MyPictureBox.Left = g.StartingPosition;
            }
            
            //start timer for race
            timer1.Enabled = true ;
            //int winner = new Random().Next(1,4);
            //while(!GreyhoundArray[0].Run(racetrackPictureBox));
            //MessageBox.Show("Dog " + (winner + 1) + " wins!");
            //MessageBox.Show("Dogs ran");
        }

        public void updateForm()
        {
            radioJoe.Text = guys[0].Name + " has $" + guys[0].Money;
            radioBob.Text = guys[1].Name + " has $" + guys[1].Money;
            radioAl.Text = guys[2].Name + " has $" + guys[2].Money;
        }

        public void radioJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[0].Name;
        }

        private void radioBob_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[1].Name;
        }

        private void radioAl_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[2].Name;
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            int guy;
            if (radioJoe.Checked)
            {
                guy = 0;
            }
            else if(radioBob.Checked)
            {
                guy = 1;
            }
            else
            {
                guy = 2;
            }
            guys[guy].PlaceBet((int)numBets.Value, (int)numDog.Value - 1);
            
            Console.WriteLine(guys[guy].Name + " bets $" + guys[guy].Bet.Amount + " on dog " + (guys[guy].Bet.Dog + 1));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            //while (!GreyhoundArray[0].Run(racetrackPictureBox) && !GreyhoundArray[1].Run(racetrackPictureBox) && !GreyhoundArray[2].Run(racetrackPictureBox) && !GreyhoundArray[3].Run(racetrackPictureBox)) { }
            //timer1.Enabled = false;
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run(racetrackPictureBox))
                {
                    winner = i;
                    timer1.Enabled = false;
                    MessageBox.Show("Dog #" + (winner + 1) + " Wins!");
                    for (int j = 0; j < guys.Length; j++)
                    {
                        if (guys[j].Bet.PayOut(winner) != 0)
                            guys[j].Money += guys[j].Bet.PayOut(winner);
                        guys[j].MyRadioButton.Text = guys[j].Name + " has $" + guys[j].Money;
                    }
                    break;
                }
            }
           
        }
    }
}

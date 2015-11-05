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

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width//,
                //Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width//,
                //Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width//,
                //Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width//,
                //Randomizer = MyRandomizer
            };
        
            updateForm();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            int winner = 0;//GreyhoundArray[0].Run();
            for( int i = 0; i < guys.Length; i++){
                guys[i].Money += guys[i].Bet.PayOut(winner);
                guys[i].MyRadioButton.Text = guys[i].Name + " has $" + guys[i].Money;
            }
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
            
            //Console.WriteLine(guys[guy].Name + " bets $" + guys[guy].Bet.Amount + " on dog " + (guys[guy].Bet.Dog + 1));
        }
    }
}

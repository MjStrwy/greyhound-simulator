using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer = new Random();

        public bool Run()
        {
            //move forward either 1, 2, 3, or 4 spaces at random
            //update the position of my picturebox on the form
            //MyPictureBox.Left = StartingPosition + Location;
            //return true if I won the race
            return true;
        }

        public void TakeStartingPosition()
        {
            //reset location to 0 and picturebox to starting position
            Location = 0;
            StartingPosition = 0;
        }
    }
}

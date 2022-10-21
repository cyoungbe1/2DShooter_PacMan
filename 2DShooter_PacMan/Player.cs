using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DShooter_PacMan
{
    public class Player 
    { 
    public char weapon1;
    public char weapon2;
    public char weapon3;
    public char item1;
    public char item2;
    public int totalPoints;
    public string name;

    public Player() { }

    public override string ToString()
    {
        return String.Format("{weapon1,weapon2,weapon3,item1,item2,totalPoints");
    }

    public class selectWeapon : IWeapon

    {

        public char newWeapon;

        public void chooseWeapon(int totalPoints)

        {

            if (totalPoints < 6)

            {

                newWeapon = 'r';  // riffle

            }

            else if (totalPoints < 11)

            {

                newWeapon = 'k';  // knife

            }

            else if (totalPoints < 16)

            {

                newWeapon = 'b';  // bomb

            }

            else if (totalPoints < 21)

            {

                newWeapon = 'a';  // bow and arrow

            }

            else

            {

                newWeapon = 'c';  // cannon

            }



        }

    }

}
}

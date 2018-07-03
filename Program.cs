using System;
using Microsoft.SmallBasic.Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trtltraning
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Turtle.Speed = 10;
            int i = 0;
            while (i < 8) {
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnLeft();
                Turtle.Move(25);
                Turtle.TurnLeft();
                i++;
            }
        }
    }
}

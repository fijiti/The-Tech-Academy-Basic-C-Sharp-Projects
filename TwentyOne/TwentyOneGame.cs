using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            // Able to add this in TwentyOneGame due to virtual listing in abstract Game class. 
            Console.WriteLine("21 Players:");
            // This is same method as in parent 
            base.ListPlayers();
        }
    }
}

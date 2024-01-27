using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPingPong
{
    public class Jugador
    {
        public int Positionx { get; set; }
        public int Positiony { get; set; } = 0;
        public object? Source { get; set; }

        public GameCommand MoveUp { get; set; }

        public GameCommand MoveDown { get; set; }

        public Jugador()
        {
            MoveDown = new GameCommand(Up, CanMove);
            MoveUp = new GameCommand(u)
        }
        
    }
}

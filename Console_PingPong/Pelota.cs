using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPingPong
{
    public class Pelota
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public object Source { get; set; }
        public Pelota()
        {

        }
        public void OnDraw()
        {
            #region Se pinta pelota
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Source);
            #region
        }
    }
}

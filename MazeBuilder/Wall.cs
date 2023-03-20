using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    class Wall : MapSite
    {
        // Конструктор.
        public Wall()
        {
        }

        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}

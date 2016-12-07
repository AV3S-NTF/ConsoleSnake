using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnakeGH {
    class Snake {
        enum direction { UP, RIGHT, DOWN, LEFT };

        struct point {
            public int x;
            public int y;
            public bool visible;
        }
    }

    class Game {

        enum direction { UP, RIGHT, DOWN, LEFT };

        static void Main( string[] args ) {
            bool done = false;
            int test = 0;
            float FPS = 2.0f;

            while ( !done )
            {
                System.Threading.Thread.Sleep( (int)( 1000.0f / FPS ) );
                Console.WriteLine(test);
                test++;
            }
        }
    }
}

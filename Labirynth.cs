using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1
{
    public class Labirynth
    {
        private Content[,] contents;

        public Labirynth(Content[,] contents)
        {
            this.contents = contents;
        }

        public void Collect(int x, int y)
        {
            if (contents[x, y] == Content.TREASURE)
            {
                contents[x, y] = Content.EMPTY;
            }
            else { contents[x, y] = contents[x,y]; }
        }

        public Content WhatIsThere(int x, int y, Direction d)
        {
            if ((x + d.x) < 0 || (y + d.y) < 0)
            {
                return contents[x,y];
            }
            else return contents[x+d.x,y+d.y];
        }

    }

}
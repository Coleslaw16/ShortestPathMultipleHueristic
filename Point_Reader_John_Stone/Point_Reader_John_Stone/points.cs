using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Point_Reader_John_Stone
{
    class points
    {
        private float x;
        private float y;
        private float size;
        protected Color color;

        public points(float newX, float newY, float newSize, Color newColor)
        {
            x = newX;
            y = newY;
            size = newSize;
            color = newColor;
        }

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public float Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{
    abstract class DesignElement
    {
        float x, y, whidth, height;
        Pen pen;
        Graphics g;

        public Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }

        public Graphics G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
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

        public float Whidth
        {
            get
            {
                return whidth;
            }

            set
            {
                whidth = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public DesignElement(float x, float y, float whidth, float height, Pen pen, Graphics g)
        {
            this.X = x;
            this.Y = y;
            this.Whidth = whidth;
            this.Height = height;
            this.Pen = pen;
            this.G = g;

        }

        public DesignElement(Pen pen, Graphics g)
        {
            this.Pen = pen;
            this.G = g;

        }

        abstract public void Draw();


    }
}

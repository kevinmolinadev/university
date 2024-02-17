namespace ghsef
{
    public class Punto
    {
        private int x;
        private int y;
        public Punto()
        {
            x = 0;
            y = 0;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void verificar(string s)
        {
            
            if (x > 0 && y > 0)
            {
                s = "Primer cuadrante";
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    s = "Segundo cuadrante";
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        s = "Tercer cuadrante";
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            s = "Cuarto cuadrante";
                        }
                        else
                        {
                            if (x == 0 && y == 0)
                            {
                                s = "Cuadrante inicial";
                            }
                        }
                    }
                }

            }
        }
    } //end class
}

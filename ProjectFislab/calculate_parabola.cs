using System;
namespace ProjectFislab
{
    public class calculate_parabola
    {
        public void calculateVoy(){
            c_parabola parabola = new c_parabola();
            parabola.voy = parabola.vo*Math.Sin(parabola.alpha);
        }
        public void calculateVy(){
            c_parabola parabola = new c_parabola();
            parabola.vy = parabola.vo*Math.Sin(parabola.alpha) - parabola.gravity*parabola.time;
        }
        public void calculateVx()
        {
            c_parabola parabola = new c_parabola();
            parabola.vx = parabola.vo *  Math.Cos(parabola.alpha);
            parabola.vox = parabola.vx;
        }
        public void calculateH()
        {
            c_parabola parabola = new c_parabola();
            parabola.h = parabola.vo * parabola.time * Math.Sin(parabola.alpha) - 0.5 * parabola.gravity * Math.Sqrt(parabola.time);
            parabola.hmax = (Math.Sqrt(parabola.vo) * Math.Sqrt(Math.Sin(parabola.alpha))) / (2 *  parabola.gravity);
        }
        public void calculateS()
        {
            c_parabola parabola = new c_parabola();
            if (parabola.vx != 0)
            {
                parabola.s = parabola.vx * parabola.time;
            }
            else
            {
                parabola.s = parabola.vo * Math.Cos(parabola.alpha) * parabola.time;
            }
            parabola.smax = (Math.Sqrt(parabola.vo) * Math.Sin(2 * parabola.alpha)) / (parabola.gravity);
        } 
    }
}
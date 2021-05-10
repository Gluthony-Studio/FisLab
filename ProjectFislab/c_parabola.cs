using System;
namespace ProjectFislab
{
    public class c_parabola
    {
        private double _vo;
        private double _voy;
        private double _vox;
        private double _vy;
        private double _vx;
        private double _h;
        private double _hmax;
        private double _s;
        private double _smax;
        private double _gravity;
        private double _alpha;
        private double _time;

        public double vo{
            get{return _vo;}
            set{_vo = value;}
        }
        public double voy{
            get{return _voy;}
            set{_voy = value;}
        }
        public double vox{
            get{return _vox;}
            set{_vox = value;}
        }
        public double vy{
            get{return _vy;}
            set{_vy = value;}
        }
        public double vx{
            get{return _vx;}
            set{_vx = value;}
        }
        public double h{
            get{return _h;}
            set{_h = value;}
        }
        public double hmax{
            get{return _hmax;}
            set{_hmax = value;}
        }
        public double s{
            get{return _s;}
            set{_s = value;}
        }
        public double smax{
            get{return _smax;}
            set{_smax = value;}
        }
        public double gravity{
            get{return _gravity;}
            set{_gravity = value;}
        }
        public double alpha{
            get{return _alpha;}
            set{_alpha = value;}
        }
        public double time{
            get{return _time;}
            set{_time = value;}
        }
        public c_parabola(){}
        public c_parabola(double Vo, double Voy, double Vox, double Vy, double Vx, 
        double H, double Hmax, double S, double Smax, double Gravity, double Alpha){
            vo = Vo;
            voy = Voy;
            vox = Vox;
            vy = Vy;
            vx = Vx;
            h = H;
            hmax = Hmax;
            s = S;
            smax = Smax;
            gravity = Gravity;
            alpha = Alpha;
        }
    }
}
using System;
namespace ProjectFislab
{
    public class c_glbb
    {
        private double _s;
        private double _time;
        private double _acceleration;
        private double _vo;
        private double _vt;

        public double s{
            get{return _s;}
            set{_s = value;}
        }
        public double time{
            get{return _time;}
            set{_time = value;}
        }
        public double acceleration{
            get{return _acceleration;}
            set{ _acceleration = value;}
        }
        public double vo{
            get{return _vo;}
            set{_vo = value;}
        }
        public double vt{
            get{return _vt;}
            set{_vt = value;}
        }
        public c_glbb(){}
        public c_glbb(double S, double Time, double Acceleration, double Vo, double Vt){
            s = S;
            time = Time;
            acceleration = Acceleration;
            vo = Vo;
            vt = Vt;
        }
    }
}
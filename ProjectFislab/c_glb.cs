using System;
namespace ProjectFislab
{
    public class c_glb
    {
        private double _s;
        private double _velocity;
        private double _time;

        public double s{
            get{return _s;}
            set{_s = value;}
        }
        public double velocity{
            get{return _velocity;}
            set{_velocity = value;}
        }
        public double time{
            get{return _time;}
            set{_time = value;}
        }
        public c_glb(){}
        public c_glb(double S, double Velocity, double Time){
            s = S;
            velocity = Velocity;
            time = Time;
        }
    }
}
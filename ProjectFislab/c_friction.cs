namespace ProjectFislab
{
    public class c_friction
    {
        protected double _fs;
        protected double _fk;
        public double fs{
            get{return _fs;}
            set{_fs = value;}
        }
        public double fk{
            get{return _fk;}
            set{_fk = value;}
        }
        public c_friction() { }
        public c_friction(double Fs, double Fk){
            fs = Fs;
            fk = Fk;
        }
    }
}
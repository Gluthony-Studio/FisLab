using System;
namespace ProjectFislab
{
    public class calculate_glbb
    {
        public void calculateVt(){
            c_glbb glbb = new c_glbb();
            if (glbb.time != 0)
            {
                glbb.vt = glbb.vo + (glbb.acceleration*glbb.time);
            }else if(glbb.s != 0){
                glbb.vt = glbb.vo + (2*glbb.acceleration*glbb.s);
            }
        }
        public void calculateS(){
            c_glbb glbb = new c_glbb();
            glbb.s = glbb.vo*glbb.time + 0.5*glbb.acceleration*glbb.time;
        }
    }
}
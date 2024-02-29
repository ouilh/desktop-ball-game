using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_game2
{
    class coints
    {
        private int coint;
        public  coints() { }
        public  coints (int c)
        {
            coint= c  ;
        }
        public int COINT
        {
            get { return coint; }
            set { coint = value; }
        }
        public override string ToString()
        {
            return coint.ToString();
        }
    }
}

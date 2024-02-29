using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_game2
{
    class control
    {
        private static string up;
        private string left;
        private string right;
        private string space;
        public control() { }
        public  control(string u, string l, string r,string s)
        {
            up = u;
            left = l;
            right = r;
            space = s;

        }
        public string UP
        {
            set { up = value; }
            get { return up; }
        }
        public string LEFT
        {
            set { left = value; }
            get { return left; }
        }
        public string RIGHT
        {
            set { right = value; }
            get { return right; }
        }
        public string SPACE
        {
            set { space = value; }
            get { return space; }
        }


    }
}

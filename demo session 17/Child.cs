using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace demo_session_17
{
    internal class Child : person
    {
        public int Z {  get; set; }

        public Child(int x,int y,int z) : base(x,y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"{X}::{Y}::{Z}";
        }
        public new int product()
        {
            return base.product() * Z;
        }


    }
}

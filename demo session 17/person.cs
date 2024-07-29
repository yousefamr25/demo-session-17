using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_session_17
{
    internal class person
    {
        #region attributes
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region constructor
        public person(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{X} :: {Y}";
        }

        public  int product()
        {
            return X * Y;
        }

        #endregion



    }







}

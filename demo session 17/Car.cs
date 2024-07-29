using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace demo_session_17
{
    internal class Car
    {
       
        #region attributes
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region constructor
        public Car()
        {

        }
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        public Car(int id, string model):this(id,model,200)
        {
           
        }
        public Car(int id):this(id,"Audi",200)
        {
          
        }
        #endregion


        public override string ToString()
        {
            return $"Car id : {Id}\nModel : {Model}\nSpeed : {Speed} ";
        }


    }
}

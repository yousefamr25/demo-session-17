namespace demo_session_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            /*
             the top 3 problem that the encapsulation cancolve:
            1-you can not change the name of the data type
            2- you can set a limit or some condtion while take the input from the user
            3-you can forbed to change the values but you can read it 

            you solve by two ways :
            (getter ,setter)
            property


             */

            //Employee emp = new Employee(10, "yousef", 3000,50);
            ////Console.WriteLine(emp);
            ////emp.SetName("aliaa ahmed");
            ////Console.WriteLine(emp.GetName());

            //emp.Salary = 20000;
            //Console.WriteLine(emp.Salary);
            #region Enc phoneBook
            //PhoneBook Note=new PhoneBook(3);
            //Note.AddPerson(0, "yousef", 0584);
            //Note.AddPerson(1, "aya", 0589874);
            //Note.AddPerson(2, "ahmed", 058584);

            //int number = Note.GetPersonNumber("yousef");
            //Console.WriteLine(number ==-1?"person not found":number);
            //Note.SetPersonNumber("yousef", 9999);

            #endregion
            #region indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "yousef", 0584);
            //Note.AddPerson(1, "aya", 0589874);
            //Note.AddPerson(2, "ahmed", 058584);

            //Console.WriteLine(Note["yousef"]);
            //Note["yousef"] = 100;
            //Console.WriteLine(Note["yousef"]);
            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}


            #endregion







            #endregion
            #region class
            //Car c1;
            //c1=new Car();
            ////allocate required Bytes At heap
            ////intilize the allocated bytes with the defualt value of the datatype
            ////call use defuned constructor [if existes]
            ////assign the reference "c1 to allocate object at heap "
            //Console.WriteLine(c1);
            //Car c1= new Car(10,"porche");


            #endregion
            #region inheritance
            //person p= new person(1,3);
            ////Console.WriteLine(p.ToString());
            //Child c = new Child(5,6,7);
            //Console.WriteLine(c.ToString());



              


            #endregion


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demo_session_17
{
    internal struct PhoneBook
    {
        #region Attribute
        string[] names;
        int[] numbers;
        int size;

        #endregion

        #region constructor
        public PhoneBook(int ssize)
        {
            size = ssize;
            names = new string[size];
            numbers = new int[size];

        }



        #endregion
        #region Method
        public void AddPerson(int postion,string name,int number)
        {
            if (numbers != null && names is not null)
            {
                if (postion < size)
                {
                    names[postion] = name;
                    numbers[postion] = number;
                }
            }


        }



        #endregion
        #region prop
        public int Size
        {
            get
            {
                return size;
            }
            set { size = value; }

        }





        #endregion

        #region Getter Setter
        //get
        public int GetPersonNumber(string name)
        {
            if(name is not null && numbers is not null)
            {
                for(int i=0; i < names.Length; i++)
                {
                    if(names[i] == name) return numbers[i];
                }
            }
            return -1;

        }
        //set
        public void SetPersonNumber(string name,int number)
        {
            if(names is not null && numbers is not null)
            {
                for(int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = number;
                        break;
                    }
                }
            }
            
        }


        #endregion


        #region indexer
        public string this[int index]
        {
            get
            {
                return $"{index} :: {names[index]} :: {numbers[index]}";
            }
        }
        public int this[string name]
        {


            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (names[i] == name) return numbers[i];

                    }
                    return -1;
                }
                return -1;
            }

            set
            {
                if (names is not null && numbers is not null)
                {



                    for (int i = 0; i < name.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }

                    }
                }
            }
        }



        #endregion






    }
}

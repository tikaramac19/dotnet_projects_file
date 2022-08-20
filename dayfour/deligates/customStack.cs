
using System;

namespace deligates
{
    public class customStack
    {
        private int[] _container = new int[5];

        private int counter = -1;

        public void push(int item)
        {

            if(counter < 4)
            {
                counter ++;

                _container[counter] = item;

                Console.WriteLine(_container[counter]);
            }
            else{
                Console.WriteLine("Stack is full");
            }
           

        }
        public void pop()
        {

            if(counter >=0)
            {
                _container[counter] = default(int);


                counter--;


            }
            else{
                Console.WriteLine("Stack is empty");
            }

        }
    }
}
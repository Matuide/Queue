using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(3);
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);
            q.enqueue(4);
            Console.WriteLine(q.dequeue());
        }

class Queue 
        {
            private int[] Q = new int[5];
                private int front;
            private int back;
            private Boolean full = false;
            public Queue(int size)
            {
                Q = new int[size];
                front = 0;
                back = 0;

            }
            public  void enqueue(int value)
            {
                if (full == false)
                {
                    Q[back] = value;
                    back = (back + 1) % Q.Length;
                    if (back == front) full = true;
                }
                else Console.WriteLine("full");
            }
            public int dequeue()
            {
                int value;
                if (back != front || full == true)
                {
                    value = Q[front];
                    full = false;
                }
                else value = -999;
                return value;
                

                
            }
            
        }
        static void Say(string saying)
        {
            Console.WriteLine("");
            Console.WriteLine(saying);
            Console.WriteLine("");
        }
    }
}

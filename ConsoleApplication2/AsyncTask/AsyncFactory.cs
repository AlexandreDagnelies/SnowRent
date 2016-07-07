using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowRentLibrary.AsyncTask
{
    public class AsyncFactory
    {
        public  void TestIt()
        {
            /*await CountTo10000();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Ui Thread i  is ->" + i);
            }*/
            //Task<Int32> async = CountTo10000withReturn();
            //Int32 result = async.Result;
        }
        private Task<Int32> CountTo10000withReturn()
        {
            Func<Int32> count =  new Func<Int32>(() => 
            {
                int i= 0;
                for (; i < 10000; i++)
                {
                    Console.WriteLine("AsyncTask is ->" + i );
                }
                return i;
            });
            //je ne peux pas retourner return car c'est une action
            //Du coup il faut faire ça
            return Task.Run(count);
            
        }

    }
}

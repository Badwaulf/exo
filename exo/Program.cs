using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                StudentListisNotFoundException ret = new StudentListisNotFoundException();
                throw ret;
            }
            catch(StudentListisNotFoundException stuEx)
            {
                Console.WriteLine(stuEx.Message.ToString());

            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

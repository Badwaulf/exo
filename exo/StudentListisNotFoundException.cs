using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo
{
    class StudentListisNotFoundException : Exception
    {
        public StudentListisNotFoundException()
        {
            throw new StudentListisNotFoundException("");
        }

        public StudentListisNotFoundException(string message)

            :base("List student not found")
        {


        }

        public StudentListisNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}

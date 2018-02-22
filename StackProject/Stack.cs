using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class Stack
    {
        public List<object> StackList {get; set;}

        public Stack()
        {
            StackList = new List<object>();
        }
    }
}

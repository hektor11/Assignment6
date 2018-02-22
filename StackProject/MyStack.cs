using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class MyStack : Stack
    {

        public void Push(object obj)
        {
            StackList.Add(obj);
        }

        public object Pop()
        {
           if(StackList.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            else
            {
                object temp = StackList[StackList.Count() - 1];
                StackList.Remove(StackList[StackList.Count() - 1]);
                return temp;
            }
        }

        public void Clear()
        {
            StackList.Clear();
        }

    }
}

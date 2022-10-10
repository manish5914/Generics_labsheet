using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{
    public class CustomStack<T> : ICustomStack<T> where T: IIntern
    {
        private T[] arrayStack = new T[10];
        private int currentIndex;

        public CustomStack()
        {
            currentIndex = -1;
        }
        public void Push(T value)
        {
            arrayStack[currentIndex + 1] = value;
            currentIndex++;
        }
        public T Pop()
        {
            T value = arrayStack[currentIndex];
            currentIndex--;
            return value;
        }
        public int Count()
        {
            return currentIndex + 1;
        }
    }
    //public class CustomStackTest
    //{
    //    public CustomStackTest()
    //    {
    //        StackTest();
    //    }
    //    public void StackTest()
    //    {
    //        CustomStack<IItern> stack = new CustomStack<IItern>();
    //        stack.Push("Jedi-x");
    //        stack.Pop();
    //        stack.Push("Jedi");

    //        stack.Push("SkillsLab");

    //        while (stack.Count() > 0)
    //        {
    //            Console.WriteLine(stack.Pop());
    //        }
    //        Console.ReadLine();
    //    }

    //    public void CustomStakExtendedOP()
    //    {


    //    }
    //}
}

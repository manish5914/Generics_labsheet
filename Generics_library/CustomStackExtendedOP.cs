using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{

    public class CustomStackExtendedOP
    {
        public CustomStackExtendedOP()
        {
            StackTestJedi();
        }
        public void StackTestJedi()
        {
            CustomStack<IIntern> stack = new CustomStack<Jedi>();
            stack.Push(new Jedi(name: "Manish", id: 0));
            stack.Push(new Jedi(name: "Tika", id: 1));
            stack.Push(new SkillsLab(name: "Washeem", id: 2));

            DisplayAllInternsNameAndId(stack);
        }

        public static void DisplayAllInternsNameAndId(ICustomStack<IIntern> stack)
        {
            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
            Console.ReadLine();
        }
    }
}

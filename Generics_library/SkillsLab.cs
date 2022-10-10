using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{
    public class SkillsLab: IIntern
    {
        private string name;
        private int Id;
        public string NameId => $"SkillsLab-{name}:{Id}";
        
        public SkillsLab(string name, int id)
        {
            this.name = name;
            Id = id;
        }
        
    }
    
}

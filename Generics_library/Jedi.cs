using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{
    public class Jedi : IIntern
    {
        private string name;
        private int Id;
        //string IItern.NameId { get ; }
        public string NameId => $"Jedi-{name}:{Id}";

        public Jedi(string name, int id)
        {
            this.name = name;
            Id = id;
            
        }


    }
}

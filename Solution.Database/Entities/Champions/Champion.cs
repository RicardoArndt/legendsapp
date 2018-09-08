using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Database.Entities.Champions
{
    public class Champion
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool Ative { get; private set; }

        public Champion() { }

        public Champion(string name, bool ative)
        {
            Name = name;
            Ative = ative;
        }
    }
}

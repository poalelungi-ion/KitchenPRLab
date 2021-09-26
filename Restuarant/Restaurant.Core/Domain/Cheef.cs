using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Domain
{
    public class Cheef : Entity
    {
        public string Name { get; set; }
        public CheefLevel CheefLevel { get; set; }
        public int Proficiency { get; set; }
        public string CatchPhrase { get; set; }
    }
}

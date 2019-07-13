using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTimeOffset Birthday {get; private set; }
        public Pet(DateTimeOffset birthday)
        {
            Birthday = birthday;
        }
        public int Age() => DateTimeOffset.Now.Year - Birthday.Year;
    }
}

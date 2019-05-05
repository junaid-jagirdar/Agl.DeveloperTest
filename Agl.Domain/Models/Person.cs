using System;
using System.Collections.Generic;

namespace Agl.Domain.Models

{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}

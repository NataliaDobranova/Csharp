using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat
    {
      public string name;
      public float age;
      public BreedEnum Breed;

        public Cat(string name, float age, BreedEnum breed = BreedEnum.Brit)
        {
            this.name = name;
            this.age = age;
            this.Breed = breed;
           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.name);
            sb.AppendLine(this.age.ToString());
            sb.AppendLine(this.Breed.ToString());

            return sb.ToString();
        }
    }
}

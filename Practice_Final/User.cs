using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Final
{
    public class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public User(string name, int age) 
        { 
            Name = name == string.Empty ? "Human" : name;
            Age = (int) MathF.Abs(age);
        }

        public void IncreaseAge()
        {
            Age++;
        }
    }
}

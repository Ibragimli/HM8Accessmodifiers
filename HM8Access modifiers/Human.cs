using System;
using System.Collections.Generic;
using System.Text;

namespace HM8Access_modifiers
{
    class Human
    {
        public Human(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;

        } 

        public string Name;
        public string Surname;
        public string Gender;

        public virtual string ShowInfo()
        {
            return $"Name:{Name} Surname:{Surname} Gender:{Gender}";
        }
    }

    
}

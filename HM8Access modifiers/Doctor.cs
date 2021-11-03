using System;
using System.Collections.Generic;
using System.Text;

namespace HM8Access_modifiers
{
    class Doctor : Human
    {
        public Doctor(int no, string speacialty, int experience, string name, string surname, string gender) : base(name, surname, gender)
        {
            this.No = no;
            this.Speacialty = speacialty;
            this.Experience = experience;
        }
        public int No;
        public string Speacialty;
        public int Experience;

        public override string ShowInfo()
        {
            base.ShowInfo();
            return ($" No:{No} Name:{Name} Surname:{Surname} Gender:{Gender}  Speacialty:{Speacialty} Experience:{Experience}");
        }



    }
}

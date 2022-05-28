using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_2
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
       

        public override string ToString() => $@"
           Name       : {Name}
           Surname    : {Surname}  
           Email      : {Email}
           Phone number : {PhoneNumber}
           Date of bitrh : {DateOfBirth}";
    }

}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        [DisallowNull]
        public string Name { get; set; }
        [DisallowNull]
        public string Nrc { get; set; }
        [DisallowNull]
        public string Email { get; set; }
        public string Major { get; set; }
        public string Dob { get; set; }
    }
}

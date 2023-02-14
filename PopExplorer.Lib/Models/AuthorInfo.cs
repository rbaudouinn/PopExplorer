using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Models
{
    public class AuthorInfo
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }

        public string FullName { get => $"{Name} {LastName}"; }

        public AuthorInfo(string name, string lastName, string email, string cellphone)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Cellphone = cellphone;
        }

        public AuthorInfo()
        {
            Name = "";
            LastName = "";
            Email = "";
            Cellphone = "";
        }

    }
}

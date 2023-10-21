using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Classes
{
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string JobDescription { get; set; }
        public double HourRate { get; set; }
        public User(string id, string password, string company, string name, string fName,string jobdescription,double hourRate)
        {
            Id= id;
            Password= password;
            Company= company;
            Name= name;
            JobDescription= jobdescription;
            FName= fName;
            HourRate = hourRate;
        }
    }
}

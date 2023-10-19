using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Classes
{
    public class Team
    {
        public List<string> Users { get; set; }

        public Team()
        {
            Users = new List<string>();
        }
    }
}

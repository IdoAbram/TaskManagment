using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Classes
{
    public class Project
    {
        public string Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double Budget { get; set; }
        public string TeamId { get; set; }

        public Project(string id, string startDate, string endDate, double budget, string teamId)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Budget = budget;
            TeamId = teamId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Classes
{
    public class Report
    {
        public string Id { get; set; }
        public string ProjectId { get; set; }
        public string TeamId { get; set; }
        public string UserId { get; set; }
        public string Date { get; set; }
        public double Hours { get; set; }

        public Report(string id, string projectId, string teamId, double hours, string date, string userId)
        {
            Id = id;
            ProjectId = projectId;
            TeamId = teamId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }
    }
}

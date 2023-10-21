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
        public string TaskId { get; set; }
        public string UserId { get; set; }
        public string Date { get; set; }
        public double Hours { get; set; }

        public Report(string id, string projectId, string taskId, double hours, string date, string userId)
        {
            Id = id;
            ProjectId = projectId;
            TaskId = taskId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }
    }
}

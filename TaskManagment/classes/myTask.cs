using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Classes
{
    public class myTask
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
        public string TeamId { get; set; }

        public myTask(string id, string description, string projectId, string teamId)
        {
            Id = id;
            Description = description;
            ProjectId = projectId;
            TeamId = teamId;
        }
    }
}

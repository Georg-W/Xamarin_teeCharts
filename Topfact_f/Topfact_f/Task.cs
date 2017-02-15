using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topfact_f
{
    public class Task
    {
        public Task(int id, string title, DateTime startTime, DateTime endTime, string description, int result, int place, int urgency, int type, int projectId)
        {
            this.ID = id;
            this.Title = title;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Description = description;
            this.Result = result;
            this.Place = place;
            this.Urgency = urgency;
            this.Type = type;
            this.ProjectID = projectId;
            this.StressPoints = 0;
        }



        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public int Result { get; set; }
        public int Place { get; set; }
        public int Urgency { get; set; }
        public int Type { get; set; }
        public int ProjectID { get; set; }
        public int StressPoints { get; set; }
}
}

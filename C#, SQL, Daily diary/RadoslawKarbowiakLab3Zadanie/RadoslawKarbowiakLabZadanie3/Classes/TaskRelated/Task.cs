using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLabZadanie3.Classes.TaskRelated
{
    public class Task
    {
        private string description;
        private string importance;
        private Boolean done;

        public Task(string description, string importance, bool done)
        {
            this.description = description;
            this.importance = importance;
            this.done = done;
        }

        public string Description { get { return description; } set { description = value; } }
        public string Importance { get { return importance; } set { importance = value; } }
        public Boolean Done { get { return done; } set { done = value; } }
    }
}

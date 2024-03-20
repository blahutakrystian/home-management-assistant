using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMA.Backend.Core.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsDone { get; private set; }

        public Task(Guid id, string name, string description, bool isDone)
        {
            Id = id;
            Name = name;
            Description = description;
            IsDone = isDone;
        }
    }
}

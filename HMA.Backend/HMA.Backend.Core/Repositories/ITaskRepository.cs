using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = HMA.Backend.Core.Entities.Task;

namespace HMA.Backend.Core.Repositories
{
    public interface ITaskRepository
    {
        Task<Task> GetTaskByIdAsync(Guid id);
    }
}

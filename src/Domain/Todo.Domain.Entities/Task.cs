using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public class Task
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsDone{ get; set; }
    }
}

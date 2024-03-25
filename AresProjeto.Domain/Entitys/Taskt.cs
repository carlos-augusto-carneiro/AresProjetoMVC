using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Domain.Entitys
{
    public class Taskt : EntityBase
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }

        public User User { get; set; } = default!;
        public Guid IdUser { get; set; } = default!;
    }
}

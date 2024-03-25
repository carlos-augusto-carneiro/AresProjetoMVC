using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Domain.Entitys
{
    public class Taskt : EntityBase
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime CurrenteDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User User { get; set; } = default!;
        public User IdUser { get; set; } = default!;
    }
}

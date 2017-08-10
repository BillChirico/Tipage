using System;
using System.Collections.Generic;
using System.Text;

namespace Tipage.Domain.Models
{
    public class Hours
    {
        public int Id { get; set; }

        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tipage.Domain.Models
{
    public class Shift
    {
        public int Id { get; set; }

        public Hours Hours { get; set; }

        public Tips Tips { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagementsystem.Models
{
    public class Assignment
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Subject { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student  { get; set; }

    }
}

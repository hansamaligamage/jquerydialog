using studentmanagementsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagementsystem.ViewModels
{
    public class StudentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }

        public List<Assignment> Assignments { get; set; }

    }
}

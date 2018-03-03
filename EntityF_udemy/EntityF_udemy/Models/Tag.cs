using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityF_udemy.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}

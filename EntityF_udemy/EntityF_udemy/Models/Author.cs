using System.Collections;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityF_udemy.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}

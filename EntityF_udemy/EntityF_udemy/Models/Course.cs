using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityF_udemy.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Titlel { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }

    public enum CourseLevel
    {
        Begginer = 1,
        Middle = 2,
        Advence = 3
    }
}

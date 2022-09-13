using System;

namespace Entity
{
    public class Requirement
    {
        public int id { get; set; }

        public string Name { get; set; }

        public Guid CourseId { get; set; }

        public Course Course { get; set; }
    }
}
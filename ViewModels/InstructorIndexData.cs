using System.Collections.Generic;
using StudentInternalEvaluationSystem.Models;

namespace StudentInternalEvaluationSystem.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}


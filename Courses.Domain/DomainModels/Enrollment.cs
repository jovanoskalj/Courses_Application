﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Domain.DomainModels
{
    public class Enrollment:BaseEntity
    {
      
        public DateTime DateEnrolled { get; set; }
        public Boolean ReEnrolled { get; set; }
        public string? StudentId { get; set; }
        public required Student Student { get; set; }

        public string? CourseId { get; set; }
        public Course? Course { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Domain.DomainModels
{
    public class Lecture:BaseEntity
    {
        
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}

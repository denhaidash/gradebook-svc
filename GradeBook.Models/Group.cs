﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradeBook.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public DateTime EducationStartedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int SpecialityRefId { get; set; }
        [ForeignKey("SpecialityRefId")]
        public virtual Specialty Specialty { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
        public virtual IEnumerable<Semester> Semesters { get; set; }
    }
}
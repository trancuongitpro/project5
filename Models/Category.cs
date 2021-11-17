using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace project5.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}

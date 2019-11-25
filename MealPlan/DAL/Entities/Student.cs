using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlan.DAL.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}

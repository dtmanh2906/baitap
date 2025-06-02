using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC_DinhTienManh_22103100308.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime BrithDate { get; set; }

        public ICollection<Result>? Results { get; set; }

        [NotMapped]
        public float AverageScore => Results?.Any() == true ? Results.Average(r => r.Score) : 0;
    }
}
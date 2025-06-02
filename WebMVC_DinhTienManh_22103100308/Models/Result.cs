using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC_DinhTienManh_22103100308.Models
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }

        [Required]
       
        public int StudentID { get; set; }

        [ForeignKey("StudentID")]
       
        public Student? Student { get; set; }

        [Required, MaxLength(50)]
        public string Subject { get; set; }
        

        [Required, Range(0, 10)]
        public float Score { get; set; }
    }
}
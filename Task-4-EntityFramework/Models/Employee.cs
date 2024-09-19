using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_4_EntityFramework.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        [Required]
        public string Employee_Name { get; set; }
       
        [Required]
         [Column(TypeName ="decimal(18,2)")]
         public decimal Employee_Sal {  get; set; }
        [Required]
        public DateTime Joining { get; set; }
    }
}

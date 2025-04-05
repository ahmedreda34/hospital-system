using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCrudOperation.Models
{
    [Table("Employees",Schema ="HR")]
    public class Employee
    {
        [Key]
        [Display(Name ="ID")]
        public int EmployeeID { get; set; }
        [Display(Name ="Name")]
        [Column(TypeName = "varchar(250)")]

        public string EmployeeName { get; set; } = string.Empty;

        [Display(Name ="Image user")]
        [Column(TypeName="varchar(250)")]
        public string? ImageUser { get; set; }

        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Display(Name ="Salary")]
        [Column(TypeName = "decimal(12,2)")]

        public decimal Salary { get; set; }


        [Display(Name ="HiringDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MMMM-YYYY}")]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name ="National ID")]
        [MaxLength(14)]
        [MinLength(14)]
        [Column(TypeName =("varchar(14)"))]
        public string NationalID { get; set; }

        [Display(Name = "Department")]

        public int DepartmentID { get; set; }
        [Display(Name = "Department")]


        [ForeignKey("DepartmentID")]
        public Department? Department { get; set; }
    }
}

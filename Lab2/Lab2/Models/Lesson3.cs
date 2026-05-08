using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;
public class Lesson3
{
    [Display(Name = "Serial No")]
    public Byte EmployeeId { get; set; }
    [Display(Name ="Name")]
    public string EmployeeName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

}
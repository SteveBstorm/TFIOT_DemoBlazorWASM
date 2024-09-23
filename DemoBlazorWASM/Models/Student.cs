using System.ComponentModel.DataAnnotations;

namespace DemoBlazorWASM.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "C'est ici qu'on change les messages ! ")]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

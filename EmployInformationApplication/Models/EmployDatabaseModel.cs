using System.ComponentModel.DataAnnotations;

namespace EmployInformationApplication.Models
{
    public class EmployDatabaseModel
    {
        [Required]   
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string District { get; set; }
        public string Departmaent { get; set; }

        public string phonumber { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddCustomerForm
    {
        public int Id { get; set; }
        [Range (0,1000)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
    }
}

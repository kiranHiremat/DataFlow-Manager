using System.ComponentModel.DataAnnotations;

namespace WebApplication4TRY.Models
{
    public class Store
    {
        [Key]

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}

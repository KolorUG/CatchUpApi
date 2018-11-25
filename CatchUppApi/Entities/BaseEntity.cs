using System.ComponentModel.DataAnnotations;

namespace CatchUppApi.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id {get; set;}
    }
}
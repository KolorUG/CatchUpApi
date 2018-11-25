using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CatchUppApi.Models;

namespace CatchUppApi.Entities
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Description { get; set; }
        
        public ICollection<Offer> Offers { get; set; } = new List<Offer>(); 
    }
}
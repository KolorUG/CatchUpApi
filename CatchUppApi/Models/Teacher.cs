using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUppApi.Models
{
    public class Teacher : BaseEntity
    {
        public Teacher()
        {
            Offers = new List<Offer>();
            Ratings = new List<Rating>();
            Schedules = new List<Schedule>();
        }
        [ForeignKey("AddressId")]
        public Address Address {get; set;}
        public int AddressId {get;set ;}
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Description { get; set; }
        
        public ICollection<Offer> Offers { get; set; } 
        public ICollection<Rating> Ratings {get; set;}
        public ICollection<Schedule> Schedules {get; set;}
    }
}
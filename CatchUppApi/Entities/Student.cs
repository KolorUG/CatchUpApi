using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CatchUppApi.Models
{
    public class Student : BaseEntity
    {
        public Student()
        {
            Ratings = new List<Rating>();
        }
        [ForeignKey("AddressId")]
        public Address Address {get; set;}
        public int AddressId {get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Rating> Ratings {get; set;}
        public ICollection<Order> Orders {get; set;}

        
    }
}
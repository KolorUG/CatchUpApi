using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CatchUppApi.Models
{
    public class Order : BaseEntity
    {
        [ForeignKey("StudentId")]
        public Student Student {get; set;}
        public int StudentId {get; set;}
        [ForeignKey("TeacherId")]
        public Teacher Teacher {get; set;}
        public int TeacherId {get; set;}
        public DateTime Date {get; set;}
        [ForeignKey("OfferId")]
        public Offer Offer {get; set;}
        public int OfferId {get; set;}
        public String Role {get; set;}
        public bool Confirmed {get; set;}

    }
}
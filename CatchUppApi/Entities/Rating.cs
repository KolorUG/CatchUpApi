using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUppApi.Models
{
    public class Rating : BaseEntity
    {
        [ForeignKey("OrderId")]        
        public int OrderId {get; set;}
        public String Role {get; set;}
        public short Rate {get; set;}
        [ForeignKey("StudentId")]
        public Student Student {get; set;}
        public int StudentId {get; set;}
        [ForeignKey("TeacherId")]
        public Teacher Teacher {get; set;}
        public int TeacherId {get; set;}
    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CatchUppApi.Models
{
    public class User :BaseEntity
    {
        public string Login {get; set;}
        public string Password {get; set;}
        [ForeignKey("StudentId")]
        public Student Student {get; set;}
        public int? StudentId {get; set;}
        [ForeignKey("TeacherId")]
        public Teacher Teacher {get; set;}
        public int? TeacherId {get; set;}
    }
}
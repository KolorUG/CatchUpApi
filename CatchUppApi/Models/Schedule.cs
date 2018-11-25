using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUppApi.Models
{
    public class Schedule : BaseEntity
    {
        [ForeignKey("TeacherId")]
        public Teacher Teacher {get; set;}
        public int TeacherId {get; set;}  
        public short Day {get; set;}
        public String Begining {get; set;}
        public String Ending {get; set;} 
    }
}
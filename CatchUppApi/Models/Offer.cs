using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUppApi.Models
{
    public class Offer : BaseEntity
    {
        public String Subject {get; set;}
        public String Level {get; set;}
        public decimal Cost {get; set;}
        public int TimeMinutes {get;set;}
        public bool HomeVisit { get; set; }
        public double VisitRange { get; set; }
    }
}
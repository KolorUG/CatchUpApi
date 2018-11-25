using System;
using System.ComponentModel.DataAnnotations;

namespace CatchUppApi.Models
{
    public class Address : BaseEntity
    {
        public String City {get; set;}
        public String PostalCode{get; set;}
        public String Street {get; set;}
        public String Number {get; set;}
        public String Flat {get; set;}
        public double Latitiude {get; set;}
        public double Longtitude {get; set;}

    }
}
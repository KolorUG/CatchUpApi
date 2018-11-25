using System.Collections.Generic;

namespace CatchUppApi.Models
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Description { get; set; }
        
        public ICollection<OfferDto> Offers { get; set; } = new List<OfferDto>(); 
    }
}
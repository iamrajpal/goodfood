using System;

namespace Domain.Entities
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SlugUrl { get; set; } 
        public string Amount { get; set; }
        
    }
}
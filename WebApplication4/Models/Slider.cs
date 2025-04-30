using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Models
{
    public class Slider : BaseEnitity
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}

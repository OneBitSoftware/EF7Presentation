using System;

namespace EF.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Guid CityCode { get; set; }

        public Country Country { get; set; }
    }
}
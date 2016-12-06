using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances.Models
{
    public class RentalModel
    {
        public RentalModel()
        {

        }

        public RentalModel(int _id,string _name, string _country, double _price, int _bookings, List<string> _address, Dictionary<string,bool> _rentalrules, string _season, byte _rooms, string _description, List<string> _tags,  string _imagepath, string _thumbnailpath)

        {
            Id = _id;
            Name = _name;
            Country = _country;
            Price = _price;
            Bookings = _bookings;
            Address = _address;
            RentalRules = _rentalrules;
            Season = _season;
            Rooms = _rooms;
            Description = _description;
            Tags = _tags;
            ImagePath = _imagepath;
            ThumbnailPath = _thumbnailpath;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public int Bookings { get; set; }

        public List<string> Address { get; set; }

        public Dictionary<string, bool> RentalRules { get; set; } //smoking, pets, internet...
        public string Season { get; set; }
        public byte Rooms { get; set; }
        public string Description { get; set; }
        List<string> Tags { get; set; }

        public string ImagePath { get; set; }
        public string ThumbnailPath { get; set; }

    }
}

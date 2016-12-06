using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances.Models
{
        public class User
        {
            public int Token { get; set; }
            public string Username { get; set; }  
            public bool IsAdmin { get; set; }
            public string Password { get; set; }      
        }
}
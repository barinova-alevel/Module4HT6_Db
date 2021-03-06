using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
   public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string InstagramUrl { get; set; }
    }
}

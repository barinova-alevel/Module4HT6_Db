using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Song> songs { get; set; } = new List<Song>();
    }
}

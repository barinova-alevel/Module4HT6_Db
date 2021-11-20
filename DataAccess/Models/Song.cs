using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Duration { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}

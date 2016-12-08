using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStar
{
    public class Album
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public List<Song> Songs { get; set; }
    }
}

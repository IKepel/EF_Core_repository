using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_repository
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsAdult { get; set; }
    }
}
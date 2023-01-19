using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.ViewModels
{
    public class MovieFormViewModel
    {
        public List<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public bool IsEdit { get; set; } 
    }
}
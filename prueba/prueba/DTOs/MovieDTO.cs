using prueba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace prueba.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }


        public DateTime ReleaseDate { get; set; }


        public int NumberInStock { get; set; }
    }
}
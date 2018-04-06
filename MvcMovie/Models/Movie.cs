using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name ="Release Date")] // The Display attribute specifies what to display for the name of a field (in this case "Release Date" instead of "ReleaseDate").
        [DataType(DataType.Date)] //The DataType attribute specifies the type of the data, in this case it's a date, so the time information stored in the field is not displayed. 
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)] // The DisplayFormat attribute is needed for a bug in the Chrome browser that renders date formats incorrectly.
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }


}
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MoviesList.Models
{
    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; } 
        [Column("moviename")]
        public string MovieName { get; set; }
        [Column("genre")]
        public string Genere { get; set; }
        [Column("releaseyear")]
        public string Year { get; set; }
        [Column("producer")]
        public string Producer { get; set; }
    }
}

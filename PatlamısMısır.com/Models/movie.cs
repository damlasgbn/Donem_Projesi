using System.ComponentModel.DataAnnotations;
namespace PatlamısMısır.com.Models
{
    public class movie
    {
        public int Id { get; set; } //sınıf,birincil anahtar için veritabanı tarafından gerekli olan bir alan içerir. 
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }


    }
}

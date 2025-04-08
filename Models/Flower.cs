using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFCE.Models {
/* The Flower class represents a table in a database with properties for Id, Name,
Url, and Price. */
    [Table("Flower")]
    public class Flower {
        [Key] //Identificando como chave primária
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
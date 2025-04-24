using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        

        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
 

        [Column("Autor")]
        [Display(Name = "Autor")]
        public string Autor { get; set; }


        [Column("Data de Publicação")]
        [Display(Name = "Data de Publicação")]
        public int AnoPublicacao { get; set; }

    }
}

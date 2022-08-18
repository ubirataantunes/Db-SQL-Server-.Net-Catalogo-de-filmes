using System.ComponentModel.DataAnnotations;

namespace CatalogoFilmes.Models
{
    public class Filme
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O preenchimento campo do Título do filme é obrigatório", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 1)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O preenchimento do Ano é obrigatório", AllowEmptyStrings = false)]
        public int Ano { get; set; }
        [Required(ErrorMessage = "O preenchimento do campo Diretor é obrigatório", AllowEmptyStrings = false)]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O preenchimento do campo Elenco do título é obrigatório", AllowEmptyStrings = false)]
        public string Elenco { get; set; } 
        
    }
}

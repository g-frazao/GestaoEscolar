using System.ComponentModel.DataAnnotations;

namespace GestaoEscolar.Models
{
    public class Instituicao
    {
        [Key]

        public long? InstituicaoID { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Telefone { get; set; }

        [Required]
        public String Endereco { get; set; }

        [Required]
        public String Cep { get; set; }

        [Required]
        public String Sexo { get; set; }

        [Required]
        public int Idade { get; set; }


    }
}

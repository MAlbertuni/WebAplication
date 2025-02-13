using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [PrimaryKey(nameof(Id))]
    public class Pessoa
    {
        /// <summary>
        /// Id de registro
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da pessoa
        /// </summary>
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public required string Nome { get; set; }

        /// <summary>
        /// Sobrenome da pessoa
        /// </summary>
        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        public required string Sobrenome { get; set; }

        /// <summary>
        /// E-mail da pessoa
        /// </summary>
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email não é válido.")]
        public required string Email { get; set; }

        /// <summary>
        /// Data de nascimento da Pessoa
        /// </summary>
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api_Ubicua.Models
{
    public class Usuario
    {
        // Adiciona o atributo Key para indicar que é a chave primária
        // e o atributo DatabaseGenerated para indicar que o valor será gerado automaticamente
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        // Constructor para gerar automaticamente o ID ao criar uma nova instância de Usuario
        public Usuario()
        {
            Id = Guid.NewGuid().ToString(); // Gera um novo Guid e converte para string
        }
    }
}

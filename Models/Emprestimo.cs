using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string NomeUsuario { get; set; }
        public string Telefone { get; set; }
        public bool Devolvido { get; set; }
        
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}
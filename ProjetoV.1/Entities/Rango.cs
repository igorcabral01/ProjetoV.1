﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProjetcOne.Entitis
{
    public class Rango
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Nome { get; set; }

        public ICollection<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();

        public Rango() { }

        [SetsRequiredMembers]
        public Rango(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}

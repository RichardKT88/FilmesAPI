﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="O gênero deve ter no máximo 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1,600,ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos.")]
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
        [JsonIgnore]
        public virtual List<Sessao> Sessoes { get; set; }
    }
}

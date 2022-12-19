using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage ="Titulo obrigatório!")]
    [MaxLength(18, ErrorMessage = "Tamanho máximo: 18 caracteres!")]
    public string Titulo { get; set; }

    [Required(ErrorMessage ="Genero é obrigatório!")]
    [StringLength(50, ErrorMessage = "Tamanho máximo: 50 caracteres!")]
    public string Genero { get; set; }

    [Required(ErrorMessage ="Campo obrigatório")]
    [Range(70, 600, ErrorMessage = "Duração deve ter no minimo 70 minutos e no maximo 600.")]
    public int Duracao { get; set; }
}
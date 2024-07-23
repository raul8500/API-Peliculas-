﻿using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CategoriaDTO
    {

        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es obligatorio")]
        [MaxLength (100, ErrorMessage = "El numero maximo de caracteres es 100")]
        public string NombreCategoria { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}

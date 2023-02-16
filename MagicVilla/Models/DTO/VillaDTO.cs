using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaDTO
    {
        internal string? name;
        public int Id {get;set;}
        [Required]
        [MaxLength(30)]
        public string? Name {get;set;}
    }
}
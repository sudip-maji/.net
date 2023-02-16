using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        internal string? name;

        public int Id {get;set;}
        public string? Name {get;set;}
        public DateTime CreatedDate { get; set; }
    }
}
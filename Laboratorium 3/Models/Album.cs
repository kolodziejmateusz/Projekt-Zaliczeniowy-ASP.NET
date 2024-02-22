using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Album
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj nazwe albumu.")]
        [MaxLength(100, ErrorMessage = "Nazwa albumu jest za długa"), MinLength(3, ErrorMessage = "Nazwa albumu jest za któtka.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj nazwe zespołu.")]
        [MaxLength(100, ErrorMessage = "Nazwa zespołu jest za długa"), MinLength(3, ErrorMessage = "Nazwa zespołu jest za któtka.")]
        public string Band { get; set; }
        public List<string>? TrackList { get; set; }
        [Required(ErrorMessage = "Podaj date wydania.")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Podaj czas trwania.")]
        public TimeSpan Duration { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("albums")]
    public class AlbumEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Band { get; set; }
        public string? TrackList { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [MaxLength(10)]
        public string Duration { get; set; }
        public Popularity Popularity { get; set; }
        public DateTime Created { get; set; }
        public int RecordLabelId { get; set; }
        public RecordLabelEntity? RecordLabel { get; set; }
    }

    public enum Popularity
    {
        [Display(Name = "Niska")] Low = 1,
        [Display(Name = "Umiarkowane")] Moderate = 2,
        [Display(Name = "Wysokie")] High = 3,
        [Display(Name = "Lista przebojów!")] TopChart = 4
    }
}

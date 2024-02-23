using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4.Models
{
    public enum Popularity
    {
        [Display(Name = "Niska")]Low = 1,
        [Display(Name = "Umiarkowane")]Moderate = 2,
        [Display(Name = "Wysokie")]High = 3,
        [Display(Name = "Lista przebojów!")]TopChart = 4
    }

}

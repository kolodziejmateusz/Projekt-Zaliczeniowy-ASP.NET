namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age(DateTime DateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }

        public bool IsValid()
        {
            return Name != null && DateOfBirth < DateTime.Today;
        }
    }
}

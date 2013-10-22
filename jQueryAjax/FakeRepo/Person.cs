using System.ComponentModel.DataAnnotations;

namespace jQueryAjax.FakeRepo
{
    public class Person
    {
        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter a hair color")]
        public string HairColor { get; set; }
        [Required(ErrorMessage = "Please enter an eye color")]
        public string EyeColor { get; set; }
        [Required(ErrorMessage = "Please enter a height")]
        public string Height { get; set; }
        [Required(ErrorMessage = "Please enter a hometown")]
        public string Hometown { get; set; }
    }
}
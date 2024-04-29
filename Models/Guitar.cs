using System.ComponentModel.DataAnnotations;

namespace CIT_195_Lesson_11_Guitar_Collection.Models
{
    public class Guitar
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly Year { get; set; }

        [RegularExpression(@"^[A-Za-z\s][A-Za-z0-9\s!@#$%^&*()-_=+`~']*")]
        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[0-9]+$")]

        public int NumStrings { get; set; }

        [RegularExpression(@"^[A-Za-z\s][A-Za-z0-9\s!@#$%^&*()-_=+`~']*")]
        [Required]
        [StringLength(50)]
        public string BodyStyle { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Za-z\s][A-Za-z0-9\s!@#$%^&*()-_=+`~']*")]
        [Required]
        [StringLength(50)]
        public string BodyColor { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Za-z\s][A-Za-z0-9\s!@#$%^&*()-_=+`~']*")]
        [Required]
        [StringLength(50)]
        public string Neck {  get; set; } = string.Empty;

        [RegularExpression(@"^[0-9]+$")]
        public int? NumFrets { get; set; }
        public bool Active { get; set; }

    }
}

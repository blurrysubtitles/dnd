using System.ComponentModel.DataAnnotations;

namespace RpgMe.Dnd.Models
{
    public class Spell
    {
        public int Id { get; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

		[Range(0, 9, ErrorMessage = "Level must be between 0 (cantrip) and 9")]
		public int Level { get; set; }
    }
}

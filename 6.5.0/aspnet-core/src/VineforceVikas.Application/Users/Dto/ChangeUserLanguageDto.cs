using System.ComponentModel.DataAnnotations;

namespace VineforceVikas.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
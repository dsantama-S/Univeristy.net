using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum NivelCurso
    {
        Basico,
        Intermedio,
        Avanzado
    }
    public class Curso : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDesc { get; set; } = string.Empty;

        [Required]
        public string LongDesc { get; set; } = string.Empty;

        [Required]
        public string Public { get; set; } = string.Empty;
        [Required]
        public string Objectives { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public NivelCurso Level { get; set; } = NivelCurso.Basico;
    }
}

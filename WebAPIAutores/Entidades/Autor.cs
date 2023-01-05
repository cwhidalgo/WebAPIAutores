using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Entidades
{
    public class Autor : IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} es requerido")]
        [StringLength(maximumLength: 4, ErrorMessage = "El campo {0} no debe de tener mas de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        [Range(18, 120)]
        [NotMapped]
        public int Edad { get; set; }
        /*Valida */
        [CreditCard]
        [NotMapped]
        public string TarjetaCredito { get; set; }

        [Url]
        [NotMapped]
        public string URL { get; set; }
        public List<Libro> Libros { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}

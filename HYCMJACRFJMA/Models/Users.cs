using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HYCMJACRFJMA.Models
{
    public class  Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido de usuario es requerido.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email de usuario es requerido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 100 caracteres.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "El estatus  es requerido.")]
        public byte Estatus { get; set; }
        [Required(ErrorMessage = "El Rol de usuario es requerido.")]
        public string Rol { get; set; }

        [NotMapped] // Esta propiedad no será mapeada a la base de datos
        [Compare("Password", ErrorMessage = "La confirmación de contraseña no coincide.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 100 caracteres.")]
        [DataType(DataType.Password)]
        public string ConfirmarPassword { get; set; }
        [NotMapped]
        public int Take { get; set; }
    }
}

using Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        public string Cpf { get; set; }
        [Column("USR_Tipo")]
        public TipoUsuario? Tipo { get; set; }
    }
}

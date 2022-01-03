using Microsoft.AspNetCore.Identity;
using PoloPark.Shared.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoloPark.Server.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        public TipoConta TipoConta { get; set; }
    }
}

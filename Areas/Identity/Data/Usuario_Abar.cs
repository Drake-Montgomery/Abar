using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Abar.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Usuario_Abar class
public class Usuario_Abar : IdentityUser
{
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? Nome { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? Sobrenome { get; set; }
}


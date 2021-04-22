using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudApi.Models
{
    [MetadataType(typeof(Tb_PersonasFisicas.MetaData))]
    public partial class Tb_PersonasFisicas
    {
        sealed class MetaData
        {
            [Required]
            public Nullable<System.DateTime> FechaRegistro;
            [Required]
            public Nullable<System.DateTime> FechaActualizacion;
            [Required]
            public string Nombre;
            [Required]
            public string ApellidoPaterno;
            [Required]
            public string ApellidoMaterno;
            [Required]
            public string RFC;
            [Required]
            public Nullable<System.DateTime> FechaNacimiento;
            [Required]
            public Nullable<int> UsuarioAgrega;
            [Required]
            public Nullable<bool> Activo;
        }
    }
}
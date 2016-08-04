using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }

    public class MedicoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o CRM")]
        public string CRM { get; set; }        
    }
}
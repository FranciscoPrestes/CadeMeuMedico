//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadeMeuMedico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cidades
    {
        public Cidades()
        {
            this.Medicos = new HashSet<Medicos>();
        }
    
        public int IDCidade { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MimAcher.Infra
{
    using System;
    using System.Collections.Generic;
    
    public partial class MA_ALUNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA_ALUNO()
        {
            this.MA_ALUNO_APRENDER = new HashSet<MA_ALUNO_APRENDER>();
            this.MA_ALUNO_ENSINAR = new HashSet<MA_ALUNO_ENSINAR>();
            this.MA_ALUNO_GOSTO = new HashSet<MA_ALUNO_GOSTO>();
        }
    
        public int cod_al { get; set; }
        public int cod_us { get; set; }
        public string nome { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public int telefone { get; set; }
        public string e_mail { get; set; }
        public System.Data.Entity.Spatial.DbGeography geolocalizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA_ALUNO_APRENDER> MA_ALUNO_APRENDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA_ALUNO_ENSINAR> MA_ALUNO_ENSINAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA_ALUNO_GOSTO> MA_ALUNO_GOSTO { get; set; }
        public virtual MA_USUARIO MA_USUARIO { get; set; }
    }
}
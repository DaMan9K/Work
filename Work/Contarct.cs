//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Work
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contarct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contarct()
        {
            this.Archive = new HashSet<Archive>();
        }
    
        public int IdContract { get; set; }
        public int IdClients { get; set; }
        public int IdWorker { get; set; }
        public double CreditAmount { get; set; }
        public int InterestOnALoan { get; set; }
        public string DueDate { get; set; }
        public System.DateTime AgreementDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Archive> Archive { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Mouths Mouths { get; set; }
        public virtual Workers Workers { get; set; }
    }
}

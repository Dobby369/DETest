//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DE2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klient_Servic
    {
        public int klient_servic_id { get; set; }
        public int klient_id { get; set; }
        public int servic_id { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Servic Servic { get; set; }
    }
}

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
    
    public partial class Sotrudnik
    {
        public int sotrudnik_id { get; set; }
        public string familia { get; set; }
        public string imya { get; set; }
        public string otchestvo { get; set; }
        public string zarplata { get; set; }
        public int polsovatel_id { get; set; }
    
        public virtual Polsovatel Polsovatel { get; set; }
    }
}
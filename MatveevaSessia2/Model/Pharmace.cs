//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatveevaSessia2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pharmace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ProductId { get; set; }
        public int ReportId { get; set; }
        public int UserId { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Report Report { get; set; }
        public virtual User User { get; set; }
    }
}

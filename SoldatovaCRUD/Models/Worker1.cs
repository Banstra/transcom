//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoldatovaCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker1
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public int Entry { get; set; }
        public string Picture { get; set; }
    
        public virtual EntryType EntryType { get; set; }
        public virtual Role1 Role { get; set; }
    }
}

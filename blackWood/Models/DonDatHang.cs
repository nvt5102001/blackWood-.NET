//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blackWood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonDatHang()
        {
            this.ChiTietDDHs = new HashSet<ChiTietDDH>();
        }
    
        public string SoHD { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public string NoiNhan { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<double> Total { get; set; }
        public string NameKH { get; set; }
        public string EmailKH { get; set; }
        public string SdtKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDDH> ChiTietDDHs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}

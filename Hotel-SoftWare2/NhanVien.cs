
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Hotel_SoftWare2
{

using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NhanVien
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhanVien()
    {

        this.PhieuThuePhongs = new HashSet<PhieuThuePhong>();

    }


    public string MaNV { get; set; }

    public string TenTk { get; set; }

    public string MatKhau { get; set; }

    public Nullable<bool> Quyen { get; set; }

    public string HoTen { get; set; }

    public Nullable<System.DateTime> NgaySinh { get; set; }

    public string SDT { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; }

}
    public partial class NhanVien
    {
        public List<NhanVien> getPass()
        {
            htEntities context = new htEntities();
            return context.NhanViens.ToList();
        }
    }
}

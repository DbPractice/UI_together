
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
    
public partial class Phong
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Phong()
    {

        this.ChiTietPhieuThues = new HashSet<ChiTietPhieuThue>();

    }


    public string MaPhong { get; set; }

    public string TenPhong { get; set; }

    public Nullable<byte> TinhTrang { get; set; }

    public Nullable<int> DienTich { get; set; }

    public Nullable<double> GiaThue { get; set; }

    public string MaLoai { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ChiTietPhieuThue> ChiTietPhieuThues { get; set; }

    public virtual LoaiPhong LoaiPhong { get; set; }

}

}

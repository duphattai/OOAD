//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeXePhuongTrang.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPhieuDatCho
    {
        public tblPhieuDatCho()
        {
            this.tblChiTietPhieuDatChoes = new HashSet<tblChiTietPhieuDatCho>();
            this.tblChiTietTrungChuyens = new HashSet<tblChiTietTrungChuyen>();
        }
    
        public int MaPhieu { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> DienThoai { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public string TrungChuyen { get; set; }
    
        public virtual ICollection<tblChiTietPhieuDatCho> tblChiTietPhieuDatChoes { get; set; }
        public virtual ICollection<tblChiTietTrungChuyen> tblChiTietTrungChuyens { get; set; }
    }
}

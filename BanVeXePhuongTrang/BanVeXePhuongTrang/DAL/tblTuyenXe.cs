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
    
    public partial class tblTuyenXe
    {
        public tblTuyenXe()
        {
            this.tblChiTietTuyens = new HashSet<tblChiTietTuyen>();
            this.tblXeKhaches = new HashSet<tblXeKhach>();
        }
    
        public string MaTuyen { get; set; }
        public string MaBenXeDi { get; set; }
        public string MaBenXeDen { get; set; }
    
        public virtual tblBenXe tblBenXe { get; set; }
        public virtual tblBenXe tblBenXe1 { get; set; }
        public virtual ICollection<tblChiTietTuyen> tblChiTietTuyens { get; set; }
        public virtual ICollection<tblXeKhach> tblXeKhaches { get; set; }
    }
}
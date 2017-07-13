using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpDeliveryReports
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public int TargetIndex { get; set; }
        public string MaTuyenPhat { get; set; }
        public string MaBuuTa { get; set; }
        public int? SoLuong { get; set; }
        public double? KhoiLuong { get; set; }
        public double? TienThuHo { get; set; }
        public int? SoLuongPhatThanhCong { get; set; }
        public int? SoLuongPhatKhongThanhCong { get; set; }
        public int? SoLuongChuaPhat { get; set; }
        public int? SoLuongChuyenHoan { get; set; }
        public int? SoLuongChuyenTiep { get; set; }
        public int? SoLuongVoThuaNhan { get; set; }
        public string UserName { get; set; }
        public string Machinename { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}

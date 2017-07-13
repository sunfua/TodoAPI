using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpAcceptanceDetailReport
    {
        public int TargetIndex { get; set; }
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public string ItemCode { get; set; }
        public string DonViPhat { get; set; }
        public string ItemTypeCode { get; set; }
        public string CustomerCode { get; set; }
        public bool? IsHcc { get; set; }
        public string ValueAddedServicesCode { get; set; }
        public bool? IsDomestic { get; set; }
        public string ServiceCode { get; set; }
        public int? KhoiLuongThuc { get; set; }
        public int? KhoiLuongQuyDoi { get; set; }
        public int? CuocChinh { get; set; }
        public int? CuocGtgt { get; set; }
        public int? CuocThuHoChiHo { get; set; }
        public int? ThueVat { get; set; }
        public int? TongTienMat { get; set; }
        public int? TongGhiNo { get; set; }
        public int? CuocThuNguoiNhan { get; set; }
        public int? SoTienThuHo { get; set; }
        public int? CuocChinhCongBo { get; set; }
        public int? CuocGtgtcongBo { get; set; }
        public int? GiaVonCuocChinh { get; set; }
        public int? GiaVonCuocGtgt { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string ContractNumber { get; set; }
        public string ToPoscode { get; set; }
        public string AcceptancePoscode { get; set; }
        public bool? IsCod { get; set; }
        public DateTime? SendingTime { get; set; }
        public bool? IsDebt { get; set; }
        public string AcceptanceUser { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}

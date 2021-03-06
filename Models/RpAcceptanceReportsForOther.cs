﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpAcceptanceReportsForOther
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public int TargetIndex { get; set; }
        public string AcceptancePoscode { get; set; }
        public int Status { get; set; }
        public int? SoLuong { get; set; }
        public double? KhoiLuong { get; set; }
        public double? TienMat { get; set; }
        public double? No { get; set; }
        public double? VattienMat { get; set; }
        public double? Vatno { get; set; }
        public string UserName { get; set; }
        public string Machinename { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? CuocChinh { get; set; }
        public double? CuocVat { get; set; }
        public double? CuocGtgt { get; set; }
        public double? TongCuoc { get; set; }
        public double? SoLuongNo { get; set; }
        public double? KhoiLuongNo { get; set; }
        public double? CuocThuChiHo { get; set; }
        public double? CuocThuNguoiNhan { get; set; }
        public double? TienThuHo { get; set; }
        public double? KhoiLuongQuyDoi { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}

namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DemoLoginInfo
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string LoginIp { get; set; }

        [StringLength(50)]
        public string Mac { get; set; }

        [StringLength(10)]
        public string CreateTime { get; set; }

        public bool? IsDelete { get; set; }
    }
}

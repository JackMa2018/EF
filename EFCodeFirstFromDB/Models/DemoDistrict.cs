namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("demo_district")]
    public partial class DemoDistrict
    {
        //[Column("id")]
        public int Id { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }
        [Column("is_delete")]
        public bool? IsDelete { get; set; }
        [Column("create_time")]
        public DateTime? CreateTime { get; set; }
    }
}

namespace EFCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DBConnectionString")
        {
        }

        public virtual DbSet<DemoDistrict> DemoDistrict { get; set; }
        public virtual DbSet<DemoLoginInfo> DemoLoginInfo { get; set; }
        public virtual DbSet<DemoUser> DemoUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemoLoginInfo>().ToTable("demo_login_info")
                .Property(c => c.Id).HasColumnName("id");
            modelBuilder.Entity<DemoLoginInfo>().Property(c => c.CreateTime).HasColumnName("create_time");
            modelBuilder.Entity<DemoLoginInfo>().Property(c => c.IsDelete).HasColumnName("is_delete");
            modelBuilder.Entity<DemoLoginInfo>().Property(c => c.LoginIp).HasColumnName("login_ip");
            modelBuilder.Entity<DemoLoginInfo>().Property(c => c.UserId).HasColumnName("user_id");


            modelBuilder.Configurations.Add(new DemoUserMapping()) ;
        }
    }
}

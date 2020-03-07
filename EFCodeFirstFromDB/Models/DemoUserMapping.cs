using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstFromDB
{
    public class DemoUserMapping:EntityTypeConfiguration<DemoUser>
    {
        public DemoUserMapping()
        {
            this.ToTable("demo_user");
            this.Property(c => c.IsDelete).HasColumnName("is_delete");
            this.Property(c => c.LoginName).HasColumnName("login_name");
            this.Property(c => c.Mobile).HasColumnName("mobile");
            this.Property(c => c.UpdateTime).HasColumnName("update_time");
            this.Property(c => c.UserName).HasColumnName("user_name");
            this.Property(c => c.DepartId).HasColumnName("depart_id");
            this.Property(c => c.CreateTime).HasColumnName("create_time");
        }
    }
}

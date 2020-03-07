using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstFromDB
{
    public class EFQueryTest
    {
        public void Show()
        {
            {
                using (var db = new DemoDbContext())
                {
                    //in查询
                    var users= db.DemoUser.Where(u => new int[] { 1, 2, 8, 9 }.Contains(u.Id)).ToList();

                    var users2 = from u in db.DemoUser
                                 where new int[] { 1, 2, 8, 9 }.Contains(u.Id)
                                 select u;

                    //多表查询(ulTab其实就是db.DemoLoginInfo符合的数据)
                    var listItem = from u in db.DemoUser
                                   join l in db.DemoLoginInfo on u.Id equals l.UserId
                                   into ulTab
                                   from ul in ulTab.DefaultIfEmpty()
                                   select ul;
                    var items = listItem.ToList();

                    //执行sql语句
                    DbContextTransaction trans = null;
                    try
                    {
                        trans = db.Database.BeginTransaction();
                        string sql = "select id,user_name username,login_name loginname,password,mobile,email,is_delete IsDelete,create_time createtime,update_time updatetime,depart_id departid from demo_user where id=@Id;";
                        SqlParameter param = new SqlParameter("@Id", 1);
                        // users = db.Database.ExecuteSqlCommand(sql, param);
                        var ulist =db.Database.SqlQuery<DemoUser>(sql, param).ToList();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (trans != null)
                            trans.Rollback();
                        throw;
                    }
                    finally
                    {
                        db.Dispose();
                    }

                    int a = 0;
                }
            }
        }
    }
}

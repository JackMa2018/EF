using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstFromDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //查询
            new EFQueryTest().Show();

            //映射
            using (var db = new DemoDbContext())
            {
                var user= db.DemoUser.SingleOrDefault(m => m.Id == 1);
                var login = db.DemoLoginInfo.SingleOrDefault(m => m.Id == 1);
                var district = db.DemoDistrict.SingleOrDefault(m => m.Id == 1);
            }

            Console.ReadLine();
        }
    }
}

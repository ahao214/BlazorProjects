using SqlSugar;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class SqlSugarHelper
    {
        // 用单例模式
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = "Data Source=LAPTOP-3HE8JVHO;Initial Catalog=LearnBlazor;User ID=sa;Pwd=hao@chen214",
            DbType = DbType.SqlServer,// 数据库类型
            IsAutoCloseConnection = true     // 不设成true要手动close
        },
            db =>
            {
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    Console.WriteLine(sql);
                };
            }

        );


    }
}

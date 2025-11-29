

using SqlSugar;

var db = new SqlSugarClient(new ConnectionConfig()
{
    ConnectionString = "Server=192.168.0.21;Port=3306;Database=shengdudao2;User=root;Password=sa3210;AllowLoadLocalInfile=true;", // 替换为你的连接字符串
    DbType = DbType.MySql, // 替换为你的数据库类型：MySql, SqlServer, Oracle, PostgreSQL 等
    IsAutoCloseConnection = true
});

// 指定表名
string[] tables = new[] { "tb_home_title", "tb_home_title_model" }; // 替换为你要生成的表名

// 设置输出路径和命名空间
string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "Models"); // 当前目录下的 Models 文件夹
string nameSpace = "MyApp.Models";

// 生成代码
db.DbFirst
  .IsCreateAttribute(true)       // 添加 [SugarColumn]
  .IsCreateDefaultValue(true)   // 加默认值
  .Where(tables)                // 指定要生成的表
  .CreateClassFile(outputDir, nameSpace);

Console.WriteLine("实体类生成成功！");
using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Simple02
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }


        static void Test()
        {
            //var list = new List<content>() {
            //    new content { title = "1标题",contents = "1内容"},
            //    new content { title = "2标题",contents = "2内容"},
            //};

            using (var conn = new SqlConnection("Data Source=.;User ID=sa;Password=1;Initial Catalog=CityStroage;Pooling=true;Max Pool Size=100;"))
            {
                //string sql = @"INSERT INTO content(title,contents,status,add_time,modify_time) VALUES(@title,@contents,@status,@add_time,@modify_time)";

                //var result = conn.Execute(sql,  list);

                //Console.WriteLine($"插入了{result}条数据！");

                //string sql = "select * from content where id = @id and status = 0";
                //var result = conn.QueryFirstOrDefault<content>(sql, new { id = 1 });

                //Console.WriteLine($"查询到{result.id}条数据！");

                //string sql = "select * from content where status = 0";
                //var result = conn.Query<content>(sql);

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item.id);
                //}

                string sql = "select * from content where id = @id;select * from comment where content_id = @id";
                using (var result = conn.QueryMultiple(sql,new { id = 1 }))
                {
                    var comment = result.ReadFirstOrDefault<contentwithcomment>();
                    comment.comments = result.Read<comment>();
                    Console.WriteLine($"数量{comment.comments.Count()}");
                }


            }
        }

    }
}

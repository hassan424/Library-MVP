using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LipraryMVP.Logic.Services
{
    static class CategoryService
    {
        //دالة ادخال بيانات التصنيفات الى قاعدة البيانات وداخلته دالة ارسال البرميترات
        public static bool categoryInsert(int id, string name)
        {
            return DBHelper.excuteData("category_Insert" ,()=> categoryParmaterInsert(id, name, DBHelper.command));   
        }
        private static void categoryParmaterInsert(int id , string name ,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value=id;
            command.Parameters.Add("@name", SqlDbType.NVarChar ,250).Value = name;
        }
   
        //دالة حدف بيانات التصنيفات الى قاعدة البيانات وداخلته دالة ارسال البرميترات
        public static bool categoryDelete(int id)
        {
            return DBHelper.excuteData("category_Delete", () => categoryParmaterDelete(id , DBHelper.command));
        }
        private static void categoryParmaterDelete(int id , SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //دالة تعديل بيانات التصنيفات الى قاعدة البيانات وداخلته دالة ارسال البرميترات
        public static bool categoryUpdate(int id, string name)
        {
            return DBHelper.excuteData("category_Update", () => categoryParmaterUpdate(id, name, DBHelper.command));
        }
        private static void categoryParmaterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar, 250).Value = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.Client
{
    public static class Commnon
    {
        public static string ColumnTypeConvert(this object ColumnType)
        {
            if (string.IsNullOrEmpty(ColumnType?.ToString()))
            {
                return string.Empty;
            }
            string type = ColumnType.ToString().ToUpper();
            switch (type)
            {
                case "INT":
                case "SMALLINT":
                case "TINYINT ":
                case "BIGINT":
                    type = type.ToLower() + "?"; break;
                case "FLOAT":
                case "DECIMAL":
                case "NUMERIC":
                    type = "decimal?"; break;
                case "BIT": type = "bool?"; break;
                case "CHAR":
                case "NCHAR":
                case "VARCHAR":
                case "NVARCHAR":
                    type = "string"; break;
                case "DATETIME":
                case "SMALLDATETIME":
                    type = "DateTime?"; break;
                case "UNIQUEIDENTIFIER": type = "string"; break;
                default:
                    type = type.ToLower(); break;
            }
            return type;
        }


        public static String firstCharacterToUpper(String srcStr)
        {
            return srcStr.Substring(0, 1).ToUpper() + srcStr.Substring(1);
        }
        /**
        * 替换字符串并让它的下一个字母为大写
        * @param srcStr
        * @param org
        * @param ob
        * @return
*/
        public static String replaceUnderlineAndfirstToUpper(String srcStr, String org, String ob)
        {
            String newString = "";
            int first = 0;
            while (srcStr.IndexOf(org) != -1)
            {
                first = srcStr.IndexOf(org);
                if (first != srcStr.Length)
                {
                    newString = newString+ ConvertToStr(srcStr.Substring(0, first)) + ob;
                    srcStr = srcStr.Substring(first + org.Length);
                    srcStr = firstCharacterToUpper(srcStr);
                }
            }
            newString = newString + ConvertToStr(srcStr);
            return newString;
        }
        public static string ConvertToStr(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }
        
        /// <summary>
        /// 写入文本文件
        /// </summary>
        /// <param name="fileName">写入的文本文件的路径及文件名（含扩展名）</param>
        /// <param name="strContent">写的内容</param>
        public static void Write(string fileName, string strContent)
        {
            var path = "C:\\Script";
            if (!Directory.Exists(path))//如果不存
            {
                Directory.CreateDirectory(path);
            }
            fileName = path + "\\" + fileName;
            if (!File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                long fl = fs.Length;
                fs.Seek(fl, SeekOrigin.End);
                sw.WriteLine(strContent);//开始写入值
                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                long fl = fs.Length;
                fs.Seek(fl, SeekOrigin.Begin);
                sw.WriteLine(strContent + "\n\n");//开始写入值
                sw.Close();
                fs.Close();
            }

        }
    }
}
using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace SPM.Service
{
    /// <summary>
    /// SqlServer数据访问帮助类
    /// </summary>
     public class MySqlHelper
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        //定义SQL连接对象
        private static SqlConnection _conn = null;
        private MySqlHelper() { }

        #region 获取数据库连接对象
        private static SqlConnection GetSqlConnection()
        {
            if (_conn == null || _conn.ConnectionString == "")
            {
                _conn = new SqlConnection(_connectionString);
            }
            return _conn;
        }
        #endregion

        #region 打开数据库连接
        private static void OpenSQLConnection()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();

            }
            else
            {
                _conn.Close();
                _conn.Open();
            }

        }
        #endregion

        #region 关闭数据库连接
        private static void CloseSQLConnection()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }

        }
        #endregion

        #region 重载=>执行非查询单个数据库语句(增加,删除,修改)

        public static int ExecuteNonQuery_Single(string sqlStr)
        {
            return ExecuteSql_NonQuery(sqlStr, null, CommandType.Text);
        }

        public static int ExecuteNonQuery_Single(string sqlStr, SqlParameter[] pars)
        {
            return ExecuteSql_NonQuery(sqlStr, pars, CommandType.Text);
        }

        public static int ExecuteNonQuery_Proc(string procName)
        {
            return ExecuteSql_NonQuery(procName, null, CommandType.StoredProcedure);
        }

        public static int ExecuteNonQuery_Proc(string procName, SqlParameter[] pars)
        {
            return ExecuteSql_NonQuery(procName, pars, CommandType.StoredProcedure);
        }

        public static int ExecuteNonQuery_ArrayList(ArrayList sqlStrArray)
        {
            int sqlResult = 0;
            foreach (string str in sqlStrArray)
            {
                if (ExecuteSql_NonQuery(str, null, CommandType.Text) > 0)
                {
                    sqlResult++;
                }

            }
            return sqlResult;
        }

        public static int ExecuteNonQuery_ArrayList(ArrayList sqlStrArray, SqlParameter[] pars)
        {
            int sqlResult = 0;
            foreach (string str in sqlStrArray)
            {
                if (ExecuteSql_NonQuery(str, pars, CommandType.Text) > 0)
                {
                    sqlResult++;
                }

            }
            return sqlResult;
        }
        #endregion
        #region 执行非查询单个数据库语句(增加,删除,修改)
        private static int ExecuteSql_NonQuery(string sqlStr, SqlParameter[] paras, CommandType type)
        {
            int SqlResult = 0;
            //创建数据库连接对象.
            using (SqlConnection _con = GetSqlConnection())
            {
                //创建操作对象.
                SqlCommand comd = _con.CreateCommand();
                //定义操作类型.
                comd.CommandType = type;
                //定义操作语句.
                comd.CommandText = sqlStr;
                //定义执行语句参数.
                if (paras != null)
                {
                    comd.Parameters.AddRange(paras);
                }
                //打开数据库连接.
                OpenSQLConnection();
                //执行操作.
                SqlResult = comd.ExecuteNonQuery();
                //关闭数据库连接,释放操作对象.
                //comd.Dispose();
                CloseSQLConnection();
            }
            //返回操作结果.
            return SqlResult;

        }
        #endregion

        #region 重载=>执行查询数据库语句,返回首行首列字段值.
        public static object ExecuteScalar_object(string strSQL)
        {
            return ExecuteSql_Scalar(strSQL, null, CommandType.Text);
        }

        public static object ExecuteScalar_object(string strSQL, SqlParameter[] pars)
        {
            return ExecuteSql_Scalar(strSQL, pars, CommandType.Text);
        }

        public static int ExecuteScalar_ToInt32(string strSQL)
        {
            object a = null;
            a = ExecuteSql_Scalar(strSQL, null, CommandType.Text);
            if (a.Equals(DBNull.Value))
            {
                a = -1;
            }
            return Convert.ToInt32(a);
        }

        public static int ExecuteScalar_ToInt32(string strSQL, SqlParameter[] pars)
        {
            object a = null;
            a = ExecuteSql_Scalar(strSQL, pars, CommandType.Text);
            if (a.Equals(DBNull.Value))
            {
                a = -1;
            }
            return Convert.ToInt32(a);
        }
        #endregion

        #region 执行查询数据库语句,返回首行首列字段值.
        private static object ExecuteSql_Scalar(string strSQL, SqlParameter[] paras, CommandType cmdtype)
        {
            object SqlResult = null;
            //创建数据库连接对象.
            using (SqlConnection _con = GetSqlConnection())
            {
                //创建操作对象.
                SqlCommand comd = _con.CreateCommand();
                //定义操作类型.
                comd.CommandType = cmdtype;
                //定义操作语句.
                comd.CommandText = strSQL;
                //定义执行语句参数.
                if (paras != null)
                {
                    comd.Parameters.AddRange(paras);
                }
                //打开数据库连接.
                OpenSQLConnection();
                //执行操作.
                SqlResult = comd.ExecuteScalar();
                //关闭数据库连接,释放操作对象.
                comd.Dispose();
                CloseSQLConnection();
            }

            //返回操作结果.
            return SqlResult;

        }
        #endregion

        #region 批量插入数据(TableMode)
        /// <summary>
        /// 往数据库中批量插入数据
        /// </summary>
        /// <param name="sourceDt">数据源表</param>
        /// <param name="targetTable">服务器上目标表</param>
        public static void BulkToDB(DataTable sourceDt, string targetTable)
        {

            SqlConnection conn = GetSqlConnection();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);   //用其它源的数据有效批量加载sql server表中
            bulkCopy.DestinationTableName = targetTable;    //服务器上目标表的名称
            bulkCopy.BatchSize = sourceDt.Rows.Count;   //每一批次中的行数

            try
            {
                conn.Open();
                if (sourceDt != null && sourceDt.Rows.Count != 0)
                    bulkCopy.WriteToServer(sourceDt);   //将提供的数据源中的所有行复制到目标表中
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                if (bulkCopy != null)
                    bulkCopy.Close();
            }

        }
        #endregion

        #region 执行查询，返回DataSet对象
        public static DataSet GetDataSet(string strSQL)
        {
            return GetDataSet(strSQL, null, CommandType.Text);
        }
        public static DataSet GetDataSet(string strSQL, SqlParameter[] pas)
        {
            return GetDataSet(strSQL, pas, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataSet对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataSet对象</returns>
        private static DataSet GetDataSet(string strSQL, SqlParameter[] pas, CommandType cmdtype)
        {
            DataSet dt = new DataSet(); ;
            using (SqlConnection conn = GetSqlConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.SelectCommand.CommandType = cmdtype;
                if (pas != null)
                {
                    da.SelectCommand.Parameters.AddRange(pas);
                }
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region 执行查询，返回DataTable对象
        public static DataTable GetDataTable(string strSQL)
        {
            return GetDataTable(strSQL, null, CommandType.Text);
        }
        public static DataTable GetDataTable(string strSQL, SqlParameter[] pas)
        {
            return GetDataTable(strSQL, pas, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataTable对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataTable对象</returns>
        private static DataTable GetDataTable(string strSQL, SqlParameter[] pas, CommandType cmdtype)
        {
            DataTable dt = new DataTable(); ;
            using (SqlConnection conn = GetSqlConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.SelectCommand.CommandType = cmdtype;
                if (pas != null)
                {
                    da.SelectCommand.Parameters.AddRange(pas);
                }
                da.Fill(dt);
            }
            return dt;
        }
        #endregion
        /// <summary>
        /// 精确查询某数据是否存在,SQL语句写到操作符为止
        /// </summary>
        /// <param name="sqlStr">查询的SQL语句</param>
        /// <param name="pra">查询条件参数</param>
        /// <returns>是否存在</returns>
        private static bool ObjectIsExists(string sqlStr, object pra)
        {
            bool _isExists;
            if (ExecuteScalar_object(sqlStr + "'" + pra.ToString() + "'") != null)
            {
                _isExists = true;
            }
            else
            {
                _isExists = false;
            }
            return _isExists;
        }
        
    }


}

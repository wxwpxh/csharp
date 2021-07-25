//csc -reference:Oracle.ManagedDataAccess.dll ora4.cs
//csc /r:Oracle.ManagedDataAccess.dll ora4.cs
//解决方法: 在命令行修改显示字符格式  chcp 936
//回来 chcp 65001
/* Copyright (c) 2018, Oracle and/or its affiliates. All rights reserved. */

/******************************************************************************
 *
 * You may not use the identified files except in compliance with The MIT
 * License (the "License.")
 *
 * You may obtain a copy of the License at
 * https://github.com/oracle/Oracle.NET/blob/master/LICENSE
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 *****************************************************************************/

using System;
using Oracle.ManagedDataAccess.Client;

public static string ConnectOracle()
        {
            try
            {
                string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Persist Security Info=True;User ID=mymotif;Password=wxwpxh;";
                OracleConnection con = new OracleConnection(connString);
                
                con.Open();
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.Setting
{
    public class DataService:DataTable
    {       
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
       
        public static string strConn = "Data Source=TNGOC;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True;";
        <DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=QUANLYKHACHSAN.Setting Type=DataService)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="DataService" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="DataService" SourceLocation="(Assembly=file:///D:/QuanLyKhachSan/QUANLYKHACHSAN/Setting/DataService.cs StartLineNumber=9 StartCharacterOffset=17 EndLineNumber=9 EndCharacterOffset=28)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=QUANLYKHACHSAN.Setting Type=DataService)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/QUANLYKHACHSAN/QUANLYKHACHSAN.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/QUANLYKHACHSAN/Setting/DataService.cs" />
    <Alias n="3" Uri="Assembly=$(3abe9f1e-5ba7-4451-b1f4-e3193d45fd5b.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="3abe9f1e-5ba7-4451-b1f4-e3193d45fd5b.OutputPathUri" Value="file:///D:/QuanLyKhachSan/QUANLYKHACHSAN/bin/Debug/QUANLYKHACHSAN.exe" />
    <Path Id="VsSolutionUri" Value="file:///D:/QuanLyKhachSan" />
  </Paths>
</DirectedGraph>
        public DataService()
        {

        }
        public void Load(SqlCommand command)
        {
            m_DataAdapter = new SqlDataAdapter();
            m_Command = new SqlCommand();
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }

            m_Command = command;
            m_Command.Connection = m_Connection;
            m_DataAdapter = new SqlDataAdapter(m_Command);
            this.Clear();
            m_DataAdapter.Fill(this);
        }

        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(strConn);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }

        public void Update()
        {
            SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
            m_DataAdapter.Update(this);
            ////int result = 0;
            //SqlTransaction m_SqlTransaction = null;
            //try
            //{
            //    m_SqlTransaction = m_Connection.BeginTransaction();

            //    m_Command.Connection = m_Connection;
            //    m_Command.Transaction = m_SqlTransaction;

            //    m_DataAdapter = new SqlDataAdapter();
            //    m_DataAdapter.SelectCommand = m_Command;

            //    SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
            //    m_DataAdapter.Update(this);
            //    m_SqlTransaction.Commit();
            //}           
            //catch (Exception e)
            //{
            //    if (m_SqlTransaction != null)
            //        m_SqlTransaction.Rollback();
            //    throw;                
            //}
            ////return result;
        }
        public void UpdatePassWord(String tenDangNhap, String matKhauMoi)
        {
            m_Command = new SqlCommand();
            m_DataAdapter = new SqlDataAdapter();
            String sql = "UPDATE NGUOI_DUNG SET MatKhau=@matKhau WHERE TenDangNhap = @ten";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = tenDangNhap;
            cmd.Parameters.Add("matKhau", SqlDbType.VarChar).Value = matKhauMoi;
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }

            m_Command = cmd;
            m_Command.Connection = m_Connection;
            m_DataAdapter = new SqlDataAdapter(m_Command);
            //this.Clear();
            m_DataAdapter.Fill(this);
            SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
            m_DataAdapter.Update(this);

        }

        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction tr = null;
            // m_Dataset = new DataSet();
            try
            {
                tr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = tr;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                //m_DataAdapter.Fill(m_Dataset);
                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();

            }
            return result;
        }        
        /// <summary>
        /// Thuc thi mot command
        /// </summary>
        /// <param name="command">OleDb hay Store Procedure</param>
        /// <returns></returns>
        public int ExecuteNoneQuery(SqlCommand cmd)
        {

            int result = 0;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteNonQuery();

                this.AcceptChanges();

                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                throw;
            }
            return result;

        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            SqlTransaction tr = null;

            //try
            //{
            tr = m_Connection.BeginTransaction();

            cmd.Connection = m_Connection;

            cmd.Transaction = tr;

            result = cmd.ExecuteScalar();

            this.AcceptChanges();

            tr.Commit();

            if (result == DBNull.Value)
            {
                result = null;
            }
            //}
            //catch
            //{
            //    if (tr != null) tr.Rollback();
            //    throw;
            //}
            return result;
        }      
    }
}

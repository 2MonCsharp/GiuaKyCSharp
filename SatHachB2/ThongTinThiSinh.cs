using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    class ThongTinThiSinh
    {



        public ThongTinThiSinh()
        {
           
        }
        public ThongTinThiSinh(string sbd)
        {
            string cmd = "select Ho,Ten,NgaySinh,Case (GioiTinh) When 1 then 'Nam' When 0 then 'Nữ' end as GioiTinh,DiaChi,QuocTich,CMND,HinhAnh from ThiSinh where MsThiSinh='" + sbd + "'";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            DataRow row = ds.Rows[0];
            ho = row["Ho"].ToString();
            ten = row["Ten"].ToString();
            ngaysinh = row["NgaySinh"].ToString();
            gioiTinh = row["GioiTinh"].ToString();
            diachi = row["DiaChi"].ToString();
            quoctich = row["QuocTich"].ToString();
            cmnd = row["CMND"].ToString();
            if(row["HinhAnh"].ToString()!="")
            hinhanh = row["HinhAnh"].ToString();
            else
                this.hinhanh = "avatar.png";
            


        }
        public bool themthisinh(string sbd,string Ho, string ten, string ngaysinh, bool gioitinh, string quoctich, string diachi, string hinhanh,  string cmnd)
        {
            int gt;
            if (gioitinh == true) gt = 1; else gt = 0;
            string cmd = "EXEC NhapThiSinh '"+sbd+"',N'" + Ho + "',N'" + ten + "','"+ngaysinh+"',"+gt+",N'"+quoctich+"',N'"+diachi+"','"+hinhanh+"','"+cmnd+"'";
            SqlConnection dbConn = new SqlConnection(Program.connStr);
            try { 
            dbConn.Open();
            
            }
            catch
            {
                MessageBox.Show("Lỗi thêm thí sinh. Hãy kiểm tra kết nối với máy chủ", "Thông báo");
              
                return false;
            }
           SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            try
            {
                dbCmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            dbConn.Close();
                return true;

        }
        public bool Suathisinh(string sbd, string Ho, string ten, string ngaysinh, bool gioitinh, string quoctich, string diachi, string hinhanh, string cmnd)
        {
            int gt;
            if (gioitinh == true) gt = 1; else gt = 0;
            string cmd = "EXEC SuaThiSinh '" + sbd + "',N'" + Ho + "',N'" + ten + "','" + ngaysinh + "'," + gt + ",N'" + quoctich + "',N'" + diachi + "','" + hinhanh + "','" + cmnd + "'";
            SqlConnection dbConn = new SqlConnection(Program.connStr);
            try
            {
                dbConn.Open();

            }
            catch
            {
                MessageBox.Show("Lỗi sửa thí sinh. Hãy kiểm tra kết nối với máy chủ", "Thông báo");

                return false;
            }
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            try
            {
                dbCmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            dbConn.Close();
            return true;

        }
        public bool Xoathisinh(string sbd)
        {
         
            string cmd = "EXEC XoaThiSinh '" + sbd + "'";
            SqlConnection dbConn = new SqlConnection(Program.connStr);
            try
            {
                dbConn.Open();

            }
            catch
            {
                MessageBox.Show("Lỗi xóa thí sinh. Hãy kiểm tra kết nối với máy chủ", "Thông báo");

                return false;
            }
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            try
            {
                dbCmd.ExecuteNonQuery();
                dbConn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        
            

        }
        public bool Timkiem(string key)
        {

            string cmd = "EXEC Timkiem '" + key + "'";
            SqlConnection dbConn = new SqlConnection(Program.connStr);
            try
            {
                dbConn.Open();

            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm thí sinh. Hãy kiểm tra kết nối với máy chủ", "Thông báo");

                return false;
            }
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            try
            {
                dbCmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            dbConn.Close();
            return true;

        }


        public string ho { get; set; }
        public string ten { get; set; }
        public string gioiTinh { get; set; }
        public string ngaysinh { get; set; }
        public string quoctich { get; set; }
        public string cmnd { get; set; }
        public string diachi { get; set; }
        public string hinhanh { get; set; }
    }
}

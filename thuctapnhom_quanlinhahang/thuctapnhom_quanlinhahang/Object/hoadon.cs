﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace thuctapnhom_quanlinhahang.Object
{
    class hoadon
    {
        public int id_hoadon=0;
        public int id_nhanvien;
        public int id_khachhang;
        public int id_banan;
        public bool tinhtrang;
        public int id_khuyenmai;
        public DateTime ngaylap;
        public DateTime giolap;


        connects cn = new connects();
        public DataTable showhoadon()
        {
            DataTable kp = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn.cnt;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"show_hoadon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = cmd;
            kp = new DataTable();
            adt.Fill(kp);

            return kp;
        }
        public bool insert_hoadon(hoadon hd)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"insert_hoadon";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_nhanvien", hd.id_nhanvien);
                    cmd.Parameters.AddWithValue("@id_banan", hd.id_banan);
                    cmd.Parameters.AddWithValue("@id_khachhang", hd.id_khachhang);
                    cmd.Parameters.AddWithValue("@id_khuyenmai", hd.id_khuyenmai);
                    cmd.Parameters.AddWithValue("@tinhtrang", hd.tinhtrang);
                    cmd.Parameters.AddWithValue("@ngaylap", hd.ngaylap);
                    cmd.Parameters.AddWithValue("@gio", hd.giolap);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool update_hoadon(hoadon hd)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"update_hoadon";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_hoadon", hd.id_hoadon);
                    cmd.Parameters.AddWithValue("@id_nhanvien", hd.id_nhanvien);
                    cmd.Parameters.AddWithValue("@id_banan", hd.id_banan);
                    cmd.Parameters.AddWithValue("@id_khachhang", hd.id_khachhang);
                    cmd.Parameters.AddWithValue("@id_khuyenmai", hd.id_khuyenmai);
                    cmd.Parameters.AddWithValue("@tinhtrang", hd.tinhtrang);
                    cmd.Parameters.AddWithValue("@ngaylap", hd.ngaylap);
                    cmd.Parameters.AddWithValue("@gio", hd.giolap);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool delete_hoadon(int a)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"delete_hoadon";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon", a);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public DataTable search_hoadon(string a)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"search_hoadon";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ten", a);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(kp);

                    cn.cnt.Close();

                }
                catch (Exception)
                {


                }

            }


            return kp;
        }
        public DataTable search_khuyenmai(int id)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"search_khuyenmai";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(kp);

                    cn.cnt.Close();

                }
                catch (Exception)
                {


                }
            }
            return kp;
        }
    }
}

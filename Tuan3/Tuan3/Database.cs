using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tuan3
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                //tạo csdl
                using (var connection = new
                 SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tạo 2 bang
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InsertLoaihoa(LoaiHoa loai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<LoaiHoa> selectLoaihoa()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        //Xử lý Thêm Hoa
        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Hoa> selecthoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
    }
}

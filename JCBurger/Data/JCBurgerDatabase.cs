using SQLite;
using JCBurger.Models;

namespace JCBurger.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<JCBurgers>();
        }
        public int AddNewBurger(JCBurgers burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<JCBurgers> GetAllBurgers()
        {
            Init();
            List<JCBurgers> burgers = conn.Table<JCBurgers>().ToList();
            return burgers;
        }

    }
}

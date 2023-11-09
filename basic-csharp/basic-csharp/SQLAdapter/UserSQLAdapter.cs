﻿namespace basic_csharp.SQLAdapter
{
    public class UserSQLAdapter : ISQLAdapter
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        public UserSQLAdapter(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.TableName = "USER";
        }

        public int Delete<T>(Guid id) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public T Get<T>(Guid id) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public List<T> GetData<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }

        public int Insert<T>(T item) where T : class, new()
        {
            try
            {
                // todo
                return 1;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public int Update<T>(T item) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}

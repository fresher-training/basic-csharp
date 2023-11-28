namespace basic_csharp.SQLAdapter
{
    public abstract class BaseSQLAdapter<T> : ISQLAdapter<T> where T : class, new()
    {
        public abstract string ConnectionString { get; set; }
        public abstract string TableName { get; set; }

        public virtual int Delete(Guid id) {
            string deleteQuery = "DELETE " + TableName + " WHERE id = '" + id.ToString() + "'";
            // excute query
            return 0;
        }
        public virtual T Get(Guid id)
        {
            return new T();
        }

        public virtual List<T> GetData()
        {
            return new List<T>();
        }

        public virtual int Insert(T item)
        {
            return 0;
        }

        public virtual int Update(T item)
        {
            return 0;
        }
    }
}

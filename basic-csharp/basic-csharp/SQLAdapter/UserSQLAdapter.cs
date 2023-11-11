using basic_csharp.Objects;

namespace basic_csharp.SQLAdapter
{
    public class UserSQLAdapter : ISQLAdapter<User>
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        public UserSQLAdapter(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.TableName = "USER";
        }

        public List<User> GetData()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Insert(User item)
        {
            throw new NotImplementedException();
        }

        public int Update(User item)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

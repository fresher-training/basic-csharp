using basic_csharp.Objects;

namespace basic_csharp.SQLAdapter
{
    public class UserSQLAdapter : BaseSQLAdapter<User>
    {
        public override string ConnectionString { get; set; }
        public override string TableName { get; set; }

        public UserSQLAdapter(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.TableName = "USER";
        }

        public override int Insert(User item)
        {
            // cook data before insert
            item.CreatedDate = DateTimeOffset.UtcNow;
            return base.Insert(item);
        }

        public int Insert(User item, string firstName, string lastName)
        {
            item.Name = firstName + " " + lastName;
            return Insert(item);
        }

        public override int Update(User item)
        {
            // cook data before update
            item.LastModifiedDate = DateTimeOffset.UtcNow;
            return base.Update(item);
        }
    }
}

using System;

namespace SQLite.CodeFirst.Console
{
    internal class DbContext
    {
        private string nameOrConnectionString;

        public DbContext(System.Data.Common.DbConnection connection, string nameOrConnectionString)
        {
            this.nameOrConnectionString = nameOrConnectionString;
        }

        internal object Set<T>()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
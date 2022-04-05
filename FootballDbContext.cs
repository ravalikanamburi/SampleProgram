using System;

namespace SQLite.CodeFirst.Console
{
    internal class FootballDbContext : IDisposable
    {
        private SQLiteConnection sqLiteConnection;
        private bool v;
        private string v1;

        public FootballDbContext(string v1)
        {
            this.v1 = v1;
        }

        public FootballDbContext(SQLiteConnection sqLiteConnection, bool v)
        {
            this.sqLiteConnection = sqLiteConnection;
            this.v = v;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
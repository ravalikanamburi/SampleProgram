using System;

namespace SQLite.CodeFirst.Console
{
    internal class SQLiteConnection : IDisposable
    {
        private string v;

        public SQLiteConnection(string v)
        {
            this.v = v;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
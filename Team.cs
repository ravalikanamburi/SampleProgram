namespace SQLite.CodeFirst.Console
{
    internal class Team
    {
        public string Name { get; internal set; }
        public Coach Coach { get; internal set; }
        public System.Collections.Generic.List<Player> Players { get; internal set; }
        public Stadion Stadion { get; internal set; }
        public int Id { get; internal set; }
    }
}
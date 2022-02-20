using Microsoft.EntityFrameworkCore;

namespace TeleMusic.Bot.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DbSet<Video> Videos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                                => options.UseSqlite("Data Source = Videos.db");
    }
}
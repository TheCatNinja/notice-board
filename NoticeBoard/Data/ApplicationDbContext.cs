using NoticeBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace NoticeBoard.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Notice> Notices { get; set; } //create table, code first approach
}

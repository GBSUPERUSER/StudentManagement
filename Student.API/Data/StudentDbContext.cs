using Microsoft.EntityFrameworkCore;
using Student.API.Models;

namespace Student.API.Data;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public DbSet<StudentModel> Students { get; set; }
}
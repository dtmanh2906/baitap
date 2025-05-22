using Microsoft.EntityFrameworkCore;
using myMVC.Models;

namespace QLSV_Core.Models
{
    public class QLSVContext : DbContext
    {
        public QLSVContext(DbContextOptions<QLSVContext> options)
            : base(options)
        {
        }

        public DbSet<SinhVien> SinhVien { get; set; }
    }
}

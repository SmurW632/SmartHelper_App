using Microsoft.EntityFrameworkCore;
using SmartHelper.Server.Models.Auth;
using SmartHelper.Server.Models.PremisesFacilities;
using SmartHelper.Server.Models.Support_measures;

namespace SmartHelper.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AuthUser> Users { get; set; } = null!;
        public DbSet<RequestHistory> RequestHistories { get; set; } = null!;
        public DbSet<Site> Sites { get; set; } = null!;
        public DbSet<SiteCharacteristic> SitesCharacteristics { get; set; } = null!;
        public DbSet<SiteInfrastructure> SitesInfrastructures { get; set; } = null!;
        public DbSet<AdditionalSiteCharacterestic> AdditionalSiteCharacterestics { get; set; } = null!;
        public DbSet<InfrastructureDetails> InfrastructureDetails { get; set; } = null!;
        public DbSet<NPA> NPAs { get; set; } = null!;
        public DbSet<SubmissionOfDocument> SubmissionOfDocuments { get; set;} = null!;
        public DbSet<SupportMeasure> SupportMeasures { get; set; } = null!;

        
    }
}

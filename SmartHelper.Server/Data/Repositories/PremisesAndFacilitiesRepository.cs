using Microsoft.EntityFrameworkCore;
using SmartHelper.Server.Models.PremisesAndFacilities;
using System.Security;

namespace SmartHelper.Server.Data.Repositories
{
    public class PremisesAndFacilitiesRepository
    {
        private readonly SmarthelperDbContext _db;

        public PremisesAndFacilitiesRepository(SmarthelperDbContext db)
        {
            _db = db;
        }

        public async Task<List<Site>> GetAll()
        {
            return await _db.Sites
                .Include(p => p.SSiteCharacteristic)
                .Include(p => p.SAdditionalSiteCharacteristic)
                .Include(p => p.SGasSupplies)
                .Include(p => p.SHeatSupply)
                .Include(p => p.SPowerSupply)
                .Include(p => p.SWaterDisposably)
                .Include(p => p.SWaterSupply)
                .ToListAsync();
        }

        public async Task<Site> GetById(int id)
        {
            return await _db.Sites
                .Include(p => p.SSiteCharacteristic)
                .Include(p => p.SAdditionalSiteCharacteristic)
                .Include(p => p.SGasSupplies)
                .Include(p => p.SHeatSupply)
                .Include(p => p.SPowerSupply)
                .Include(p => p.SWaterDisposably)
                .Include(p => p.SWaterSupply)
                .FirstOrDefaultAsync(p => p.SiteId == id) ?? throw new ArgumentNullException(nameof(id));
        }
       
        public async Task<List<Site>> SearchSite(List<string> listOkved)
        {
            //return await _db.Sites
            //.Include(p => p.SAdditionalSiteCharacteristic)
            //.Where(p => p.SAdditionalSiteCharacteristic != null
            // && listOkved.Any(c => p.SAdditionalSiteCharacteristic.ListTypesEconomicActivities.Contains(c)))
            //.ToListAsync();

            return await _db.Sites
                .Include(p => p.SSiteCharacteristic)
                .Include(p => p.SAdditionalSiteCharacteristic)
                .Include(p => p.SGasSupplies)
                .Include(p => p.SHeatSupply)
                .Include(p => p.SPowerSupply)
                .Include(p => p.SWaterDisposably)
                .Include(p => p.SWaterSupply)
                .Where(p => listOkved.Any(c => p.SAdditionalSiteCharacteristic!.ListTypesEconomicActivities!.Contains(c)))
                .ToListAsync();

        }
    }
}

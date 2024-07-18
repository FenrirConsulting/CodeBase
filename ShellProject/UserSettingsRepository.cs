using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories
{
    // User Settings Table Repository Access Functions
    public class UserSettingsRepository : IUserSettingsRepository
    {
        private readonly AppDbContext _context;

        public UserSettingsRepository(AppDbContext context)
        {
            _context = context;
        }

        // Retrieve User by id
        public async Task GetUserSettingsAsync(int id)
        {
             await _context.UserSettings.FindAsync(id);
        }

        // Retrieve User by userid (SAM)
        public async Task<UserSettings?> GetUserSAMAsync(string userid)
        {
            return await _context.UserSettings.FirstOrDefaultAsync(u => u.UserId == userid);
        }

        // Add User Settings
        public async Task AddUserSettingsAsync(UserSettings userSettings)
        {
            await _context.UserSettings.AddAsync(userSettings);
            await _context.SaveChangesAsync();
        }
    }
}

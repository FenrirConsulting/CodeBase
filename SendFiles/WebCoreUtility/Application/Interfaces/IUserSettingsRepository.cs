using System.Threading.Tasks;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces
{
    /// <summary>
    /// Defines operations for managing user settings.
    /// </summary>
    public interface IUserSettingsRepository
    {
        /// <summary>
        /// Retrieves user settings asynchronously.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>The user settings, or null if not found.</returns>
        Task<UserSettings?> GetUserSettingsAsync(string username);

        /// <summary>
        /// Creates new user settings asynchronously.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>The newly created user settings, or null if creation failed.</returns>
        Task<UserSettings?> CreateUserSettingsAsync(string username);

        /// <summary>
        /// Updates existing user settings asynchronously.
        /// </summary>
        /// <param name="userSettings">The user settings to update.</param>
        Task UpdateUserSettingsAsync(UserSettings userSettings);
    }
}
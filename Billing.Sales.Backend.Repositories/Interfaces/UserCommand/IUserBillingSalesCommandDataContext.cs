using Billing.Sales.Backend.BusinessObjects.POCOEntities.AuthEntitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Sales.Backend.Repositories.Interfaces;

public interface IUserBillingSalesCommandDataContext
{
    Task AddUserAsync(User user);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> GetUserByIdAsync(int id);

    Task<Role?> GetRoleByNameAsync(string roleName);
    Task<IEnumerable<string>> GetRolesByUserIdAsync(int userId);
    Task EnsureRoleExistsAsync(string roleName);
    Task AssignRoleAsync(int userId, string roleName);

    Task SaveChangesAsync();
    Task UpdateUserAsync(User user);
}

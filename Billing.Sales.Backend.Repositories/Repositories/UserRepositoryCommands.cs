using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.Sales.Backend.BusinessObjects.POCOEntities.AuthEntitie;
using Billing.Sales.Backend.Repositories.Interfaces;   

namespace Billing.Sales.Backend.Repositories.Repositories;

public class UserRepositoryCommands(IUserBillingSalesCommandDataContext context) : IUserRepository
{
    public async Task AssignRole(int userId, string roleName)
    {
        await context.AssignRoleAsync(userId, roleName);
    }

    public async Task CreateUser(User user)
    {
        await context.AddUserAsync(user);
    }

    public async Task EnsureRoleExists(string roleName)
    {
        await context.EnsureRoleExistsAsync(roleName);
    }

    public async Task<Role?> GetRoleByName(string roleName) =>
            await context.GetRoleByNameAsync(roleName);

    public async Task<IEnumerable<string>> GetRolesByUserId(int userId)=>
    
        await  context.GetRolesByUserIdAsync(userId);
    

    public async Task<User?> GetUserByEmail(string email)=>
    await context.GetUserByEmailAsync(email);

    public async Task<User?> GetUserById(int id)=>
    await context.GetUserByIdAsync(id);

    public async Task SaveChanges()
    {
        await context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)=>
    await context.UpdateUserAsync(user);
    
}
    
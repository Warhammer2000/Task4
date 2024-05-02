using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace UserTableManagment.Services
{
	public static class ServiceExtensions 
	{
		public static async Task MigrateDatabaseAsync(this IServiceProvider serviceProvider)
		{
			using (var scope = serviceProvider.CreateScope())
			{
				var dbContext = scope.ServiceProvider.GetRequiredService<UserTableDataLayer.AppDbContext>(); 
				await dbContext.Database.MigrateAsync();
				//new
			}
		}
	}
}

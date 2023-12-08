using ShopList.Models;
using ShopList.Persistence.Configuration;
using SQLite;

namespace ShopList.Persistence
{
    public class ShopListItemDatabase
    {
        private SQLiteAsyncConnection _database;

        public ShopListItemDatabase()
        {
        }

        private async Task Init()
        {
            if (_database is not null)
            {
                return;
            }
            _database = new SQLiteAsyncConnection(
                Constants.DatabasePath, Constants.Flags);

            await _database.CreateTableAsync<ShopListItem>();
        }

        public async Task<int> SaveShopListItem(ShopListItem item)
        {
            await Init();
            //if (item.ID )
            //{
            //    // El artículo a comprar ya existe, así que es una actualización.
            //    return await _database.UpdateAsync(item);
            //}
            //else
            //{
            //    // Es un artículo nuevo.
            //    return await _database.InsertAsync(item);
            //}
            return await _database.InsertAsync(item);
        }

        public async Task<IEnumerable<ShopListItem>> GetShopListItems()
        {
            await Init();
            return await _database.Table<ShopListItem>().ToListAsync();
        }

        public async Task<ShopListItem> GetShopListItem(int id)
        {
            await Init();
            return await _database.Table<ShopListItem>()
                .Where(item => item.ID.Equals(id))
                .FirstOrDefaultAsync();
        }
    }
}


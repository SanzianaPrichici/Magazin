using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Magazin.Models;
using System.Threading.Tasks;

namespace Magazin.Data
{
    public class ClientDB
    {
        readonly SQLiteAsyncConnection _database;
        public ClientDB(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Client>().Wait();
        }
        public Task<List<Client>> GetShopListsAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }
        public Task<int> SaveClientAsync(Client cli)
        {
            if (cli.ID != 0)
            {
                return _database.UpdateAsync(cli);
            }
            else
            {
                return _database.InsertAsync(cli);
            }
        }
        public Task<int> DeleteClientAsync(Client cli)
        {
            return _database.DeleteAsync(cli);
        }
    }
}

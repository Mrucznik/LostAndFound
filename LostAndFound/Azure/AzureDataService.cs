using System;
using System.Collections;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using System.Diagnostics;
using System.IO;
using lostandfoundapp.Classes;

namespace LostAndFound.Azure
{
    public class AzureDataService
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceSyncTable<User> userTable;

        public async Task Initialize()
        {
            //Create our client
            MobileService = new MobileServiceClient("http://lostandfoundapp.azurewebsites.net");

            const string path = "syncstore.db";
            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<User>();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            //Get our sync table that will call out to azure
            userTable = MobileService.GetSyncTable<User>();
        }

        public async Task<IEnumerable> GetUsers()
        {
            await SyncUser();
            return await userTable.OrderBy(c => c.Id).ToEnumerableAsync();
        }

        public async Task AdUser(bool madeAtHome)
        {
            //create and insert coffee
            var coffee = new User
            {
                Name = "Elo",
                Surname = "pl"
            };

            await userTable.InsertAsync(coffee);

            //Synchronize coffee
            await SyncUser();
        }

        public async Task SyncUser()
        {
            //pull down all latest changes and then push current coffees up    
            await userTable.PullAsync("allCoffees", userTable.CreateQuery());
            await MobileService.SyncContext.PushAsync();
        }
    }
}
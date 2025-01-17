﻿using MongoDB.Driver;

namespace Api_HomeWork5.Servises
{
    public class MongoService
    {
        public readonly IMongoDatabase _database;
        public MongoService(IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("Products");
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}

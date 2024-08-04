using MongoDB.Driver;

namespace Api_HomeWork5.Servises
{
    public interface IMongoService
    {
        public IMongoCollection<T> GetCollection<T>(string name);
    }
}

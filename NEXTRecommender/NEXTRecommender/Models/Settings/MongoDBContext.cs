using MongoDB.Driver;
using NEXTRecommender.Models;
using NEXTRecommender.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationWorker.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoDatabaseSettings _settings;
        public MongoDBContext(IMongoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
            _settings = settings;
        }

        public IMongoCollection<CampsiteRatingData> GetCampsiteRatingDataCollection()
        {
            return _database.GetCollection<CampsiteRatingData>(_settings.UserRatingsCollection);
        }
    }
}

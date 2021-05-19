using MongoDB.Driver;
using NEXTRecommender.Models;
using NEXTRecommender.Models.Settings;
using NEXTRecommender.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Repositories
{
    public class PredictionRepository : IPredictionRepository
    {

        private readonly IMongoCollection<CampsiteRatingData> _campsiteRatingData;

        public PredictionRepository(IMongoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _campsiteRatingData = database.GetCollection<CampsiteRatingData>(settings.UserRatingsCollection);
        }
        public IEnumerable<CampsiteRatingData> GetAllCampsiteRatingData()
        {
            throw new NotImplementedException();
        }
    }
}

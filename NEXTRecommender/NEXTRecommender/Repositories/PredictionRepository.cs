using MongoDB.Driver;
using NEXTRecommender.Models;
using NEXTRecommender.Models.Settings;
using NEXTRecommender.Repositories.Interfaces;
using RecommendationWorker.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Repositories
{
    public class PredictionRepository : IPredictionRepository
    {

        private readonly IMongoCollection<CampsiteRatingData> _campsiteRatingData;

        public PredictionRepository(IMongoDBContext context)
        {
            _campsiteRatingData = context.GetCampsiteRatingDataCollection();
        }

        public IEnumerable<CampsiteRatingData> GetAllCampsiteRatingData()
        {
            IEnumerable<CampsiteRatingData> campsiteRatingDatas = _campsiteRatingData.Find(data => true).ToList();
            if (campsiteRatingDatas.Any())
            {
                return campsiteRatingDatas;
            }
            throw new Exception("No Rating data found!");
        }
    }
}

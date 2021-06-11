using MongoDB.Driver;
using NEXTRecommender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationWorker.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<CampsiteRatingData> GetCampsiteRatingDataCollection();
    }
}

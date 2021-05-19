using NEXTRecommender.Models;
using NEXTRecommender.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Services
{
    public class PredictionService : IPredictionService
    {
        public List<CampsiteRatingPrediction> GetPrediciton(string userId, int[] campsites)
        {
            throw new NotImplementedException();
        }

        public void TrainModel()
        {
            throw new NotImplementedException();
        }
    }
}

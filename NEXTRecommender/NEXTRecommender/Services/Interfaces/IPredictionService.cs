using NEXTRecommender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Services.Interfaces
{
    public interface IPredictionService
    {
        public void TrainModel();
        public List<CampsiteRatingPrediction> GetPrediciton(string userId, int[] campsites);
    }
}

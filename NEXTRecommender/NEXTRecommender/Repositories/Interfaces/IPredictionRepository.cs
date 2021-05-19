using NEXTRecommender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Repositories.Interfaces
{
    public interface IPredictionRepository
    {
        IEnumerable<CampsiteRatingData> GetAllCampsiteRatingData();
    }
}

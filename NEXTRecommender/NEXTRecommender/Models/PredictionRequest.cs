using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Models
{
    public class PredictionRequest
    {
        [BsonElement("userId")]
        public string UserId { get; set; }
        [BsonElement("campsites")]
        public int[] Campsites { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NEXTRecommender.Models;
using NEXTRecommender.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTRecommender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionController : ControllerBase
    {
        private readonly IPredictionService _predictionService;

        public PredictionController(IPredictionService predictionService)
        {
            _predictionService = predictionService;
        }

        [HttpPost]
        public ActionResult<List<CampsiteRatingPrediction>> GetPredictionforCampsites([FromBody]PredictionRequest predictionRequest)
        {
            try
            {
                return Ok(_predictionService.GetPrediciton(predictionRequest.UserId, predictionRequest.Campsites));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

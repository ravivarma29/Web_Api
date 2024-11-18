using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TrainWebApi.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class TrainController : ControllerBase
        {
            // Implement your code here
            private readonly ITrains _trainService;
            public TrainController(ITrains trainService)
            {
                _trainService = trainService;
            }

            [HttpGet("GetTrainByTrainNumber/{trainNumber}")]
            public ActionResult<Train> GetTrainByTrainNumber(int trainNumber)
            {
                var train = _trainService.GetTrainByTrainNumber(trainNumber);
                if (train == null)
                {
                    return NotFound();
                }
                else
                {
                    return train;
                }
            }
            [HttpGet("GetAllTrains")]
            public ActionResult<List<Train>> GetAllTrains()
            {
                var trains = _trainService.GetAllTrains().ToList();
                if (trains.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return trains;
                }
            }

        }
    }
}
}

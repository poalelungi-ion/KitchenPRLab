using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Interfaces;
using Restaurant.Core.PayloadModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Controllers
{
    [Route("api")]
    public class KitchenController : Controller
    {
        private readonly IKicthen _kicthen;
        private readonly ICook _cook;
        public KitchenController(IKicthen kicthen, ICook cook)
        {
            _kicthen = kicthen;
            _cook = cook;
        }
        [Route("order")]
        [HttpPost]
        public ActionResult OrderReceived(KitchenPayload payload)
        {
            var orderId = _kicthen.RecieveOrder(payload);
            _cook.GetFoodForCooking(orderId, payload.TableId, payload.WaiterId, payload.PickUpTime);

            return Ok();
        }
    }
}

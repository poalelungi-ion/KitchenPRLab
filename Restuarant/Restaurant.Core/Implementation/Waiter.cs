using Restaurant.Core.Interfaces;
using Restaurant.Core.PayloadModals;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Restaurant.Core.Implementation
{
    public class Waiter : IWaiter
    {
        private readonly IDistributionRepository _distributionRepository;
        public Waiter(IDistributionRepository distributionRepository)
        {
            _distributionRepository = distributionRepository;
        }

        public void GetOrder(KitchenPayload payload)
        {

        }

        public void SendOrders(IEnumerable<KitchenPayload> payloads)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("");//Kitchen server uri
            foreach(var payload in payloads)
            {
                httpClient.SendAsync(new HttpRequestMessage
                {
                    Method = new HttpMethod("POST"),
                    Content = new StringContent(JsonConvert.SerializeObject(payload)),
                    RequestUri = new Uri("order")
                });
            }
        }

        public void ServOrder(DistributionPayload payload)
        {
            _distributionRepository.Served(payload.Id);
        }
    }
}

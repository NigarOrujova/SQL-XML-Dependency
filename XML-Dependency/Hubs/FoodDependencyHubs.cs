using Microsoft.AspNetCore.SignalR;

namespace XML_Dependency.Hubs
{
    public class FoodDependencyHubs:Hub
    {
        public async Task RunXmlRead()
        {

            //var foods =  await distributedCache.GetRecordAsync<IEnumerable<FoodDto>>(CACHE_FOOD_KEY);
        }
    }
}

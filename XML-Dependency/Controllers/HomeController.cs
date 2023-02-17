using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using XML_Dependency.Extensions;
using XML_Dependency.Models;
using XML_Dependency.Models.DataContexts;

namespace XML_Dependency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IDistributedCache _cache;
        private const string CACHE_FOOD_KEY = "food";
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger,AppDbContext context ,IDistributedCache cache, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _cache = cache;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var foods = await _cache.GetRecordAsync<IEnumerable<FoodDto>>(CACHE_FOOD_KEY);
            if (foods == null)
            {
                var data = await _context.Categories
                   .Include(x => x.Foods)
                   .FirstOrDefaultAsync(x => x.CategoryID == 1004);

                foods = _mapper.Map<IEnumerable<FoodDto>>(data.Foods);

                await _cache.SetRecordAsync(recordKey: CACHE_FOOD_KEY, data: foods, unusedExpirationTime: TimeSpan.FromSeconds(30));
                var serialezer = new XmlSerializer(typeof(List<FoodDto>));
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "data.xml");
                FileStream file = System.IO.File.Create(path);
                serialezer.Serialize(file, foods);
                file.Close();
            }

            return View(foods);
        }
    }
}
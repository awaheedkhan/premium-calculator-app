using System.Web.Mvc;

namespace PremiumCalculator.Api.Common
{
    public class BaseController<T> : Controller where T : BaseModel
    {
        private readonly IService<T> _service;

        public BaseController(IService<T> service)
        {
            _service = service;
        }
    }
}

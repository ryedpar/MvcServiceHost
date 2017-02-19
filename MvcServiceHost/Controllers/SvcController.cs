using System.Web.Mvc;
using System.Web.Services;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Mvc_5_Empty_Template1.Controllers
{
    public class SvcController : Controller
    {
        [WebMethod]
        public string Wait()
        {
            Thread.Sleep(5000);
            return $"Sync: {DateTime.Now.ToString()}";
        }
        [WebMethod]
        public async Task<string> WaitAsync()
        {
            await Task.Delay(5000);
            return $"Async: {DateTime.Now.ToString()}";
        }

    }
}
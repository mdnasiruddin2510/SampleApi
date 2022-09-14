using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SampleApiAddProject.Models;

namespace SampleApiAddProject.Controllers
{
    public class PersonalInfoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //var lists = new PersonalListVM();
            List<PersonalInfoVM> perList = new List<PersonalInfoVM>();
            using (var httpClient=new HttpClient())
            {
                using (var response= await httpClient.GetAsync("http://localhost:5283/api/todoitems"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    perList = JsonConvert.DeserializeObject<List<PersonalInfoVM>> (apiResponse);
                }
            }
            return View(perList);
        }
    }
}

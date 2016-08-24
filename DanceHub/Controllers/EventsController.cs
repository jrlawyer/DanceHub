using DanceHub.Models;
using DanceHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace DanceHub.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: Events
        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {   //ienumerable list = new dbcontext.model-type.toList
                EventTypes = _context.EventTypes.ToList()
            };
            return View(viewModel);
        }
    }
}
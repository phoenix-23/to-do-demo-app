using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Data.Models;

namespace ToDo.Pages
{
    public class WorksModel : PageModel
    {
        public List<Work> Works { get; set; }
        
        private WorkDbContext _context;
        public WorksModel(WorkDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Works = _context.Works.OrderByDescending(x => x.TimeCreated).ToList();
        }
        public IActionResult OnPostClickFinished(int id)
        {
            Work? _data = _context.Works.FirstOrDefault<Work>(n => n.Id == id);
            if (_data != null)
            {
                _data.TimeLastUpdated = DateTime.Now;
                _data.Finished = true;
                _context.Update(_data);
                _context.SaveChanges();
            }
            Works = _context.Works.OrderByDescending(x => x.TimeCreated).ToList();
            return Page();
		}
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Data.Models;

namespace ToDo.Pages
{
    public class AddWorkModel : PageModel
    {
		[BindProperty] public string Name { get; set; }
		[BindProperty] public string Description { get; set; }

		private WorkDbContext _context;
		public AddWorkModel(WorkDbContext context)
		{
			_context = context;
		}
		public void OnGet()
        {
        }
		public IActionResult OnPost() 
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			var work = new Work()
			{
				Name = Name,
				Description = Description,
				TimeCreated = DateTime.Now,
				TimeLastUpdated = DateTime.Now
			};
			_context.Works.Add(work);
			_context.SaveChanges();
			return Redirect("Works");
		}
    }
}

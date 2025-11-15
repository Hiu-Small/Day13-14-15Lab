using Bai_Thuc_Hanh_4.Data;
using Bai_Thuc_Hanh_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai_Thuc_Hanh_4.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}

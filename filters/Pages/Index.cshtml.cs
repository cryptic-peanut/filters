using filters.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace filters.Pages
{
    [CustomFilterAttributes]
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int testVriable { get; set; }
        public override void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 0;
        }
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext
       pageContext)
        {
            int a = 0;
        }
        public override void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 0;
        }
        public void OnGet()
        {
            int a = 0;
        }
    }
}
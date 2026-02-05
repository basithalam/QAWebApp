using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QAWebApp.Models;
using QAWebApp.Services.Interfaces;

namespace QAWebApp.Pages.Questions;

public class EditModel : PageModel
{
    private readonly IQuestionService _questionService;

    public EditModel(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    public Question? Question { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Question = await _questionService.GetQuestionByIdAsync(id);

        if (Question == null)
        {
            return NotFound();
        }

        return Page();
    }
}

namespace synonyms_project.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SynonymsController : Controller
{
    [HttpGet("get-synonyms/{word}")]
    public IActionResult GetSynonyms(string word)
    {
        // Code to retrieve synonyms for the given word
        List<string> synonyms = new List<string> { "word1", "word2", "word3" };

        return Ok(new { synonyms, success = true });
    }
}
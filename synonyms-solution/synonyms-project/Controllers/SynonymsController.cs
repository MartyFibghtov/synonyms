using synonyms_project.Core;
using synonyms_project.Models;

namespace synonyms_project.Controllers;

using Microsoft.AspNetCore.Mvc;



[Route("api/[controller]")]
[ApiController]
public class SynonymsController : Controller
{
    private SynonymsStorage _synonymsStorage;

    public SynonymsController(SynonymsStorage synonymsStorage)
    {
        _synonymsStorage = synonymsStorage;
    }
    
    // Returns synonyms for word if they exist
    [HttpGet("get-synonyms/{word}")]
    public IActionResult GetSynonyms(string word)
    {
        try
        {
            word = WordProcessing.Normalize(word);
            var synonyms = _synonymsStorage.GetSynonyms(word);
            return Ok(new {synonyms, success = true});
        }
        catch (KeyNotFoundException e)
        {
            return Ok(new {success = false, message = e.Message});
        }
        catch (ArgumentException e)
        {
            return Ok(new {success = false, message = e.Message});
        }
    }

    // Adds new synonyms to word 
    [HttpPost("create-synonyms/")]
    public IActionResult CreateSynonyms([FromBody] AddSynonymsModel addSynonymsModel)
    {
        var word = addSynonymsModel.Word;
        var synonyms = addSynonymsModel.Synonyms;
        
        try
        {
            // Normalise all words
            word = WordProcessing.Normalize(word);
            for (var i = 0; i < synonyms.Count; i++)
            {
                synonyms[i] = WordProcessing.Normalize(synonyms[i]);
            }
            
            // Add synonyms
            _synonymsStorage.AddSynonyms(word, synonyms);
        }
        catch (ArgumentException e)
        {
            // One of words is in bad format
            return Ok(new {success = false, message = e.Message});
        }
        
        return Json(new { success = true, message = "Synonyms added successfully" });
    }
    
}
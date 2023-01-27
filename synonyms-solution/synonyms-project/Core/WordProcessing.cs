using System.Text.RegularExpressions;

namespace synonyms_project.Core;

public static class WordProcessing
{
    // Converts a string to universal format
    // Lowercase and trimmed
    // Throws exception if some external symbols are present
    public static string Normalize(string word)
    {
        // Throw exception for null or empty words
        if (string.IsNullOrWhiteSpace(word))
            throw new ArgumentException("Input word cannot be null or empty.");
        
        // Converts words to lowercase and deletes spaces on the edges
        word = word.ToLower().Trim();
        
        // Check if the word has only letters or "-" or space 
        if (!Regex.IsMatch(word, "^[\\p{L}\\-\\s\\']+$"))
            throw new ArgumentException("Invalid characters in word.");
        
        // Check that word doesn't start with "-" or "'" ends with "-"  
        if (Regex.IsMatch(word, "^[-']|[-]$"))
            throw new ArgumentException("Dash or ' can't be first or last symbol.");

        return word;
    }
}
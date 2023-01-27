namespace synonyms_project.Core;

public class SynonymsStorage
{
    // Private dictionary to store the synonyms
    private Dictionary<string, HashSet<string>> _synonymsStorage;

    // Constructor to initialize the dictionary
    public SynonymsStorage()
    {
        _synonymsStorage = new Dictionary<string, HashSet<string>>();
    }
    
    // Method to get synonyms of a given word
    public List<string> GetSynonyms(string word)
    {
        // Unknown word - throws exception
        if (! _synonymsStorage.ContainsKey(word))
        {
            throw new KeyNotFoundException("Unknown word");
        }
        
        // Convert synonyms to list (returned type)
        var synonyms = _synonymsStorage[word].ToList();
        
        // Exclude the word itself from synonyms list   
        synonyms.Remove(word);
        
        return synonyms;
    }
    
    // Method to add synonyms to the storage
    public void AddSynonyms(string word, List<string> synonyms)
    {
        // Create a new HashSet with the input word and synonyms 
        HashSet<string> newSynonymsGroup = new HashSet<string>(synonyms);
        newSynonymsGroup.Add(word);
        
        // Get the current synonyms group for synonyms group, or create a new group if not exist
        HashSet<string> currentSynonymsGroup = GetSynonymsGroupOrCreateNew(newSynonymsGroup);
        
        // Exclude from new synonyms already known ones
        newSynonymsGroup.ExceptWith(currentSynonymsGroup);
        
        // Add only new synonyms
        currentSynonymsGroup.UnionWith(newSynonymsGroup);
        
        // Add new keys to _synonymsStorage
        AddNewSynonymKeys(newSynonymsGroup, currentSynonymsGroup);
    }

    // Returns Synonyms Group 
    // If groups were separated before - joins them in one and reassign keys 
    private HashSet<string> GetSynonymsGroupOrCreateNew(HashSet<string> newSynonyms)
    {
        HashSet<HashSet<string>>? synonymsGroups = new HashSet<HashSet<string>>();

        // Look through every synonym to find its synonyms
        // In case groups were not connected earlier - connect them all together now
        foreach (var newSynonym in newSynonyms)
        {
            if (_synonymsStorage.ContainsKey(newSynonym))
            {
                synonymsGroups.Add(_synonymsStorage[newSynonym]);
            }
        }
        
        HashSet<string>? synonyms = new HashSet<string>();
        // Now group union current synonyms groups in one 
        foreach (var synonymsGroup in synonymsGroups)
        {
            synonyms.UnionWith(synonymsGroup);
        }
        
        // Update synonym groups for all these words 
        AddNewSynonymKeys(synonyms, synonyms);

        return synonyms;
    }
    
    // Add all words in same synonymic group to _synonymsStorage
    private void AddNewSynonymKeys(HashSet<string> newKeys, HashSet<string> synonymsGroup)
    {
        foreach (var newKey in newKeys)
        {
            _synonymsStorage[newKey] = synonymsGroup;
        }
    }
}
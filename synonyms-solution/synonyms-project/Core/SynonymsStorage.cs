namespace synonyms_project.Core;

public class SynonymsStorage
{
    // Private dictionary to store the synonyms
    private Dictionary<string, HashSet<string>> _synonymsStorage;

    public SynonymsStorage()
    {
        _synonymsStorage = new Dictionary<string, HashSet<string>>();
    }
    
    // Method to add synonyms to the storage
    public void AddSynonyms(string word, List<string> synonyms)
    {
        HashSet<string> newSynonymsGroup = new HashSet<string>(synonyms);
        newSynonymsGroup.Add(word);

        HashSet<string> currentSynonymsGroup = GetSynonymsGroupOrCreateNew(newSynonymsGroup);

        newSynonymsGroup.ExceptWith(currentSynonymsGroup);
        currentSynonymsGroup.UnionWith(newSynonymsGroup);

        AddNewSynonymKeys(newSynonymsGroup, currentSynonymsGroup);

    }

    private HashSet<string> GetSynonymsGroupOrCreateNew(HashSet<string> newSynonymsGroup)
    {
        HashSet<string>? currentSynonymsGroup = null;
        
        // Look through every synonym to find its synonymGroup
        foreach (var synonym in newSynonymsGroup)
        {
            if (_synonymsStorage.ContainsKey(synonym))
            {
                currentSynonymsGroup = _synonymsStorage[synonym];
                break;
            }
        }
        // If not - initialize new empty
        if (currentSynonymsGroup == null)
        {
            currentSynonymsGroup = new HashSet<string>();
        }

        return currentSynonymsGroup;
    }

    private void AddNewSynonymKeys(HashSet<string> newKeys, HashSet<string> synonymsGroup)
    {
        foreach (var newKey in newKeys)
        {
            _synonymsStorage[newKey] = synonymsGroup;
        }
    }
}
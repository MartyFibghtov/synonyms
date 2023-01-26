using NUnit.Framework;
using synonyms_project.Core;

[TestFixture]
public class SynonymsStorageTests
{
    private SynonymsStorage _synonymsStorage;

    [SetUp]
    public void SetUp()
    {
        _synonymsStorage = new SynonymsStorage();
    }

    [Test]
    public void TestAddSynonyms()
    {
        // Arrange
        var word = "happy";
        var synonyms = new List<string> { "content", "joyful", "pleased" };

        // Act
        _synonymsStorage.AddSynonyms(word, synonyms);

        // Assert
        var expectedSynonyms = new List<string> { "content", "joyful", "pleased" };
        Assert.That(_synonymsStorage.GetSynonyms(word), Is.EquivalentTo(expectedSynonyms));
    }

    [Test]
    public void TestAddExistingSynonyms()
    {
        // Arrange
        var word = "happy";
        var synonyms = new List<string> { "content", "joyful", "pleased" };

        _synonymsStorage.AddSynonyms(word, synonyms);

        // Act
        _synonymsStorage.AddSynonyms("pleased", new List<string> { "delighted" });

        // Assert
        var expectedSynonyms = new HashSet<string> { "content", "joyful", "pleased", "delighted" };
        Assert.That(_synonymsStorage.GetSynonyms(word), Is.EquivalentTo(expectedSynonyms));
    }

    [Test]
    public void TestSearchUnknownWord()
    {
        // Arrange
        var word1 = "happy";
        var synonyms1 = new List<string> { "content", "joyful", "pleased" };

        var word2 = "big";
        var synonyms2 = new List<string> { "large", "huge", "gigantic" };

        var word3 = "fast";
        var synonyms3 = new List<string> { "quick", "speedy", "swift" };

        var unknownWord = "dog";
        
        // Act
        _synonymsStorage.AddSynonyms(word1, synonyms1);
        _synonymsStorage.AddSynonyms(word2, synonyms2);
        _synonymsStorage.AddSynonyms(word3, synonyms3);

        // Assert

        var expectedErrorMsg = "Unknown word";
        
        Assert.That(_synonymsStorage.GetSynonyms(word1), Is.EquivalentTo(synonyms1));
        Assert.That(_synonymsStorage.GetSynonyms(word2), Is.EquivalentTo(synonyms2));
        Assert.That(_synonymsStorage.GetSynonyms(word3), Is.EquivalentTo(synonyms3));
        var ex = Assert.Throws<KeyNotFoundException>(() => _synonymsStorage.GetSynonyms(unknownWord));
        
        Assert.That(ex.Message, Is.EqualTo(expectedErrorMsg));
    }
    
    [Test]
    public void TestBiDirection()
    {
        // Arrange
        var word = "happy";
        var synonyms = new List<string> { "content", "joyful", "pleased" };
        
        // Act
        _synonymsStorage.AddSynonyms(word, synonyms);
        
        // Assert
        var searchWord = "content";
        var expectedSynonyms = new List<string> { "happy", "joyful", "pleased" };
        
        Assert.That(_synonymsStorage.GetSynonyms(word), Is.EquivalentTo(synonyms));
        Assert.That(_synonymsStorage.GetSynonyms(searchWord), Is.EquivalentTo(expectedSynonyms));
    }
    
    [Test]
    public void TestTransitivity()
    {
        // Arrange
        var word1 = "happy";
        var synonyms1 = new List<string> { "content" };
        var word2 = "content";
        var synonyms2 = new List<string> { "joyful", "pleased" };
        
        // Act
        _synonymsStorage.AddSynonyms(word1, synonyms1);
        _synonymsStorage.AddSynonyms(word2, synonyms2);
        
        // Assert
        var searchWord1 = "happy";
        var expectedSynonyms1 = new List<string> { "content", "joyful", "pleased" };
        
        var searchWord2 = "pleased";
        var expectedSynonyms2 = new List<string> { "content", "joyful", "happy" };
        
        Assert.That(_synonymsStorage.GetSynonyms(searchWord1), Is.EquivalentTo(expectedSynonyms1));
        Assert.That(_synonymsStorage.GetSynonyms(searchWord2), Is.EquivalentTo(expectedSynonyms2));
    }
}
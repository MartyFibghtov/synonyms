using synonyms_project.Core;

namespace Tests;

[TestFixture]
public class WordProcessingTests
{   
    // Test that it trims space symbols 
    [Test]
    public void TestTrimsWord()
    {
        // Arrange
        var word = "  \n  happy\t\t";
        
        // Assert
        var expectedWord = "happy";  
        
        Assert.That(WordProcessing.Normalize(word), Is.EqualTo(expectedWord));
    }
    
    // Test that it converts string to lowercase
    [Test]
    public void TestToLowerCaseWord()
    {
        // Arrange
        var word = "  \n  HaPPy\t\t";
        
        // Assert
        var expectedWord = "happy";
        
        Assert.That(WordProcessing.Normalize(word), Is.EqualTo(expectedWord));
    }
    
    // Test non english letters
    [Test]
    public void TestRussianLetters()
    {
        // Arrange
        var word = "\nСчАСтливЫй  ";
        
        // Assert
        var expectedWord = "счастливый";
        
        Assert.That(WordProcessing.Normalize(word), Is.EqualTo(expectedWord));
    }
    // Test thar error is thrown if symbols are forbidden
    [Test]
    public void TestExternalSymbols()
    {
        // Arrange
        var word = "ha$p;py !}$;;";
        
        // Assert
        var expectedErrorMsg = "Invalid characters in word."; 
        
        var ex = Assert.Throws<ArgumentException>(() => WordProcessing.Normalize(word));
        Assert.That(ex?.Message, Is.EqualTo(expectedErrorMsg));
    }
    
    // Test words like "self-employed" or "give up"
    [Test]
    public void TestCompoundWords()
    {
        // Arrange
        var word1 = "Self-employed";
        var word2 = "GIve up";
        
        // Assert
        var expectedWord1 = "self-employed";
        var expectedWord2 = "give up";
        Assert.That(WordProcessing.Normalize(word1), Is.EqualTo(expectedWord1));
        Assert.That(WordProcessing.Normalize(word2), Is.EqualTo(expectedWord2));
    }
    
    // Test that error is thrown if string is empty
    [Test]
    public void TestEmptyString()
    {
        // Arrange
        var word = "      \n \t\t     ";
        
        var expectedErrorMsg = "Input word cannot be null or empty."; 
        var ex = Assert.Throws<ArgumentException>(() => WordProcessing.Normalize(word));
        
        Assert.That(ex?.Message, Is.EqualTo(expectedErrorMsg));
    }
    
    // Test that error is thrown if string is null
    [Test]
    public void TestNullArg()
    {
        // Arrange
        string word = null;
        
        var expectedErrorMsg = "Input word cannot be null or empty."; 
        var ex = Assert.Throws<ArgumentException>(() => WordProcessing.Normalize(word));
        
        Assert.That(ex?.Message, Is.EqualTo(expectedErrorMsg));
    }
    
    // Test that words that start or end with "-" or space are not accepted 
    [Test]
    public void TestDashApostropheWrongPlace()
    {
        // Arrange
        string word1 = "-badword";
        string word2 = "'badword";
        
        var expectedErrorMsg = "Dash or ' can't be first or last symbol."; 
        
        var ex1 = Assert.Throws<ArgumentException>(() => WordProcessing.Normalize(word1));
        var ex2 = Assert.Throws<ArgumentException>(() => WordProcessing.Normalize(word1));
        
        Assert.That(ex1?.Message, Is.EqualTo(expectedErrorMsg));
        Assert.That(ex2?.Message, Is.EqualTo(expectedErrorMsg));
    }
    
    // Test that words with ' in middle or end are accepted 
    [Test]
    public void TestWordsWithApostrophe()
    {
        // Arrange
        string word1 = "can't";
        string word2 = "teachers'";

        Assert.That(WordProcessing.Normalize(word1), Is.EqualTo(word1));
        Assert.That(WordProcessing.Normalize(word2), Is.EqualTo(word2));
    }
}
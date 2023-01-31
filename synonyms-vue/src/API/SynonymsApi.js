import axios from 'axios';

class SynonymsAPI {
    static async createSynonyms(word, synonyms) {
        this.validateWordsSynonymsDiffer(word, synonyms)
        const response = await axios.post('http://localhost:5000/api/synonyms/create-synonyms/', {
            word,
            synonyms
        });
        return response.data;
    }
    static validateWordsSynonymsDiffer(word, synonyms)
    {
        if (word.toLowerCase().trim() === synonyms[0].toLowerCase().trim())
            throw Error("Synonyms can't match the word")
    }

    static async getSynonyms(searchedWord) {
        const response = await axios.get(
            `http://localhost:5000/api/synonyms/get-synonyms/${searchedWord}`
        );
        console.log(response)
        return response.data
    }
}

export default SynonymsAPI;
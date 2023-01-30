export const validateStringMixin = {
    methods: {
        isNotNullOrEmpty (string) {
            if (!(string && string.trim() !== ''))
            {
                throw Error("Empty word!")
            }
        },
        
        noExternalSymbols (word) {
            word = word.toLowerCase().trim();

            // Check if the word has only letters or "-" or space 
            if (!/^[\w\-'\s]+$/u.test(word)) {
                throw Error("External symbols: " + word)
            }
            
            // Check that word doesn't start with "-" or "'" ends with "-"  
            if (/^[-']|[-]$/.test(word)) {
                throw Error("External symbols: " + word)
            }
        },
        validateWord (word)
        {
            return this.isNotNullOrEmpty(word) & this.noExternalSymbols(word) 
        }
    }
}
export const validateStringMixin = {
    methods: {
        isNotNullOrEmpty (string) {
            return (string && string.trim() !== '')
        },
        
        noExternalSymbols (word) {
            word = word.toLowerCase().trim();

            // Check if the word has only letters or "-" or space 
            if (!/^[\w\-'\s]+$/u.test(word)) {
                return false
            }
            
            // Check that word doesn't start with "-" or "'" ends with "-"  
            if (/^[-']|[-]$/.test(word)) {
                return false
            }
            
            return true
        },
        validateWord (word)
        {
            return this.isNotNullOrEmpty(word) & this.noExternalSymbols(word) 
        }
    }
}
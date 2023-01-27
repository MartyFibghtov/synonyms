# synonyms-app

# Description
Synonyms search tool

Backend: ASP.NET MVC 6<br>
Frontend: Vue.js 3

# Functionality
- Add new words with synonyms
- Get multiple synonyms for a requested word
- Search is bi-directional - if "B" is a synonym to "A", then "A" is synonym to "B"
- Search is transitive     - if "B" is a synonym to "A" and "C" a synonym to "B", then "C"
- No DataBase, only RAM usage

# Assumptions
- On average every english word has around 10 synonyms.
https://www.macmillanthesaurus.com/

- The amount of search requests will be dramatically bigger then additions.

# API Documentation



<details>
 <summary><code>GET</code> <code><b>/api/get-synonyms/</b></code> <code>(returns synonyms for word)</code></summary>

##### Parameters

| name   | type     | data type | description                           |
|--------|----------|-----------|---------------------------------------|
| `word` | required | string    | Words that's synonyms should be found |

##### Response
| name       | data type    | description                                                                             |
|------------|--------------|-----------------------------------------------------------------------------------------|
| `synonyms` | List[string] | A list of synonyms for the given word.                                                  |
| `success`  | boolean      | Indicates if the operation was successful or not.                                       |
| `message`  | string       | An optional message providing additional information about the result of the operation. |

</details>

<details>
 <summary><code>POST</code> <code><b>/api/create-synonyms/</b></code> <code>(adds synonyms for word)</code></summary>

##### Parameters

| name       | type      | data type     | description            |
|------------|-----------|---------------|------------------------|
| `word`     | required  | string        | Word with new synonyms |
| `synonyms` | required  | List[string]  | New synonyms for word  |

##### Response
| nae        | data type    | description                                                                             |
|------------|--------------|-----------------------------------------------------------------------------------------|
| `success`  | boolean      | Indicates if the operation was successful or not.                                       |
| `message`  | string       | An optional message providing additional information about the result of the operation. |

</details>

***

# Data Structure

All synonymic groups are transitive -> they can be grouped in sets of words, where each word is synonym to others

`HashSet<String> SynonymsGroups` <br>
HashSet pros:
- union with new synonyms in O(n)
- takes less memory
- no duplicates

___

To search for synonyms during request fast we need a hash-table: <br>
`Dictionary<string, HashSet<string>> SynonymsStorage` <br>

Dictionary allows:
- search for a requested word in O(1)

### Space complexity

If N is total number of stored synonyms then: <br>
Space complexity of such approach is O(2N) ~ O(N)

___

### Time complexity
#### Synonyms search operation
Search for a synonyms will be **O(1)** due to Dictionary usage

#### Synonyms add operation
Worst case: 
- there are already N synonyms groups that have M words
- new X synonyms join previously not joined words


O(N * M) ~ O(N^2) to join all current synonyms groups in one
O(X + M) to add synonyms to `SynonymsGroup` <br>
O(N) to create keys for new words in `SynonymsStorage` <br>

So the worst case will be **O(N^2)** <br>

That is not much because there are only 10 synonyms for a word. 

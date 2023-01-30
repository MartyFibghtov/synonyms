<template>
  <div class="synonyms-add-container">
    
    <form class="form" @submit.prevent="createSynonyms">
      <input type="text" v-model="word" placeholder="Enter word">
      <input type="text" v-model="synonyms" placeholder="Enter synonyms (comma separated)">
      <button type="submit">Submit</button>
    </form>
  </div>
</template>

<script>
import axios from 'axios';
import {validateStringMixin} from "@/mixins/validateStringMixin";

import {toast} from 'vue3-toastify';
import 'vue3-toastify/dist/index.css';
export default {
  name: "SynonymsAddComponent",
  components: {},
  data() {
    return {
      word: '',
      synonyms: ''
    };
  },
  methods: {
    async createSynonyms() {
      try {
        let synonyms = this.synonyms.split(',')
        let word = this.word
        this.validateInput(word, synonyms)
        
        const response = await axios.post('http://localhost:5000/api/synonyms/create-synonyms/', {
          word: this.word,
          synonyms: this.synonyms.split(',')
        });
        if (response.data.success) {
          this.word = '';
          this.synonyms = '';
          toast.success(response.data.message);
        } else {
          toast.error(response.data.message);
        }
      } catch (error) {
        console.error(error);
        toast.error('An error occurred. Please try again later.');
      }
    },
    validateInput(word, synonyms) {
      validateStringMixin.methods.validateWord(word)
      for (const synonym of synonyms)
      {
        validateStringMixin.methods.validateWord(synonym)
      }
    }
  }
};
</script>

<style scoped>
.synonyms-add-container {
  width: 50%;
  margin: 2em auto;
  position: relative;
}

.form {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.form input[type="text"] {
  width: 80%;
  padding: 12px 20px;
  margin: 8px 0;
  box-sizing: border-box;
  border: 2px solid #ccc;
  border-radius: 4px;
}

.form button[type="submit"] {
  width: 20%;
  background: #2665e2;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}
</style>
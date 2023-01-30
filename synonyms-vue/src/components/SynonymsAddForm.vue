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
export default {
  name: "SynonymsAddComponent",
  data() {
    return {
      word: '',
      synonyms: ''
    };
  },
  methods: {
    async createSynonyms() {
      try {
        const response = await axios.post('http://localhost:5000/api/synonyms/create-synonyms/', {
          word: this.word,
          synonyms: this.synonyms.split(',')
        });
        if (response.data.success) {
          this.word = '';
          this.synonyms = '';
          alert(response.data.message);
        } else {
          alert(response.data.message);
        }
      } catch (error) {
        console.error(error);
        alert('An error occurred. Please try again later.');
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
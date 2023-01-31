
<template>
  <div class="synonyms-add-container d-flex flex-column align-items-center" style="margin-top: 50px">
    <form class="form w-50 d-flex flex-column align-items-left" @submit.prevent="createSynonyms">
      <h5 style="text-align: left" class="my-2">Word:</h5>
      <input type="text" class="form-control my-2 h-25" v-model="word" placeholder="Enter word">
      <h5 style="text-align: left" class="my-2">Synonyms:</h5>
      <textarea type="text" class="form-control my-2 h-50" v-model="synonyms" placeholder="Enter synonyms (comma separated)"/>
      <p v-if="showWarning" class="text-danger my-2">*Warning: Only alphabets, ' and - are accepted in input fields.</p>
      <div class="my-2 d-flex justify-content-center">
        <button class="btn btn-primary" type="submit">Submit</button>
      </div>
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
      synonyms: '',
      showWarning: false
    };
  },
  methods: {
    async createSynonyms() {
      try {
        let synonyms = this.synonyms.split(',')
        let word = this.word
        this.validateInput(word, synonyms)
        
        const response = await axios.post('/api/synonyms/create-synonyms/', {
          word: this.word,
          synonyms: this.synonyms.split(',')
        });
        if (response.data.success) {
          this.word = '';
          this.synonyms = '';
          toast.success(response.data.message);
          this.showWarning = true
        } else {
          toast.error(response.data.message);
        }
      } catch (error) {
        console.error(error);
        toast.error(error.message);
        this.showWarning = true
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

</style>
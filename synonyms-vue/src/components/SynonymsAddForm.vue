<template>
  <div class="synonyms-add-container d-flex flex-column align-items-center">
    <form class="form w-50 d-flex flex-column align-items-left" @submit.prevent="createSynonyms">
      <h5 class="my-2 word-label">Word:</h5>
      <input type="text" class="form-control my-2 h-25 word-input" v-model="word" placeholder="Enter word">
      <h5 class="my-2 synonyms-label">Synonyms:</h5>
      <textarea type="text" class="form-control my-2 h-50 synonyms-input" v-model="synonyms" placeholder="Enter synonyms (comma separated)"/>
      <p v-if="showWarning" class="text-danger my-2 warning-text">*Warning: Only alphabets, ' and - are accepted in input fields.</p>
      <div class="my-2 d-flex justify-content-center">
        <button class="btn btn-primary submit-button" type="submit">Submit</button>
      </div>
    </form>
  </div>
</template>

<script>
import {validateStringMixin} from "@/mixins/validateStringMixin";

import {toast} from 'vue3-toastify';
import 'vue3-toastify/dist/index.css';
import SynonymsAPI from "@/API/SynonymsApi";
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
        
        const response =  await SynonymsAPI.createSynonyms(word, synonyms);
        
        if (response.success) {
          this.word = '';
          this.synonyms = '';
          toast.success(response.message);
          this.showWarning = false
        } else {
          toast.error(response.message);
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
  .word-label {
    text-align: left;
  }
  
  .synonyms-label {
    text-align: left;
  }
  
  .warning-text {
    text-align: left;
  }
</style>
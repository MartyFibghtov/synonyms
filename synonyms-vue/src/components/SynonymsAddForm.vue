
  <template>
    <div class="synonyms-add-container d-flex flex-column align-items-center" style="margin-top: 50px">
      <form class="form w-50 d-flex flex-column align-items-center" @submit.prevent="createSynonyms">
        <input type="text" class="form-control my-2 h-25" v-model="word" placeholder="Enter word">
        <textarea type="text" class="form-control my-2 h-50" v-model="synonyms" placeholder="Enter synonyms (comma separated)"/>
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

</style>
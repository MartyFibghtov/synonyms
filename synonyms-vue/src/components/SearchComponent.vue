<template>
  <main>
    <div class="search-container">
      <form @submit.prevent="redirectToPage">
        <input type="text" placeholder="Search for synonyms..." v-model="searchWord">
        <button type="submit">Search</button>
      </form>
      <h1 style="color: red">{{errorMessage}}</h1>
    </div>
  </main>
</template>

<script>
import {validateStringMixin} from "@/mixins/validateStringMixin";
import {toast} from "vue3-toastify";

export default {
  name: "SearchComponent",
  
  data() {
    return {
      searchWord: "",
      errorMessage: "",
    };
  },
  
  methods: {
    redirectToPage() {
      try {
        let searchWord = this.searchWord
        validateStringMixin.methods.validateWord(searchWord)
        this.$router.push({ path: "/search/" + searchWord });
        // Reset search bar when search is done 
        this.searchWord = ""
        this.errorMessage = ""
      } catch (error)
      {
        toast.error(error.message)
      }
      
    }
  }
};
</script>

<style scoped>
  .search-container {
    width: 50%;
    margin: 2em auto;
    position: relative;
  }
  form {
    display: flex;
    align-items: center;
    justify-content: center;
  }
  .search-container {
    width: 50%;
    margin: 2em auto;
  }

  form {
    display: flex;
    align-items: center;
    justify-content: center;
  }

  input[type="text"] {
    width: 80%;
    padding: 12px 20px;
    margin: 8px 0;
    box-sizing: border-box;
    border: 2px solid #ccc;
    border-radius: 4px;
  }

  button[type="submit"] {
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
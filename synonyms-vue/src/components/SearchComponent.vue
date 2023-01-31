<template>
  <main>
    <div class="d-flex align-items-center flex-column" style="margin-top: 30px">
      <form class="w-75" @submit.prevent="redirectToPage">
        <div class="form-group d-flex">
          <input class="form-control flex-grow-1" type="text" placeholder="Search for synonyms..." v-model="searchWord">
          <button class="btn btn-primary ml-2" type="submit">Search</button>
        </div>
      </form>
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
      } catch (error)
      {
        toast.error(error.message)
      }
      
    }
  }
};
</script>

<style scoped>

</style>
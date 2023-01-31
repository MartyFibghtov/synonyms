<template>
    <form role="search">
      <input type="search" class="form-control" placeholder="Search..." aria-label="Search">
    </form>
</template>

<!--<form class="col-12 col-lg-auto mb-3 mb-lg-0 me-lg-3" role="search">-->
<!--<input type="search" class="form-control" placeholder="Search..." aria-label="Search">-->
<!--</form>-->

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
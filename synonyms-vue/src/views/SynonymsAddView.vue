<template>
  <div>
    <div class="my-5" style="max-width: 500px; margin: auto; padding: 20px">
      <h2 class="text-center text-primary">Place to add new synonyms</h2>
      <p class="text-center">Here you can add new synonyms. Enter the word you want to add synonyms to and list its synonyms separaed with comma</p>
      
    </div>
    <SynonymsAddComponent></SynonymsAddComponent>
  </div>
</template>

<script>
import SynonymsAddComponent from "@/components/SynonymsAddForm.vue";

export default {
  name: "SynonymsAddView", 
  components: {SynonymsAddComponent},
  // data() {
  //   return {
  //    
  //   };
  // },
}
</script>

<style scoped>

</style>
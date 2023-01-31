<template>
  <div>
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
SynonymsAddComponent {
  margin-left: auto;
  margin-right: auto;
  text-align: center;
  align-content: center;
  font-family: Arial, sans-serif;
  position: fixed;
}
</style>
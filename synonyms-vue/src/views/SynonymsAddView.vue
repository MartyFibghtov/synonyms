<template>
  <div>
    <HeaderComponent></HeaderComponent>
    <search-component></search-component>
    <SynonymsAddComponent></SynonymsAddComponent>
  </div>
</template>

<script>
import HeaderComponent from "@/components/HeaderComponent.vue";
import SynonymsAddComponent from "@/components/SynonymsAddForm.vue";
import SearchComponent from "@/components/SearchComponent.vue";

export default {
  name: "SynonymsAddView", 
  components: {SearchComponent, SynonymsAddComponent, HeaderComponent},
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
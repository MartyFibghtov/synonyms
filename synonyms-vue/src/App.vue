<template>
  <div id="app">
    <HeaderComponent></HeaderComponent>
    <router-view style="min-height: 800px"></router-view>
    <FooterComponent></FooterComponent>
  </div>
  
</template>

<style>
#app {
  height: 100vh;
}
body {
  margin: 0; /* prevents scrollbars */
}
</style>
<script setup>
// import HeaderComponent from "@/components/HeaderComponent.vue";
// import FooterComponent from "@/components/FooterComponent.vue";
import HeaderComponent from "@/components/HeaderComponent.vue";
import FooterComponent from "@/components/FooterComponent.vue";
</script>
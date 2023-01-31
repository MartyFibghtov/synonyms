<template>
  <div id="app">
    <HeaderComponent style="height: 15%"></HeaderComponent>
    <router-view></router-view>
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
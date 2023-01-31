<template>
  <div id="app">
    <header-component></header-component>
    <router-view/>
    <footer-component></footer-component>
  </div>
</template>

<style>

</style>
<script setup>
import HeaderComponent from "@/components/HeaderComponent.vue";
import FooterComponent from "@/components/FooterComponent.vue";
</script>
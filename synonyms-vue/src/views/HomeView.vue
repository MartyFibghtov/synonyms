<template>
  2
<!--  <Header />-->
<!--  <Search style="margin-top: 200px"/>-->
<!--  <Footer />-->
</template>

<script>
import Header from "@/components/Header.vue";
import Search from "@/components/Search.vue";
import Footer from "@/components/Footer.vue";
export default {
  name: 'HomeView',
  components: {Search, Header, Footer},
}

</script>

<style>
body {
  color: #242424;
  margin: 0;
}
</style>
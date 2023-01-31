<template>
  <HeaderComponent />
  <SearchComponent style="margin-top: 200px"/>
<!--  <FooterComponent />-->
</template>

<script>
import HeaderComponent from "@/components/HeaderComponent.vue";
import SearchComponent from "@/components/SearchComponent.vue";
// import FooterComponent from "@/components/FooterComponent.vue";
export default {
  name: 'HomeView',
  components: {SearchComponent, HeaderComponent, },
  // components: {SearchComponent, HeaderComponent, FooterComponent},
}

</script>

<style>
body {
  color: #242424;
  margin: 0;
}
</style>
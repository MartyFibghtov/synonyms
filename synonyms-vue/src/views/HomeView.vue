<template>
  <div>
    <SearchComponent />
    <AppDescription ></AppDescription>
  </div>
</template>

<script>
// import SearchComponent from "@/components/SearchComponent.vue";
import AppDescription from "@/components/AppDescription.vue";
import SearchComponent from "@/components/SearchComponent.vue";

export default {
  name: 'HomeView',
  components: {SearchComponent, AppDescription,},
}

</script>

<style>
body {
  color: #242424;
  margin: 0;
}
</style>
<template>
  <h2>You were redirected to {{ searchedWord }} page</h2>
  <ul>
    <li v-for="synonym in synonyms">{{ synonym }}</li>
  </ul>
</template>

<script>

import axios from "axios";
export default {
  name: "WordSynonymsView.vue",
  data() {
    return {
      synonyms: []
    };
  },
  computed: {
    searchedWord() {
      return (this.$route.params.word)
    }
  },
  mounted() {
    this.getSynonyms();
  },
  methods: {
    async getSynonyms() {
      try {
        const response = await axios.get(
            `/api/synonyms/get-synonyms/${this.searchedWord}`
        );
        this.synonyms = response.data;
      } catch (error) {
        console.error(error);
      }
    }
  }
}
</script>

<style scoped>

</style>
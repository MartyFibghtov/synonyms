<template>
  <div>
    <SearchComponent></SearchComponent>
    <div class="search-result-and-word" style="width: 75%">
      <h1 class="searched-word display-3" style="text-align: left; padding: 30px">{{ searchedWord }}</h1>
      <SynonymList :synonyms="synonyms"></SynonymList>
    </div>
  </div>
</template>

<script>

import SearchComponent from "@/components/SearchComponent.vue";
import SynonymList from "@/components/SynonymList.vue";
import SynonymsAPI from "@/API/SynonymsApi";
import {toast} from "vue3-toastify";

export default {
  name: "WordSynonymsView.vue",
  components: {SearchComponent, SynonymList},
  data() {
    return {
      synonyms: []
    };
  },
  computed: {
    searchedWord() {
      return (this.$route.params.word)
    },
  },
  watch: {
    searchedWord: {
      handler: 'getSynonyms',
      immediate: true
    }
  },
  methods: {
    async getSynonyms() {
      try {
        this.synonyms = await SynonymsAPI.getSynonyms(this.searchedWord);
      } catch (error) {
        toast.error(error.message);
      }
    }
  }
}
</script>

<style scoped>
.search-result-and-word {
  margin-left: auto;
  margin-right: auto;
  text-align: center;
  font-family: Arial, sans-serif;
}

h2 {
  font-size: 2em;
  font-weight: bold;
  margin-top: 1em;
  margin-bottom: 1em;
}

.synonym-list li {
  background-color: lightgray;
  padding: 0.5em 1em;
  margin: 0.5em;
  border-radius: 5px;
}

</style>
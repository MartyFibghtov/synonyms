<template>
  <div class="search-result">
    <div v-if="synonyms.success" class="found-synonyms-list">
      <h1>Synonyms:</h1>
      <div v-for="synonym in synonyms.synonyms" v-bind:key="synonym.id">
        <ul>
          <li>{{synonym}}</li>
        </ul>
      </div>
    </div>
    <div v-else class="not-found-message">
      <h1>{{synonyms.message}}</h1>
    </div>
  </div>
</template>

<script>
export default {
  name: "SynonymList.vue",
  props: ['synonyms']
}
</script>

<style scoped>
* {
  font-family: "Helvetica Neue",serif;
}
.not-found-message {
  align-content: center;
  text-align: center;
}
.search-result {
  display: flex;
  width: 50%;
  justify-content: center;
  align-items: center;
}
</style>
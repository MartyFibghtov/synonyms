<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <div v-if="synonyms.success" class="found-synonyms-list">
          <h1 class="synonyms-title border-bottom">Synonyms:</h1>
          <div class="synonyms-list" v-for="synonym in synonyms.synonyms" v-bind:key="synonym.id">
            <ul class="list-group list-group-flush">
              <li class="list-group-item">{{synonym}}</li>
            </ul>
          </div>
        </div>
        <div v-else-if="synonyms.hasOwnProperty('success')" class="not-found-message text-center">
          <h1 class="not-found-title">Word not found :(</h1>
          <img class="word-not-found-img" src="@/assets/img/word_not_found.jpeg" alt="word not found">
        </div>
      </div>
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
.synonyms-title {
  text-align: left;
  margin-top: 1rem;
}

.synonyms-list {
  text-align: left;
}

.not-found-title {
  margin-top: 1rem;
}

.word-not-found-img {
  width: 100%;
}
</style>
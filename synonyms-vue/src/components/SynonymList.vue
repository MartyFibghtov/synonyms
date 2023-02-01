<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <div v-if="synonyms.success" class="found-synonyms-list">
          <h1 class="my-3 border-bottom" style="text-align: left">Synonyms:</h1>
          <div class="" style="text-align: left" v-for="synonym in synonyms.synonyms" v-bind:key="synonym.id">
            <ul class="list-group list-group-flush">
              <li class="list-group-item" style="text-align: left">{{synonym}}</li>
            </ul>
          </div>
        </div>
        <div v-else-if="synonyms.hasOwnProperty('success')" class="not-found-message text-center">
          <h1 class="my-3">Word not found :(</h1>
          <img style="width: 100%" src="@/assets/img/word_not_found.jpeg" alt="word not found">
          
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

</style>
<template>
  <div class="d-flex flex-column align-items-center p-1" style="max-width: 500px">
    <div class="col-md-4 text-center">
      <h2 class="text-center text-primary">About the app</h2>
      <p class="text-center">Reeinvent: Synonyms is a powerful and easy-to-use tool that helps you find the perfect synonyms for any word. Whether you're a writer, a student, or just someone looking for a better way to express yourself, our app has got you covered.</p>
    </div>
    <div class="col-md-8" style="max-width: 500px">
      <div class="flex-column justify-content-center">
        <h3 class="text-center text-primary my-5">Some example synonyms:</h3>
        <ul class="list-group w-50">
          <li class="list-group-item">Happy - Joyful, Elated, Pleased</li>
          <li class="list-group-item">Big - Large, Huge, Giant</li>
          <li class="list-group-item">Smart - Intelligent, Wise, Bright</li>
        </ul>
      </div>
    </div>
    
    
  </div>
</template>

<script>
export default {
name: "AppDescription"
}
</script>

<style scoped>

.text-primary {
  color: #007bff !important;
}

</style>
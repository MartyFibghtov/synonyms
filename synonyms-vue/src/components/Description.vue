<template>
  <div class="app-description">
    <h2>About the app</h2>
    <p>Reeinvent: Synonyms is a powerful and easy-to-use tool that helps you find the perfect synonyms for any word. Whether you're a writer, a student, or just someone looking for a better way to express yourself, our app has got you covered.</p>
  </div>
  <div class="filler-content">
    <h3>Some example synonyms:</h3>
    <ul>
      <li>Happy - Joyful, Elated, Pleased</li>
      <li>Big - Large, Huge, Giant</li>
      <li>Smart - Intelligent, Wise, Bright</li>
    </ul>
  </div>
</template>

<script>
export default {
name: "Description"
}
</script>

<style scoped>

.app-description {
  width: 50%;
  margin: 2em auto;
  text-align: center;
}

.app-description h2 {
  margin-bottom: 1em;
  color: #1E90FF;
}

.filler-content {
  width: 50%;
  margin: 2em auto;
  text-align: center;
}

.filler-content h3 {
  margin-bottom: 1em;
  color: #1E90FF;
}

.filler-content ul {
  list-style-type: none;
  color: #333;
}

</style>
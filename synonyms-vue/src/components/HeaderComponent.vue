<template>
  <header>
  <h1>Reinvent: Synonyms</h1>
  <nav>
    <a href="/" class="nav-link">Home</a>
    <a href="/add-synonyms/" class="nav-link">Add Synonyms</a>
  </nav>
  </header>
</template>

<script>
export default {
name: "HeaderComponent"
}
</script>

<style scoped>
  header {
    width: 100%;
    background: #2665e2;
    color: white;
    text-align: center;
    position: relative;
    top: 0;
  }

  header h1 {
    margin: 0;
  }
</style>
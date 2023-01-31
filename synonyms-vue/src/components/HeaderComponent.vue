<template>
  <header class="border-bottom" >
    <div class="d-flex align-items-center justify-content-center flex-column">
      <router-link :to="{ path: '/' }" class="d-flex align-items-center mb-2 text-dark text-decoration-none">
        <img class="bi me-2" width=200 src="../assets/logos/reeinvent.png" alt="Reeinvent">
      </router-link>
      <ul class="nav justify-content-center">
        <li>
          <router-link :to="{ path: '/' }" class="nav-link px-2 link-dark" :active-class="'active-link'">Search</router-link>
        </li>
        <li>
          <router-link :to="{ path: '/add-synonyms' }" class="nav-link px-2 link-dark" :active-class="'active-link'">Add synonyms</router-link>
        </li>
        <li>
          <router-link :to="{ path: '/about-us' }" class="nav-link px-2 link-dark" :active-class="'active-link'">About Me</router-link>
        </li>
      </ul>
    </div>
  </header>
</template>

<script>
export default {
  name: "HeaderComponent",
}
</script>

<style scoped>
.active-link {
  font-weight: bold;
}

</style>
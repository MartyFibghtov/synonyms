<!--<template>-->
<!--  <footer>-->
<!--    <div class="contact-section">-->
<!--      <div class="contact-details">-->

<!--        <h3>Contact Me</h3>-->
<!--        <p style="text-align: left"><img src="../assets/icons/email.svg" alt="">artemnurmatov@gmail.com</p>-->
<!--        <p style="text-align: left"><img src="../assets/icons/phone.svg" alt="">+46 79-358 86 56</p>-->
<!--      </div>-->
<!--      <div class="follow-me">-->
<!--        <h3>Follow Me</h3>-->
<!--        <div class="social-links">-->
<!--          <a href="https://github.com/martyfightov" target="_blank">-->
<!--            <img src="../assets/logos/github.svg" alt="Github">-->
<!--          </a>-->
<!--          <a href="https://www.linkedin.com/in/artemnurmatov" target="_blank">-->
<!--            <img src="../assets/logos/linkedin.svg" alt="LinkedIn">-->
<!--          </a>-->
<!--        </div>-->
<!--      </div>-->
<!--      <div class="about-me">-->
<!--        <h3>About Me</h3>-->
<!--        <h1>Artem Nurmatov</h1>-->
<!--        <p>Full-stack software developer</p>-->
<!--      </div>-->
<!--    </div>-->
<!--  </footer>-->
<!--</template>-->


<template>
  <div class="container">
    <footer class="row row-cols-1 row-cols-md-3 py-5 my-5 border-top fixed-bottom d-flex justify-content-center">
        <div class="col mb-3">
          <h5>Contact Me</h5>
          <ul class="nav flex-column">
            <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">+46 79-358 86 56</a></li>
            <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">artemnurmatov@gmail.com</a></li>
          </ul>
        </div>
  
        <div class="col mb-3">
          <h5>Follow me</h5>
          <ul class="nav flex-column">
            <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Linkedin</a></li>
            <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Github</a></li>
          </ul>
        </div>
  
        <div class="col mb-3">
          <h5>Artem Nurmatov</h5>
          <ul class="nav flex-column">
            <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Full-stack software developer</a></li>
          </ul>
        </div>
    </footer>
  </div>
</template>

<script>
export default {
  name: "FooterComponent"
}
</script>

<style scoped>

</style>
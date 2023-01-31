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
  <footer  style="background: #363636; color: white" class="w-100 border-top d-flex justify-content-center align-items-center">
    <div class="w-100 row row-cols-1 row-cols-md-3 d-flex" style="max-width: 1000px;">
      <div class="col mb-3 d-flex justify-content-center align-items-center flex-column">
        <h5>Contact Me</h5>
        <ul class="nav flex-column">
          <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">+46 79-358 86 56</a></li>
          <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">artemnurmatov@gmail.com</a></li>
        </ul>
      </div>

      <div class="col mb-3 d-flex justify-content-center align-items-center flex-column">
        <h5>Follow me</h5>
        <div class="row">
          <div class="col-6 d-flex justify-content-center">
            <a href="https://github.com/martyfibghtov" target="_blank">
              <img style="width: 30px" src="../assets/logos/github.svg" alt="Github">
            </a>
          </div>
          <div class="col-6 d-flex justify-content-center">
            <a href="https://www.linkedin.com/in/artemnurmatov" target="_blank">
              <img style="width: 30px" src="../assets/logos/linkedin.svg" alt="LinkedIn">
            </a>
          </div>
        </div>
      </div>

      <div class="col mb-3 d-flex justify-content-center align-items-center flex-column">
        <h5>Artem Nurmatov</h5>
        <ul class="nav flex-column">
          <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Full-stack software developer</a></li>
        </ul>
      </div>
    </div>
  </footer>
  
  
  
  
</template>

<script>
export default {
  name: "FooterComponent"
}
</script>

<style scoped>

</style>
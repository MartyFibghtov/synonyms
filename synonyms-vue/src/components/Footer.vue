<template>
  <footer>
    <div class="contact-section">
      <div class="contact-details">

        <h3>Contact Me</h3>
        <p style="text-align: left"><img src="../assets/icons/email.svg" alt="">artemnurmatov@gmail.com</p>
        <p style="text-align: left"><img src="../assets/icons/phone.svg" alt="">+46 79-358 86 56</p>
      </div>
      <div class="follow-me">
        <h3>Follow Me</h3>
        <div class="social-links">
          <a href="https://github.com/martyfightov" target="_blank">
            <img src="../assets/logos/github.svg" alt="Github">
          </a>
          <a href="https://www.linkedin.com/in/artemnurmatov" target="_blank">
            <img src="../assets/logos/linkedin.svg" alt="LinkedIn">
          </a>
        </div>
      </div>
      <div class="about-me">
        <h3>About Me</h3>
        <h1>Artem Nurmatov</h1>
        <p>Full-stack software developer</p>
      </div>
    </div>
  </footer>
</template>

<script>
export default {
  name: "Footer"
}
</script>

<style scoped>

@media (max-width: 767px) {
  .contact-section {
    flex-direction: column;
  }
}
footer {
  height: calc(100vh - 600px);
}

@media (max-width: 767px) {
  footer {
    height: auto;
  }
}
footer {
  display: flex;
  width: 100%;
  justify-content: center;
  align-items: center;
  background-color: gray;
  position: absolute;
  bottom: 0;
}

.contact-section {
  display: flex;
  justify-content: space-between;
  width: 80%;
  flex-wrap: wrap;
}

.contact-details,
.follow-me,
.about-me {
  width: 30%;
  text-align: center;
}


* {
  font-family: "Helvetica Neue",serif;
  color: white;
}

.social-links {
  display: flex;
  justify-content: center;
}

.social-links a {
  margin: 0 20px;
}
.contact-details img {
  height: 15px;
  margin-right: 10px;
}
img {
  height: 30px;
}
</style>
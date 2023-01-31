import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/search/:word',
    component: () => import('@/views/WordSynonymsView.vue')
  },
  {
    path: '/add-synonyms/',
    component: () => import('@/views/SynonymsAddView.vue')
  },
  {
    path: '/about-us/',
    component: () => import('@/views/AboutUsView.vue')
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router

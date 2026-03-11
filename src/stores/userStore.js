import { defineStore } from 'pinia'
import { ref, computed } from 'vue'
import { users } from '../data/mockData.js'

export const useUserStore = defineStore('user', () => {
  const currentUser = ref(users[0])
  const allUsers = ref(users)
  const loginError = ref('')

  function login(email, password) {
    const match = users.find(u => u.email === email && u.password === password)
    if (match) {
      currentUser.value = match
      loginError.value = ''
      return true
    } else {
      loginError.value = 'Invalid email or password'
      return false
    }
  }

  function switchUser(userId) {
    const user = users.find(u => u.id === userId)
    if (user) currentUser.value = user
  }

  return { currentUser, allUsers, loginError, login, switchUser }
})

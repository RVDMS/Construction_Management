import { defineStore } from 'pinia'
import { ref, computed } from 'vue'
import { users } from '../data/mockData.js'

export const useUserStore = defineStore('user', () => {
  const currentUser = ref(users[0])
  const allUsers = ref(users)

  function switchUser(userId) {
    const user = users.find(u => u.id === userId)
    if (user) currentUser.value = user
  }

  return { currentUser, allUsers, switchUser }
})

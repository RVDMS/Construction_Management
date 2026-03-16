// src/services/api.js
import axios from 'axios';

const API_URL = 'https://localhost:7026/api';

export const login = async (username, password) => {
  try {
    const response = await axios.post(`${API_URL}/Auth/login`, { username, password });
    return response.data;
  } catch (err) {
    throw err.response?.data || err.message;
  }
};
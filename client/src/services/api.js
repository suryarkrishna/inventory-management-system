import axios from 'axios';

const API_BASE = 'http://localhost:5203/api'; // Change if deployed

export const getProducts = () => axios.get(`${API_BASE}/Products`);
export const getCategories = () => axios.get(`${API_BASE}/Categories`);

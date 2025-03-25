import axios from 'axios';

const api = axios.create({
    baseURL: 'https://localhost:5001/api', // Porta correta do backend
});

// Funções para interagir com a API de Feedbacks
export const createFeedback = async (feedback) => {
    const response = await api.post('/feedbacks', feedback);
    return response.data;
};

export const getFeedbacks = async () => {
    const response = await api.get('/feedbacks');
    return response.data;
};

export const deleteFeedback = async (id) => {
    await api.delete(`/feedbacks/${id}`);
};

// Funções para interagir com a API de PDIs
export const createPdi = async (pdi) => {
    const response = await api.post('/pdis', pdi);
    return response.data;
};

export const getPdis = async () => {
    const response = await api.get('/pdis');
    return response.data;
};

export const updatePdi = async (id, pdi) => {
    const response = await api.put(`/pdis/${id}`, pdi);
    return response.data;
};

// Funções para interagir com a API de Usuários
export const createUser = async (user) => {
    const response = await api.post('/users', user);
    return response.data;
};

export const getUsers = async () => {
    const response = await api.get('/users');
    return response.data;
};

export const deleteUser = async (id) => {
    await api.delete(`/users/${id}`);
};
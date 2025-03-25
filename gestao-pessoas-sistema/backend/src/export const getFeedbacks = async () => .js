export const getFeedbacks = async () => {
    try {
        const response = await api.get('/feedback');
        return response.data;
    } catch (error) {
        console.error('Erro ao buscar feedbacks:', error);
        throw error;
    }
};
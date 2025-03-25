import React, { useEffect, useState } from 'react';
import { getFeedbacks } from '../services/api';

const Feedbacks: React.FC = () => {
    const [feedbacks, setFeedbacks] = useState([]);

    useEffect(() => {
        const fetchFeedbacks = async () => {
            const data = await getFeedbacks();
            setFeedbacks(data);
        };

        fetchFeedbacks();
    }, []);

    return (
        <div>
            <h1>Feedbacks</h1>
            <ul>
                {feedbacks.map(feedback => (
                    <li key={feedback.id}>
                        <p><strong>Comentário:</strong> {feedback.comment}</p>
                        <p><strong>Data:</strong> {new Date(feedback.date).toLocaleDateString()}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default Feedbacks;
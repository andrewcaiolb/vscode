import React, { useEffect, useState } from 'react';
import { getPdis } from '../services/api';

const Pdis: React.FC = () => {
    const [pdis, setPdis] = useState([]);

    useEffect(() => {
        const fetchPdis = async () => {
            const data = await getPdis();
            setPdis(data);
        };

        fetchPdis();
    }, []);

    return (
        <div>
            <h1>Lista de PDIs</h1>
            <ul>
                {pdis.map(pdi => (
                    <li key={pdi.id}>
                        <h2>Objetivos: {pdi.goals}</h2>
                        <p>Plano de Desenvolvimento: {pdi.developmentPlan}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default Pdis;
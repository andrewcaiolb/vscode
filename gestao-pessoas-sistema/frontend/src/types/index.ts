export interface Feedback {
    id: number;
    content: string;
    userId: number;
    createdAt: Date;
}

export interface PDI {
    id: number;
    goal: string;
    actions: string;
    deadline: Date;
    userId: number;
}
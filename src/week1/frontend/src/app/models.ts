// {
//     "id": "0f16724a-f1c5-48a1-85cc-7309736c6183",
//     "description": "Make Tacos a37422c1-f664-48d5-bf27-2cd33e5df684",
//     "completed": false,
//     "createdOn": "2025-02-11T19:45:45.0539768+00:00",
//     "completedOn": null
// }

export type TodoListItem = {
  id: string;
  description: string;
  completed: boolean;
  createdOn: string;
  completedOn?: string;
};

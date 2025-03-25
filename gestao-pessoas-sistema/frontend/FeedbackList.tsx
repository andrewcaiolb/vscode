import { DataGrid } from '@mui/x-data-grid';

export const FeedbackList = () => {
  return (
    <DataGrid
      rows={feedbacks}
      columns={columns}
      pageSize={5}
      autoHeight
      disableSelectionOnClick
    />
  );
};
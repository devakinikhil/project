namespace SimaxCrm.Model.ResponseModel
{
    public class DashboardBoxesModel
    {
        public int NewLead { get; set; }
        public int FollowUp { get; set; }
        public int Postpone { get; set; }
        public int Converted { get; set; }
        public int Closed { get; set; }
        public int Reopen { get; set; }
        public int MissedFollowUp { get; set; }
        public int AllLead { get; set; }
        public int InvoicePending { get; set; }
        public int InvoiceApproved { get; set; }
        public int InvoiceRejected { get; set; }
        public DashboardChartResponseModel LeadsChart { get; set; }
        public DashboardChartResponseModel SalesChart { get; set; }
    }

    public class DashboardChartResponseModel
    {
        public string[] Label { get; set; }
        public int[] Data { get; set; }
    }
}
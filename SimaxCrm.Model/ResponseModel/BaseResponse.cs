namespace SimaxCrm.Model.ResponseModel
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Response { get; set; }
        public T Data { get; set; }
    }
}
namespace LojaLanche.Data.Model
{
    public class ResponseCommon<T>
    {
        public int StatusCode { get; private set; }
        public bool Success {  get; private set; }
        public string Message { get; private set; }
        public string? Error { get; private set; }
        public T Data { get; private set; }

        private ResponseCommon(int statusCode, string message, T data, string? error = null, bool success = false)
        {
            StatusCode = statusCode;
            Message = message;
            Error = error;
            Data = data;
            Success = success;
        }

        public static ResponseCommon<T> Sucesso(T data, string message = "Success")
        {
            return new ResponseCommon<T>(200, message, data, success: true);
        }

        public static ResponseCommon<T> Falha(string message, int statusCode = 500, string? error = null)
        {
            return new ResponseCommon<T>(statusCode, message, default!, error);
        }
    }

}

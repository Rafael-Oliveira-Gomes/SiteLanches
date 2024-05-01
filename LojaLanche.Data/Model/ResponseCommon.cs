namespace LojaLanche.Data.Model
{
    public class ResponseCommon<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string? Error { get; set; }
        public T Data { get; set; }

        public ResponseCommon(int statusCode, string message, T data, string? error = null)
        {
            StatusCode = statusCode;
            Message = message;
            Error = error;
            Data = data;
        }

        public static ResponseCommon<T> Sucesso(T data, string message = "Success")
        {
            return new ResponseCommon<T>(200, message, data);
        }

        public static ResponseCommon<T> Falha(string message, int statusCode = 500, string? error = null)
        {
            return new ResponseCommon<T>(statusCode, message, default!, error);
        }
    }

}

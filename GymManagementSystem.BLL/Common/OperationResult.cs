namespace GymManagementSystem.BLL.Common
{
    public class OperationResult<TCode, TData>
    {
        public TCode Code { get; }
        public TData Data { get; }

        public OperationResult(TCode code, TData data = default)
        {
            Code = code;
            Data = data;
        }
    }
}
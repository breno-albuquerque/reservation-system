namespace RerservationSystem.Core.Shared.Results
{
    public class InsertResult
    {
        public bool Success { get; }

        public int AffectedRows { get; }

        public InsertResult(int affectedRows)
        {
            AffectedRows = affectedRows;
            Success = affectedRows == 1;
        }
    }
}

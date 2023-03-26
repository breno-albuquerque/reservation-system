namespace RerservationSystem.Core.Shared.Handlers
{
    public interface IHandler<TInput, TOutput> 
        where TInput : IInput
        where TOutput : IOutput
    {
        Task<TOutput> HandleAsync(TInput input);
    }
}

namespace RerservationSystem.Core.Shared.Handlers
{
    public interface IHandler<TInput, TOutput> 
        where TInput : IInput
        where TOutput : IOutput
    {
        Task<IOutput> HandleAsync(TInput input);
    }
}

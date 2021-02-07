namespace MassTransit.Futures
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Automatonymous;


    public interface IFutureRequest<in TRequest>
        where TRequest : class
    {
        Task Send(BehaviorContext<FutureState, TRequest> context);
    }


    public interface IFutureRequest<in TRequest, in TInput>
        where TRequest : class
    {
        Task Send(BehaviorContext<FutureState, TRequest> context, TInput input);

        Task Send(BehaviorContext<FutureState, TRequest> context, IEnumerable<TInput> inputs);
    }
}
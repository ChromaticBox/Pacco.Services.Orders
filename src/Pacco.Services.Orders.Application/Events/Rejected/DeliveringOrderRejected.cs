using System;
using Convey.CQRS.Events;

namespace Pacco.Services.Orders.Application.Events.Rejected
{
    [Contract]
    public class DeliveringOrderRejected : IRejectedEvent
    {
        public Guid Id { get; }
        public string Reason { get; }
        public string Code { get; }

        public DeliveringOrderRejected(Guid id, string reason, string code)
        {
            Id = id;
            Reason = reason;
            Code = code;
        }
    }
}
using DDD.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDD.Domain.EventHandlers
{
    public class TransitBillEventHandler :
        INotificationHandler<DistributeTaxFeeEvent>,
        INotificationHandler<DistributeDistanceFeeEvent>,
        INotificationHandler<DistributeGrossProfitEvent>
    {
        public Task Handle(DistributeTaxFeeEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(DistributeDistanceFeeEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(DistributeGrossProfitEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using DDD.Domain.Commands;
using DDD.Domain.Core.Bus;
using DDD.Domain.Core.Notifications;
using DDD.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDD.Domain.CommandHandlers
{
    public class TransitBillCommandHanlder : CommandHandler, INotificationHandler<ArriveTransitBillCommand>
    {
        private readonly IMediatorHandler Bus;

        public TransitBillCommandHanlder(IUnitOfWork uow,IMediatorHandler bus,INotificationHandler<DomainNotification> notifications ):base(uow,bus,notifications)
        {
            Bus = bus;
        }

        public Task  Handle(ArriveTransitBillCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.CompletedTask;
            }

            return Task.CompletedTask;


        }
    }
}

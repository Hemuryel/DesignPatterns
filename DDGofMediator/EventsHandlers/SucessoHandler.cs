using DDGofMediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DDGofMediator.EventsHandlers
{
    public class SucessoHandler : INotificationHandler<StudentActionNotification>
    {
        public Task Handle(StudentActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("The student {0} {1} was {2} successfully", notification.FirstName, notification.LastName, notification.Action.ToString().ToLower());
            });
        }
    }
}

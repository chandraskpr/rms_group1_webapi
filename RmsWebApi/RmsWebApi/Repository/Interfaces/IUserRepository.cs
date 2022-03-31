
using RmsWebApi.Data;

namespace RmsWebApi.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserInfoDomain>
    {
        public List<UserNotificationsDomain> GetNotifications();

        public List<UserNotificationsDomain> GetActiveNotification();

    }
}

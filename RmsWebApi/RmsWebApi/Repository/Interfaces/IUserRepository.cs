
using RmsWebApi.Data;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserInfo>
    {
        public List<UserInfoDomain> GetAll();

        public void Create(UserInfoDomain userInfo);

        public void Delete(int UserId);

        public void Update(int UserId, UserInfoDomain userInfo);
        public List<UserNotificationsDomain> GetNotifications();

        public List<UserNotificationsDomain> GetActiveNotification();

    }
}
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
        public int CreateComment(ReviewTableDomain review);

        public void EditComment(ReviewTableDomain review, int id);

        public List<ReviewTableDomain> GetComment(int userId);

    }
}
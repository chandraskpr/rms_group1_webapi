
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class UserRepository : BaseRepository<UserInfoDomain> , IUserRepository
    {

        private readonly RMSContext context;
        public UserRepository(RMSContext context)
        {   
            
            this.context = context;
        }

        public List<UserInfoDomain> SelectAll()
        {
            var records = context.UserInfo.Select(x => new UserInfoDomain()
            {   
                UserId = x.UserId,
                UserName = x.UserName,
                UserEmail = x.UserEmail,
                UserRole = x.UserRole,

            }).ToList();
            return records;
        } 

        public void Create(UserInfoDomain userInfo)
        {
            var user = new UserInfo()
            {
                UserName = userInfo.UserName,
                UserEmail = userInfo.UserEmail,
                UserRole = userInfo.UserRole,

            };

            context.UserInfo.Add(user);
            context.SaveChanges();
        }
         

        public void Delete(int UserId )
        {
            var user = context.UserInfo.Find(UserId);
            context.UserInfo.Remove(user);
            context.SaveChanges();  
        }

        public void Update(int UserId , UserInfoDomain userInfo)
        {
            var user = context.UserInfo.Find(UserId);
            if(user != null)
            {
                user.UserName = userInfo.UserName;
                user.UserEmail = userInfo.UserEmail;
                user.UserRole = userInfo.UserRole;

                context.SaveChanges();
            }
             
        }

        public List<UserNotificationsDomain> GetNotifications()
        {
            var records = context.UserNotifications.Select(x => new UserNotificationsDomain()
            {   
                NotificationId = x.NotificationId,
                UserId = x.UserId,
                NotificationDescription = x.NotificationDescription,
                CreationDate=x.CreationDate,
                NotificationState = x.NotificationState,

            }).ToList();
            return records;
        }

        public List<UserNotificationsDomain> GetActiveNotification()
        {
            var records = context.UserNotifications.Select(x => new UserNotificationsDomain()
            {
                NotificationId = x.NotificationId,
                UserId = x.UserId,
                NotificationDescription = x.NotificationDescription,
                CreationDate = x.CreationDate,
                NotificationState = x.NotificationState,

            }).Where(x => x.NotificationState == "Active").ToList();
            return records;
        }


    }






}

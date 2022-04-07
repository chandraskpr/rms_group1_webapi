using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class UserRepository : BaseRepository<UserInfo>, IUserRepository
    {


        public UserRepository(RMSContext context)
            : base(context)
        {

        }

        public List<UserInfoDomain> GetAll()
        {
            var records = base.SelectAll().Select(x => new UserInfoDomain()
            {
                UserId = x.UserId,
                UserName = x.UserName,
                UserEmail = x.UserEmail,
                UserRole = x.UserRole,

                userResumeDomains = x.UserResumes.Select(a => new UserResumeDomains()
                {
                    UserId = a.UserResumeId,
                    UserResumeId = a.UserResumeId,
                    ResumeId = a.ResumeId,
                }
                ).ToList(),

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

            foreach (var records in userInfo.userResumeDomains)
            {
                user.UserResumes.Add(new UserResume()
                {
                    UserResumeId = records.UserResumeId,
                    UserId = records.UserId,
                    ResumeId = records.ResumeId,
                }
                );
            }

            base.Create(user);

        }


        public void Delete(int UserId)
        {
            var res = this.entitySet
                .Include(x => x.UserResumes)
                .FirstOrDefault(x => x.UserId == UserId);

            if (res != null)
            {
                base.Delete(res);
            }
        }

        public void Update(int UserId, UserInfoDomain userInfo)
        {
            var user = base.SelectAll().FirstOrDefault(x => x.UserId == UserId);

            if (user != null)
            {
                user.UserName = userInfo.UserName;
                user.UserEmail = userInfo.UserEmail;
                user.UserRole = userInfo.UserRole;

                foreach (var records in userInfo.userResumeDomains)
                {
                    user.UserResumes.Add(new UserResume()
                    {
                        UserResumeId = records.UserResumeId,
                        UserId = records.UserId,
                        ResumeId = records.ResumeId,
                    }
                    );
                }

                base.Update(user);

            }

        }

        public List<UserNotificationsDomain> GetNotifications()
        {
            var records = context.UserNotifications.Select(x => new UserNotificationsDomain()
            {
                NotificationId = x.NotificationId,
                UserId = x.UserId,
                NotificationDescription = x.NotificationDescription,
                CreationDate = x.CreationDate,
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
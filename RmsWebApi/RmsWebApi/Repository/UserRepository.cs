
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
using RMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace RmsWebApi.Repository
{
    public class UserRepository : BaseRepository<UserInfo> , IUserRepository
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

                userResumeList = x.UserResumes.Select(x => new UserResumeDomain()
                {
                    UserResumeId = x.UserResumeId,
                    UserId = x.UserId,
                    ResumeId = x.ResumeId,


                }).ToList(),

                NotificationList = x.UserNotifications.Select(x => new UserNotificationsDomain()
                {
                    NotificationId = x.NotificationId,
                    UserId = x.UserId,
                    NotificationDescription = x.NotificationDescription,
                    NotificationState = x.NotificationState,
                    CreationDate = x.CreationDate,

                }).ToList(),

            }).ToList();
            return records;
        }
        public int CreateComment(ReviewTableDomain review)
        {
            var rev = new ReviewTable()
            {
                ResumeId = review.ResumeId,
                ReviewComment = review.ReviewComment,
                ReviewerId = review.ReviewerId,
               
            };
            var result = this.context.ReviewTables.Add(rev);
            this.context.SaveChanges();
            return rev.ReviewId;
        }

        public void EditComment(ReviewTableDomain review,int id)
        {
            var rev = context.ReviewTables.FirstOrDefault(x => x.ReviewId == id);
            if(rev != null)
            {
              rev.ReviewComment = review.ReviewComment;
               rev.ReviewerId = review.ReviewerId;
               
                context.ReviewTables.Update(rev);
                context.SaveChanges();
            }
            
        }

        public List<ReviewTableDomain> GetComment(int userId)
        { 
            var reviews = context.ReviewTables.Where(y =>y.ReviewerId==userId).Select(x => new ReviewTableDomain()
            {
                ReviewerId = x.ReviewerId,
                ReviewComment=x.ReviewComment,
                ReviewId=x.ReviewId,
                ResumeId=x.ResumeId,
            }).ToList();
            return reviews;
        }
        public void Create(UserInfoDomain userInfo)
        {
            var user = new UserInfo()
            {
                UserName = userInfo.UserName,
                UserEmail = userInfo.UserEmail,
                UserRole = userInfo.UserRole,

            };
            foreach (var res in userInfo.userResumeList)
            {
                user.UserResumes.Add(new UserResume()
                {
                    UserId = res.UserId,
                    ResumeId = res.ResumeId,
                    UserResumeId = res.UserResumeId
                });
            }

            foreach (var res in userInfo.NotificationList)
            {
                user.UserNotifications.Add(new UserNotification()
                {
                    UserId = res.UserId,
                    NotificationId = res.NotificationId,
                    NotificationDescription = res.NotificationDescription,
                    NotificationState = res.NotificationState,
                    CreationDate = res.CreationDate,
                });
            }
            base.Create(user);
           
        }
         

        public void Delete(int UserId )
        {
            var res = this.entitySet
                   .Include(x => x.UserNotifications)
                   .Include(x => x.UserResumes)
                   
                   .FirstOrDefault(x => x.UserId == UserId);
            if (res != null)
                base.Delete(res);
            
        }

        public void Update(int UserId , UserInfoDomain userInfo)
        {
            var user = base.SelectAll().FirstOrDefault(x => x.UserId==UserId);

            if(user != null)
            {
                user.UserName = userInfo.UserName;
                user.UserEmail = userInfo.UserEmail;
                user.UserRole = userInfo.UserRole;

                foreach (var res in userInfo.userResumeList)
                {
                    user.UserResumes.Add(new UserResume()
                    {
                        UserId = res.UserId,
                        ResumeId = res.ResumeId,
                        UserResumeId = res.UserResumeId
                    });
                }

                foreach (var res in userInfo.NotificationList)
                {
                    user.UserNotifications.Add(new UserNotification()
                    {
                        UserId = res.UserId,
                        NotificationId = res.NotificationId,
                        NotificationDescription = res.NotificationDescription,
                        NotificationState = res.NotificationState,
                        CreationDate = res.CreationDate,
                    });
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

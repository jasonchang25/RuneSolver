using RuneSolverUI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RuneSolverUI.Repository
{    
    interface ISessionRepository
    {
        public Sessions ValidateSession(Users user, string guid, Sessions currentSession);
        public void RemoveSession(Sessions currentSession);
    }

    public class SessionRepository : ISessionRepository
    {
        public SessionRepository()
        {

        }

        public Sessions ValidateSession(Users user, string guid, Sessions currentSession)
        {
            using var context = new runesolverContext();

            if (currentSession != null && context.Sessions.Find(currentSession.PkSessionId) != null)
            {
                currentSession.Expiry = DateTime.UtcNow.AddMinutes(6);
                context.SaveChanges();
                return currentSession;
            }

            var activeSessions = context.Sessions.Where(session => session.FkUserId == user.PkUserId);
            if (activeSessions.Count() >= user.SessionCount)
            {
                return null;
            }
            else
            {
                var newSession = new Sessions
                {
                    FkUserId = user.PkUserId,
                    Guid = guid,
                    Expiry = DateTime.UtcNow.AddMinutes(6)
                };
                context.Sessions.Add(newSession);
                context.SaveChanges();
                return newSession;
            }           
        }

        public void RemoveSession(Sessions currentSession)
        {
            using var context = new runesolverContext();
            if (currentSession != null && context.Sessions.Find(currentSession.PkSessionId) != null)
            {
                context.Sessions.Remove(currentSession);
                context.SaveChanges();
            }
        }
    }
}

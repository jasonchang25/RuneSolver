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
        public Sessions ValidateSession(Users user, string guid, Sessions session);
        public void RemoveSession(Sessions session);
        public void ExtendSession(Sessions session);
    }

    public class SessionRepository : ISessionRepository
    {
        public SessionRepository()
        {
            using var context = new runesolverContext();
        }

        public void ExtendSession(Sessions session)
        {
            using var context = new runesolverContext();
            session = context.Sessions.Find(session.PkSessionId);
            session.Expiry = DateTime.UtcNow.AddMinutes(6);
            context.SaveChanges();
        }

        public Sessions ValidateSession(Users user, string guid, Sessions session)
        {
            using var context = new runesolverContext();

            if (session != null && context.Sessions.Find(session.PkSessionId) != null)
            {
                session.Expiry = DateTime.UtcNow.AddMinutes(6);
                context.SaveChanges();
                return session;
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

        public void RemoveSession(Sessions session)
        {
            using var context = new runesolverContext();
            session = context.Sessions.Find(session?.PkSessionId);
            if (session != null)
            {                
                context.Sessions.Remove(session);
                context.SaveChanges();
            }
        }
    }
}

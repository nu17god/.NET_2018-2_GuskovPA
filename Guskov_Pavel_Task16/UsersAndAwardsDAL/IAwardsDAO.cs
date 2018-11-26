using System;
using System.Collections.Generic;
using System.Text;
using Entites;

namespace UsersAndAwardsDAL
{
    public interface IAwardsDAO
    {
        void AddAward(string title, string description);
        bool RemoveAward(int awardID);
        bool UpdateAward(int awardID, string title, string description);
        List<Award> GetAwards();
        Award GetAward(int awardID);
    }
}

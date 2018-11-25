using System;
using System.Collections.Generic;
using System.Text;
using Entites;

namespace UsersAndAwardsDAL
{
    public class AwardsDAO : IAwardsDAO
    {
        private int ID;
        private List<Award> awards = new List<Award>();


        public void AddAward(string title, string description)
        {
            foreach (Award award in awards)
            {
                if (award.Title == title)
                {
                    throw new Exception("award is already exist");
                }
            }

            awards.Add(new Award(ID++, title, description));
        }

        public bool RemoveAward(int awardID)
        {
            foreach (Award award in awards)
            {
                if (award.ID == awardID)
                {
                    
                    awards.Remove(award);
                    return true;
                }
            }

            throw new Exception("Remove Award Exception");
        }

        public bool UpdateAward(int awardID, string title, string description)
        {
            foreach (Award award in awards)
            {
                if (award.ID == awardID)
                {
                    award.UpdateAward(title, description);
                    return true;
                }
            }

            throw new Exception("Remove Award Exception");
        }

        public List<Award> GetAwards()
        {
            return awards;
        }

        public Award GetAward(int awardID)
        {
            foreach (Award award in awards)
            {
                if (award.ID == awardID)
                {
                    return award;
                }
            }

            throw new Exception("Get Award Exception");
        }
    }
}

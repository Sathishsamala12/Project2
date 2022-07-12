using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeadSet.HeadsetRepository
{
    public class HeadSetRepository
    {
        HeadsetEntities headsetEntities = new HeadsetEntities();

        public List<HeadsetDetail> GetHeadsetDetails()
        {
            List<HeadsetDetail> data = headsetEntities.HeadsetDetails.ToList();
            return data;
        }
        
        public bool AddHeadsetDetails(HeadsetDetail headsetDetail)
        {
            headsetEntities.HeadsetDetails.Add(headsetDetail);
            headsetEntities.SaveChanges();
            return true;
        }
    }
}
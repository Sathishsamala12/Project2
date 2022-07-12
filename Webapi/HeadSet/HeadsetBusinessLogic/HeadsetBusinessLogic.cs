using HeadSet.HeadsetRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeadSet.HeadsetBusinessLogic
{
    public class HeadSetBusinessLogic
    {
        HeadSetRepository headsetRepository = new HeadSetRepository();
        public List<HeadsetDetail> GetHeadsetDetails()
        {
            return headsetRepository.GetHeadsetDetails();
        }

        public bool AddHeadsetDetails(HeadsetDetail headsetDetail)
        {
            return headsetRepository.AddHeadsetDetails(headsetDetail);
        }
    }
}
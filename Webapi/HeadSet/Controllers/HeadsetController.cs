using HeadSet.HeadsetBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HeadSet.Controllers
{
    public class HeadsetController : ApiController
    {
        HeadSetBusinessLogic headsetBusinessLogic = new HeadSetBusinessLogic();
        
        [Route("api/getHeadsets")]
        [HttpGet]
         public List<HeadsetDetail> GetHeasetDetails()
        {
            return headsetBusinessLogic.GetHeadsetDetails();
         }

        [Route("api/addHeadset")]
        [HttpPost]
        public bool AddHeadsetDetails(HeadsetDetail headsetDetail)
        {
            return headsetBusinessLogic.AddHeadsetDetails(headsetDetail);
        }
    }
}

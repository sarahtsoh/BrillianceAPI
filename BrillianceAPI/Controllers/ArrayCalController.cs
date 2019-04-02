using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BrillianceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productsIds"></param>
        /// <returns></returns>
        [HttpGet("reverse")]
        public ActionResult<string[]> GetReverseProducts([FromQuery]string[] productsIds)
        {
            //reverse bubble sort
            return productsIds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productsIds"></param>
        /// <returns></returns>
        [HttpGet("deletepart")]
        public ActionResult<string[]> GetDeletePartProducts([FromQuery]int position, [FromQuery]string[] productsIds)
        {
            //bubble sort , get rid of one of them
            return productsIds;
        }

       
    }
}

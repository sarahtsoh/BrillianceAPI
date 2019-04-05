using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrillianceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BrillianceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private IArrayCalService _arrayCalService;

        public ArrayCalcController(IArrayCalService arrayCalService)
        {
            _arrayCalService = arrayCalService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// Reverse position of productIds
        /// </summary>
        /// <param name="productsIds"></param>
        /// <returns></returns>
        [HttpGet("reverse")]
        public ActionResult<int[]> GetReverseProducts([FromQuery]int[] productIds)
        {
            productIds = _arrayCalService.ReverseArray(productIds);
            return Ok(productIds);
            
        }

        /// <summary>
        /// Delete one of the index of the productIds
        /// </summary>
        /// <param name="position"></param>
        /// <param name="productsIds"></param>
        /// <returns></returns>
        [HttpGet("deletepart")]
        public ActionResult<int[]> GetDeletePartProducts([FromQuery]int position, [FromQuery]int[] productIds)
        {
            if (position > productIds.Length - 1)
                return BadRequest();
            productIds = _arrayCalService.DeletePartArray(position, productIds);
            return Ok(productIds);
        }

       
    }
}

using HappyCalendarAPI.BLL;
using HappyCalendarAPI.BLL.Interfaces;
using HappyCalendarAPI.LIB;
using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HappyCalendarAPI.Controllers
{
    [RoutePrefix("api/happycalendar")]
    public class HappyCalendarController : ApiController
    {
        private readonly ICategoryBLL _categoryBLL = new CategoryBLL();
        

        private ReturnModel _result = new ReturnModel();

        [HttpGet, Route("GetAreas")]
        public ReturnModel GetAreas()
        {
            try
            {
                    _result.Data = _categoryBLL.GetAreas();
                    _result.Description = "Get Areas";
                    _result.Success = true;
            }
            catch(Exception err)
            {
                _result.Success = false;
                _result.Description = "Unexpected error";
                _result.Data = null;

                err.Log();
            }
            return _result;
        }

        [HttpPost, Route("AddArea")]
        public ReturnModel AddArea([FromBody]Area model)
        {
            try
            {
                _categoryBLL.AddArea(model, ref _result);
                _result.Data = model;
                _result.Description = "A new area has been successfully added.";
                _result.Success = true;
            }
            catch(Exception err)
            {
                _result.Success = false;
                _result.Description = "Unexpected error";
                _result.Data = null;

                err.Log();
            }
            return _result;

        }
    }
}

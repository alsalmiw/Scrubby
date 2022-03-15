using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using scrubby_webapi.Services;
using scrubby_webapi.Models;

namespace scrubby_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly UserInfoService _data;

        public UserInfoController(UserInfoService _dataFromService)
        {
            _data = _dataFromService;
        }

        [HttpGet]
        [Route("GetUserInfo/{userid}")]

        public UserInfoModel GetUserInfo(int? userid)
        {
            return _data.GetUserInfo(userid);
        }
    }
}
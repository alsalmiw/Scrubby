using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Scrubby.Controllers
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
        [Route("GetAllUserInfo")]

        public List<UserInfoModel> GetUserInfoList()
        {
            return _data.GetUserInfoList();
        }
    }
}
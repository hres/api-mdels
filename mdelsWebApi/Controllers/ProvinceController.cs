﻿using mdelsWebApi.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace mdelsWebApi.Controllers
{
    public class ProvinceController : ApiController
    {
        static readonly IProvinceRepository databasePlaceholder = new ProvinceRepository();

        public IEnumerable<Province> GetAllProvince(string lang)
        {
            return databasePlaceholder.GetAll(lang);
        }

        public Province GetProvinceByID(int id, string lang)
        {
            Province province = databasePlaceholder.Get(id, lang);
            if (province == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return province;
        }

    }
}
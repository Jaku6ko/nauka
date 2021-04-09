using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAss.Models;
using APIAss.Service;


namespace APIAss.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [Route ("add")]
        public ActionResult AddOption(CalcModel Model)
        {
            var result = new CalcResultModel();
            CalcService Service = new CalcService();
            result.result = Service.Add(Model);
            return Ok(result);
        }
        [Route("subtract")]
        public ActionResult SubOption(CalcModel Model)
        {
            var result = new CalcResultModel();
            CalcService Service = new CalcService();
            result.result = Service.Subtract(Model);
            return Ok(result);
        }
        [Route("multiply")]
        public ActionResult MultOption(CalcModel Model)
        {
            var result = new CalcResultModel();
            CalcService Service = new CalcService();
            result.result = Service.Multiply(Model);
            return Ok(result);
        }
        [Route("divide")]
        public ActionResult DivOption(CalcModel Model)
        {
            var result = new CalcResultModel();
            CalcService Service = new CalcService();
            result.result = Service.Divide(Model);
            return Ok(result);
        }
    }
}
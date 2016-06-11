using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NumericSequenceCalculator.DomainLogic;
using NumericSequenceCalculator.DomainLogic.Entities;

namespace NumericSequenceCalculator.WebApi.Controllers
{
    public class NumberSequenceController : ApiController
    {
        // GET api/<controller>/5
        public IEnumerable<ProcessResult> Get(int number)
        {
            var numberSequenceLogic = new NumberSequenceLogic();

            var result = numberSequenceLogic.GetProcessedList(number);

            return result;
        }
    }
}
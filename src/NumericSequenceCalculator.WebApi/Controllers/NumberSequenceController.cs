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
        private readonly INumberSequenceLogic numberSequenceLogic;
        public NumberSequenceController(INumberSequenceLogic numberSequenceLogic)
        {
            this.numberSequenceLogic = numberSequenceLogic;
        }

        // GET api/<controller>/5
        public IEnumerable<ProcessResult> Get(int number)
        {
            var result = numberSequenceLogic.GetProcessedList(number);

            return result;
        }
    }
}
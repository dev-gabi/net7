using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.response
{
    public class UiResponse
    {
        public int ResponseCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.OperationResponse
{
    public class Response
    {
        public Exception Exception
        {
            get;
            set;
        }

        public OperationResultTypes OperationResult
        {
            get;
            set;
        }
    }
}

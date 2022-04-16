using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class MailTitleNotValidException:Exception
    {
        public MailTitleNotValidException(string message) : base(message)
        {

        }

    }
}

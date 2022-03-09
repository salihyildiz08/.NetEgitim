using System;
using System.Collections.Generic;
using System.Text;

namespace Uzaktan.Core.Domain.Dto
{
    public class BaseDto <T>
    {
        public T Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Uzaktan.Core.Domain.Dto
{
    public class CategoryDto:BaseDto<int>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

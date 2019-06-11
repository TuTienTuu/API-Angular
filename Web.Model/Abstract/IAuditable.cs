﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Abstract
{
   public interface IAuditable
    {
        DateTime CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        bool Status { get; set; }

        string MetaKeyword { get; set; }
        string MetaKeyDescription { get; set; }
    }
}

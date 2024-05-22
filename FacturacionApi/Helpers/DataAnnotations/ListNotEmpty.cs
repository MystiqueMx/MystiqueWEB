﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacturacionApi.Helpers.DataAnnotations
{
    public class ListNotEmpty: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is IList list && list.Count > 0;
        }
    }
}
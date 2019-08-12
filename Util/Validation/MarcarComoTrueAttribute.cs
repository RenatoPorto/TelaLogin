﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoLogin.Util.Validation
{
    public class MarcarComoTrueAttribute : Attribute, IModelValidator
    {
        public bool IsRequired => true;
        public string ErrorMessage { get; set; } = "Você deve marcar como true";
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            bool? value = context.Model as bool?;

            if (!value.HasValue || value.Value == false)
            {
                return new List<ModelValidationResult> { new ModelValidationResult("", ErrorMessage) };
            }
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
    }
}
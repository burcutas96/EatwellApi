﻿using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForLoginDtoValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginDtoValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
        }
    }
}

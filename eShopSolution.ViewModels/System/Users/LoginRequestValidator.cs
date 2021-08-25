﻿using System;
using FluentValidation;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.Passwrod).NotEmpty().WithMessage("Password is required").MinimumLength(6).WithMessage("Password is at least 6 charater");
        }
    }
}

﻿using FastEndpoints;
using FluentValidation;

namespace DeviantPasswordManager.Web.Passwords;

public class GetPasswordByIdValidator : Validator<GetPasswordByIdRequest>
{
  public GetPasswordByIdValidator()
  {
    RuleFor(x => x.PasswordId)
      .GreaterThan(0);
    RuleFor(x => x.ProjectId)
      .GreaterThan(0);
  }
}

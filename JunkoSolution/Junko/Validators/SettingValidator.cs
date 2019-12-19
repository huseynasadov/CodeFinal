using FluentValidation;
using Junko.Data.Entries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Validators
{
    public class SettingValidator:AbstractValidator<Setting>
	{
		public SettingValidator()
		{
			RuleFor(x => x.Address).NotEmpty().MaximumLength(200);
			RuleFor(x => x.Email).EmailAddress();
			RuleFor(x => x.Location).NotEmpty().MaximumLength(50);
		}
    
    }
}

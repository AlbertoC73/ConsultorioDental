﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDental.Utilidades
{
    public class ErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresLower),
                Description = "El PassWord deberá Tener al menos una letra Minuscula"
            };
        }
    }
}

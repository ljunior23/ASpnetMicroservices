﻿using Ordering.Application.Models;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infratructure
{
    public interface IEmailService
    {
       
        Task<bool> SendEmail(Email email);
    }
}

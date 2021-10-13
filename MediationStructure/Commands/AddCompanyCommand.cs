﻿using APIMediatorPattern.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Commands
{
    public class AddCompanyCommand : IRequest<Company>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos.Domain.Alunos.Interface
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}

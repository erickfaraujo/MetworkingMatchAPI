﻿using MediatR;
using MetWorkingMatch.Application.Contracts;
using System;

namespace MetWorkingMatch.Application.Pedido.Queries
{
    public class GetPedidosEnviadosByIdQuery : IRequest<BaseResponse<PedidosMatchResponse>>
    {
        public Guid UserId { get; }

        public GetPedidosEnviadosByIdQuery(Guid UserId)
        {
            this.UserId = UserId;
        }

    }
}

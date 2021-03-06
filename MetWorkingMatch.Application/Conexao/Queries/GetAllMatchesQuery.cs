﻿using MediatR;
using MetWorkingMatch.Application.Contracts;
using MetWorkingMatch.Application.Contracts.Match;
using System;

namespace MetWorkingMatch.Application.Conexao.Queries
{
    public class GetAllMatchesQuery : IRequest<BaseResponse<MatchesAtivosResponse>>
    {
        public Guid UserId;

        public GetAllMatchesQuery(Guid UserId)
        {
            this.UserId = UserId;
        }
    }
}

﻿using System;


namespace MetWorkingMatch.Application.Contracts
{
    public class CreatePedidoRequest
    {
        public Guid IdUserSolicitante { get; set; }
        public Guid IdUserAprovador { get; set; }
    }
}

﻿using MetWorkingMatch.Application.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace MetWorkingMatch.Test.StepDefinitions
{
    [Binding]
    public class ListarPedidosRecebidosSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly string _urlGetEnviados;

        public ListarPedidosRecebidosSteps(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
            this._urlGetEnviados = "https://localhost:5001/api/v1/PedidoMatch/recebidos/";
        }

        [When(@"o usuário (.*) quiser ver a lista de pedidos recebidos")]
        public void QuandoOUsuarioQuiserVerAListaDePedidosRecebidos(Guid IdUser)
        {
            var request = new RestRequest();
            request.Method = Method.GET;

            request.Parameters.Clear();

            var restClient = new RestClient(_urlGetEnviados + IdUser);

            var response = restClient.Execute(request);

            _scenarioContext["response"] = response;
        }

        [Then(@"a lista de pedidos pendentes deverá ser exibida (.*)")]
        public void EntaoAListaDePedidosPendentesDeveraSerExibida(Guid IdUserSolicitante)
        {
            var response = (IRestResponse)_scenarioContext["response"];
            var content = response.Content.ToString();

            dynamic jsonResponse = JsonConvert.DeserializeObject<BaseResponse<PedidosMatchResponse>>(content);

            BaseResponse<PedidosMatchResponse> finalResponse = new BaseResponse<PedidosMatchResponse>();
            finalResponse = jsonResponse;

            Assert.AreEqual(IdUserSolicitante, finalResponse.Data.Pedidos[0].IdUser);
        }
    }
}
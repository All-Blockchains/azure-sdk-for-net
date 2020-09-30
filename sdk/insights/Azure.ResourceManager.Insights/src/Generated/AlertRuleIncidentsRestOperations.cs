// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class AlertRuleIncidentsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AlertRuleIncidentsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public AlertRuleIncidentsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string ruleName, string incidentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendPath("/incidents/", false);
            uri.AppendPath(incidentName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets an incident associated to an alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="incidentName"> The name of the incident to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="incidentName"/> is null. </exception>
        public async Task<Response<Incident>> GetAsync(string resourceGroupName, string ruleName, string incidentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (incidentName == null)
            {
                throw new ArgumentNullException(nameof(incidentName));
            }

            using var message = CreateGetRequest(resourceGroupName, ruleName, incidentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Incident value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Incident.DeserializeIncident(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an incident associated to an alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="incidentName"> The name of the incident to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="incidentName"/> is null. </exception>
        public Response<Incident> Get(string resourceGroupName, string ruleName, string incidentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (incidentName == null)
            {
                throw new ArgumentNullException(nameof(incidentName));
            }

            using var message = CreateGetRequest(resourceGroupName, ruleName, incidentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Incident value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Incident.DeserializeIncident(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByAlertRuleRequest(string resourceGroupName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendPath("/incidents", false);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a list of incidents associated to an alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public async Task<Response<IncidentListResult>> ListByAlertRuleAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateListByAlertRuleRequest(resourceGroupName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncidentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IncidentListResult.DeserializeIncidentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of incidents associated to an alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public Response<IncidentListResult> ListByAlertRule(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateListByAlertRuleRequest(resourceGroupName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncidentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IncidentListResult.DeserializeIncidentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
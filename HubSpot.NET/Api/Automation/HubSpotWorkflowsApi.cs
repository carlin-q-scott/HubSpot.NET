using HubSpot.NET.Api.Automation.Dto;
using HubSpot.NET.Core.Abstracts;
using HubSpot.NET.Core.Interfaces;
using RestSharp;

namespace HubSpot.NET.Api.Automation
{
    public class HubSpotWorkflowsApi : ApiRoutable, IHubSpotWorkflowsApi
    {
        private readonly IHubSpotClient _client;
        public override string MidRoute => "/automation/v2/workflows";        

        public HubSpotWorkflowsApi(IHubSpotClient client)
        {
            _client = client;            
        }

        public WorkflowListHubSpotModel GetWorkflows
            => _client.Execute<WorkflowListHubSpotModel>(GetRoute());

        public void EnrollContactInWorkflow(string workflowId, string email)
            => _client.ExecuteOnly(GetRoute(workflowId, "enrollments", "contacts", email), Method.POST);
    }
}
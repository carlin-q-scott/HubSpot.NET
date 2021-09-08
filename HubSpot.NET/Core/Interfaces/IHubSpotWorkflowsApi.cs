using HubSpot.NET.Api.Automation.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotWorkflowsApi
    {
        WorkflowListHubSpotModel GetWorkflows { get; }

        void EnrollContactInWorkflow(string workflowId, string email);
    }
}
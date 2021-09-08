using System.Collections.Generic;

namespace HubSpot.NET.Api.Automation.Dto
{
    public class WorkflowListHubSpotModel
    {
        public List<WorkflowHubSpotModel> Workflows { get;set; }
    }

    public class ContactListIdsHubSpotModel
    {
        public int Enrolled { get; set; }
        public int Active { get; set; }
        public List<dynamic> Steps { get; set; }
    }

    public class WorkflowHubSpotModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Enabled { get; set; }
        public long InsertedAt { get; set; }
        public long UpdatedAt { get; set; }
        public List<string> PersonaTagIds { get; set; }
        public ContactListIdsHubSpotModel ContactListIds { get; set; }
    }
}

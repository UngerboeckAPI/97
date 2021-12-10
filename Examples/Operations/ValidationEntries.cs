using System.Net.Http;
using Ungerboeck.Api.Sdk;
using Ungerboeck.Api.Models;
using Ungerboeck.Api.Models.Subjects;
using Ungerboeck.Api.Models.Search;
using System.Collections.Generic;

namespace Examples.Operations
{
  public class ValidationEntries : Base
  {
    public ValidationEntries(ApiClient apiClient) : base(apiClient)
    {
    }

    /// <summary>
    /// A basic retrieve example
    /// </summary>
    public ValidationEntriesModel Get(string orgCode, int validationTableID, int sequenceNumber)
    {
      return apiClient.Endpoints.ValidationEntries.Get( orgCode, validationTableID, sequenceNumber);
    }

    /// <summary>
    /// A search example.  Check out the 'Search using the API' knowledge base article for more info.
    /// </summary>   
    public SearchResponse<ValidationEntriesModel> Search(string orgCode, string searchValue)
    {
      return apiClient.Endpoints.ValidationEntries.Search(orgCode, $"{nameof(ValidationEntriesModel.Description)} eq '{searchValue}'");
    }
  }
}

using System.Net.Http;
using Ungerboeck.Api.Sdk;
using Ungerboeck.Api.Models;
using Ungerboeck.Api.Models.Subjects;
using Ungerboeck.Api.Models.Search;
using System.Collections.Generic;

namespace Examples.Operations
{
  public class CustomFieldValidationTables : Base
  {
    public CustomFieldValidationTables(ApiClient apiClient) : base(apiClient)
    {
    }

    /// <summary>
    /// A basic retrieve example
    /// </summary> 
    public CustomFieldValidationTablesModel Get(string orgCode, int ID)
    {
      return apiClient.Endpoints.CustomFieldValidationTables.Get( orgCode, ID);
    }

    /// <summary>
    /// A search example.  Check out the 'Search using the API' knowledge base article for more info.
    /// </summary> 
    public SearchResponse<CustomFieldValidationTablesModel> Search(string orgCode, string searchValue)
    {
      return apiClient.Endpoints.CustomFieldValidationTables.Search(orgCode, $"{nameof(CustomFieldValidationTablesModel.Description)} eq '{searchValue}'");
    }
  }
}

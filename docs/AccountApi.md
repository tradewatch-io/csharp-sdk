# Tradewatch.Api.AccountApi

All URIs are relative to *https://api.tradewatch.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**getUsage**](AccountApi.md#getusage) | **GET** /account/usage | Usage statistics |

<a id="getusage"></a>
# **getUsage**
> Object getUsage (int? limit = null, AccountUsageStatisticsInterval? interval = null)

Usage statistics

Get the usage statistics of your API account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;

namespace Example
{
    public class getUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.tradewatch.io";
            // Configure API key authorization: api_key_query
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: api_key_header
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new AccountApi(config);
            var limit = 56;  // int? |  (optional) 
            var interval = new AccountUsageStatisticsInterval?(); // AccountUsageStatisticsInterval? |  (optional) 

            try
            {
                // Usage statistics
                Object result = apiInstance.getUsage(limit, interval);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.getUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the getUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Usage statistics
    ApiResponse<Object> response = apiInstance.getUsageWithHttpInfo(limit, interval);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.getUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional]  |
| **interval** | [**AccountUsageStatisticsInterval?**](AccountUsageStatisticsInterval?.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[api_key_query](../README.md#api_key_query), [api_key_header](../README.md#api_key_header)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **422** | Validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


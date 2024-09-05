# Tradewatch.Api.CurrenciesApi

All URIs are relative to *https://api.tradewatch.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**convert**](CurrenciesApi.md#convert) | **GET** /currencies/convert/{from}/{to} | Conversion |
| [**getQuote**](CurrenciesApi.md#getquote) | **GET** /currencies/symbols/{symbol} | Last Quote |
| [**getSymbols**](CurrenciesApi.md#getsymbols) | **GET** /currencies/symbols | Available Symbols |

<a id="convert"></a>
# **convert**
> Conversion convert (string from, string to)

Conversion

Convert one symbol to another

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;

namespace Example
{
    public class convertExample
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

            var apiInstance = new CurrenciesApi(config);
            var from = "from_example";  // string | 
            var to = "to_example";  // string | 

            try
            {
                // Conversion
                Conversion result = apiInstance.convert(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrenciesApi.convert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the convertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Conversion
    ApiResponse<Conversion> response = apiInstance.convertWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrenciesApi.convertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **string** |  |  |
| **to** | **string** |  |  |

### Return type

[**Conversion**](Conversion.md)

### Authorization

[api_key_query](../README.md#api_key_query), [api_key_header](../README.md#api_key_header)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquote"></a>
# **getQuote**
> LastQuote getQuote (string symbol, int? precision = null)

Last Quote

Get the last quote tick for the provided symbol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;

namespace Example
{
    public class getQuoteExample
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

            var apiInstance = new CurrenciesApi(config);
            var symbol = "symbol_example";  // string | 
            var precision = 5;  // int? |  (optional)  (default to 5)

            try
            {
                // Last Quote
                LastQuote result = apiInstance.getQuote(symbol, precision);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrenciesApi.getQuote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the getQuoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Last Quote
    ApiResponse<LastQuote> response = apiInstance.getQuoteWithHttpInfo(symbol, precision);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrenciesApi.getQuoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **symbol** | **string** |  |  |
| **precision** | **int?** |  | [optional] [default to 5] |

### Return type

[**LastQuote**](LastQuote.md)

### Authorization

[api_key_query](../README.md#api_key_query), [api_key_header](../README.md#api_key_header)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsymbols"></a>
# **getSymbols**
> CursorPageTCustomizedSymbolsOutFull getSymbols (SymbolsListMode mode, int? size = null, int? page = null, string? cursor = null)

Available Symbols

Get list of available symbols

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;

namespace Example
{
    public class getSymbolsExample
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

            var apiInstance = new CurrenciesApi(config);
            var mode = (SymbolsListMode) "full";  // SymbolsListMode | Listing mode
            var size = 50;  // int? | Page offset (optional)  (default to 50)
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var cursor = "cursor_example";  // string? | Cursor for the next page (optional) 

            try
            {
                // Available Symbols
                CursorPageTCustomizedSymbolsOutFull result = apiInstance.getSymbols(mode, size, page, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrenciesApi.getSymbols: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the getSymbolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Available Symbols
    ApiResponse<CursorPageTCustomizedSymbolsOutFull> response = apiInstance.getSymbolsWithHttpInfo(mode, size, page, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrenciesApi.getSymbolsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mode** | **SymbolsListMode** | Listing mode |  |
| **size** | **int?** | Page offset | [optional] [default to 50] |
| **page** | **int?** | Page number | [optional] [default to 1] |
| **cursor** | **string?** | Cursor for the next page | [optional]  |

### Return type

[**CursorPageTCustomizedSymbolsOutFull**](CursorPageTCustomizedSymbolsOutFull.md)

### Authorization

[api_key_query](../README.md#api_key_query), [api_key_header](../README.md#api_key_header)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


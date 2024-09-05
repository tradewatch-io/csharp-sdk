<a href="https://tradewatch.io/">
    <img src="https://pub-e8bb70a6cc1844138d6a55fa4a44ba42.r2.dev/logo-purple.png" alt="TradeWatch.io logo" title="TradeWatch.io" align="right" height="60" />
</a>

# TradeWatch.io CSharp SDK

[TradeWatch.io](https://tradewatch.io) offers a comprehensive financial data API designed for developers and businesses. The platform provides real-time access to market data, covering a wide range of assets such as currencies, cryptocurrencies, stocks, indices, and commodities. It emphasizes seamless integration, reliability, and scalability, making it ideal for building financial tools and services. Additional features include serverless functions, customizable API domains, and webhook notifications for market events, all aimed at enhancing business efficiency and informed decision-making.

## Table of Contents
- [Quick start](#-quick-start)
- [Requirements](#-requirements)
- [Installation & usage](#-installation--usage)
- [Example](#-example)
- [Available methods](#-available-methods)
- [Available models](#-available-models)
- [Feedback and Contributions](#-feedback-and-contributions)
- [License](#-license)
- [Contact and Support](#-contact-and-support)

## 🚀 Quick start

Visit our [Dashboard](https://dash.tradewatch.io/register) and register a free account.

Follow the [Getting started](https://tradewatch.io/docs/platform/getting-started) section in our Developer Portal.

## 📝 Requirements

### Frameworks supported

### Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).


## 🔨 Installation & usage

Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;
```
### Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Tradewatch.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

### Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

## 👨‍💻 Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tradewatch.Api;
using Tradewatch.Client;
using Tradewatch.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.tradewatch.io";
            // Configure API key authorization: api_key_query
            config.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("api-key", "Bearer");
            // Configure API key authorization: api_key_header
            config.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new AccountApi(config);
            var limit = 56;  // int? |  (optional) 
            var interval = new AccountUsageStatisticsInterval?(); // AccountUsageStatisticsInterval? |  (optional) 

            try
            {
                // Usage statistics
                Object result = apiInstance.getUsage(limit, interval);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountApi.getUsage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## 📖 Available methods

All URIs are relative to *https://api.tradewatch.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**getUsage**](docs/AccountApi.md#getusage) | **GET** /account/usage | Usage statistics
*CommoditiesApi* | [**getQuote**](docs/CommoditiesApi.md#getquote) | **GET** /commodities/symbols/{symbol} | Last Quote
*CommoditiesApi* | [**getSymbols**](docs/CommoditiesApi.md#getsymbols) | **GET** /commodities/symbols | Available Symbols
*CommoditiesApi* | [**getTypes**](docs/CommoditiesApi.md#gettypes) | **GET** /commodities/types | Available Types
*CryptoApi* | [**convert**](docs/CryptoApi.md#convert) | **GET** /crypto/convert/{from}/{to} | Conversion
*CryptoApi* | [**getQuote**](docs/CryptoApi.md#getquote) | **GET** /crypto/symbols/{symbol} | Last Quote
*CryptoApi* | [**getSymbols**](docs/CryptoApi.md#getsymbols) | **GET** /crypto/symbols | Available Symbols
*CurrenciesApi* | [**convert**](docs/CurrenciesApi.md#convert) | **GET** /currencies/convert/{from}/{to} | Conversion
*CurrenciesApi* | [**getQuote**](docs/CurrenciesApi.md#getquote) | **GET** /currencies/symbols/{symbol} | Last Quote
*CurrenciesApi* | [**getSymbols**](docs/CurrenciesApi.md#getsymbols) | **GET** /currencies/symbols | Available Symbols
*IndicesApi* | [**getQuote**](docs/IndicesApi.md#getquote) | **GET** /indices/symbols/{symbol} | Last Quote
*IndicesApi* | [**getSymbols**](docs/IndicesApi.md#getsymbols) | **GET** /indices/symbols | Available Symbols
*StocksApi* | [**getCountries**](docs/StocksApi.md#getcountries) | **GET** /stocks/countries | Available Countries
*StocksApi* | [**getQuote**](docs/StocksApi.md#getquote) | **GET** /stocks/symbols/{symbol} | Last Quote
*StocksApi* | [**getSymbols**](docs/StocksApi.md#getsymbols) | **GET** /stocks/symbols | Available Symbols


## 📖 Available models

 - [Model.AccountUsageStatisticsInterval](docs/AccountUsageStatisticsInterval.md)
 - [Model.ApiUsageDataTransfer](docs/ApiUsageDataTransfer.md)
 - [Model.ApiUsageEntry](docs/ApiUsageEntry.md)
 - [Model.CommodityType](docs/CommodityType.md)
 - [Model.CommodityTypeObj](docs/CommodityTypeObj.md)
 - [Model.CommodityTypesList](docs/CommodityTypesList.md)
 - [Model.Conversion](docs/Conversion.md)
 - [Model.ConversionInfo](docs/ConversionInfo.md)
 - [Model.ConversionQuery](docs/ConversionQuery.md)
 - [Model.CountriesList](docs/CountriesList.md)
 - [Model.Country](docs/Country.md)
 - [Model.CountryObj](docs/CountryObj.md)
 - [Model.CryptoConversion](docs/CryptoConversion.md)
 - [Model.CryptoConversionQuery](docs/CryptoConversionQuery.md)
 - [Model.CursorPageTCustomizedSymbolsOutFull](docs/CursorPageTCustomizedSymbolsOutFull.md)
 - [Model.ErrorDetails](docs/ErrorDetails.md)
 - [Model.ErrorResponseBody](docs/ErrorResponseBody.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.LastQuote](docs/LastQuote.md)
 - [Model.SymbolsListMode](docs/SymbolsListMode.md)
 - [Model.SymbolsOutFull](docs/SymbolsOutFull.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.ValidationErrorLocInner](docs/ValidationErrorLocInner.md)


## 🔑 Authorization


Authentication schemes defined for the API:
<a id="api_key_header"></a>
### api_key_header

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header

<a id="api_key_query"></a>
### api_key_query

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: URL query string


## 🤝 Feedback and Contributions

We appreciate your support and look forward to making our product even better with your help!

## ©️ License

This project is licensed under the [MIT License](http://opensource.org/licenses/MIT).


## 🗨️ Contact and Support

For more details about our products, services, or any general information, feel free to reach out to us.

See the list of available [Support Channels](https://tradewatch.io/docs/support/channels).

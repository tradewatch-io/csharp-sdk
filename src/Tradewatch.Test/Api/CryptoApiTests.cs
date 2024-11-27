/*
 * tradewatch.io
 *
 * Financial market data for Developers
 *
 * The version of the OpenAPI document: 3.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Tradewatch.Client;
using Tradewatch.Api;
// uncomment below to import models
//using Tradewatch.Model;

namespace Tradewatch.Test.Api
{
    /// <summary>
    ///  Class for testing CryptoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CryptoApiTests : IDisposable
    {
        private CryptoApi instance;

        public CryptoApiTests()
        {
            instance = new CryptoApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CryptoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CryptoApi
            //Assert.IsType<CryptoApi>(instance);
        }

        /// <summary>
        /// Test convert
        /// </summary>
        [Fact]
        public void convertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string from = null;
            //string to = null;
            //var response = instance.convert(from, to);
            //Assert.IsType<CryptoConversion>(response);
        }

        /// <summary>
        /// Test getExchanges
        /// </summary>
        [Fact]
        public void getExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.getExchanges();
            //Assert.IsType<CryptoExchangesList>(response);
        }

        /// <summary>
        /// Test getQuote
        /// </summary>
        [Fact]
        public void getQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? precision = null;
            //var response = instance.getQuote(symbol, precision);
            //Assert.IsType<LastQuote>(response);
        }

        /// <summary>
        /// Test getSymbols
        /// </summary>
        [Fact]
        public void getSymbolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SymbolsListMode mode = null;
            //int? size = null;
            //int? page = null;
            //string? cursor = null;
            //var response = instance.getSymbols(mode, size, page, cursor);
            //Assert.IsType<CursorPageTCustomizedSymbolsOutFull>(response);
        }
    }
}

/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing BulkEnvelopesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BulkEnvelopesApiTests
    {
        private BulkEnvelopesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BulkEnvelopesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BulkEnvelopesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BulkEnvelopesApi
            //Assert.IsInstanceOfType(typeof(BulkEnvelopesApi), instance, "instance is a BulkEnvelopesApi");
        }

        
        /// <summary>
        /// Test DeleteRecipients
        /// </summary>
        [Test]
        public void DeleteRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //string recipientId = null;
            //var response = instance.DeleteRecipients(accountId, envelopeId, recipientId);
            //Assert.IsInstanceOf<BulkRecipientsUpdateResponse> (response, "response is BulkRecipientsUpdateResponse");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string include = null;
            //string startPosition = null;
            //string accountId = null;
            //string batchId = null;
            //var response = instance.Get(count, include, startPosition, accountId, batchId);
            //Assert.IsInstanceOf<BulkEnvelopeStatus> (response, "response is BulkEnvelopeStatus");
        }
        
        /// <summary>
        /// Test GetRecipients
        /// </summary>
        [Test]
        public void GetRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeTabs = null;
            //string startPosition = null;
            //string accountId = null;
            //string envelopeId = null;
            //string recipientId = null;
            //var response = instance.GetRecipients(includeTabs, startPosition, accountId, envelopeId, recipientId);
            //Assert.IsInstanceOf<BulkRecipientsResponse> (response, "response is BulkRecipientsResponse");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string include = null;
            //string startPosition = null;
            //string accountId = null;
            //var response = instance.List(count, include, startPosition, accountId);
            //Assert.IsInstanceOf<BulkEnvelopesResponse> (response, "response is BulkEnvelopesResponse");
        }
        
        /// <summary>
        /// Test UpdateRecipients
        /// </summary>
        [Test]
        public void UpdateRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BulkRecipientsRequest bulkRecipientsRequest = null;
            //string accountId = null;
            //string envelopeId = null;
            //string recipientId = null;
            //var response = instance.UpdateRecipients(bulkRecipientsRequest, accountId, envelopeId, recipientId);
            //Assert.IsInstanceOf<BulkRecipientsSummaryResponse> (response, "response is BulkRecipientsSummaryResponse");
        }
        
    }

}

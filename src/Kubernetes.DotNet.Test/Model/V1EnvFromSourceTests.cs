/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;
using Kubernetes.DotNet.Client;
using System.Reflection;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing V1EnvFromSource
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V1EnvFromSourceTests
    {
        // TODO uncomment below to declare an instance variable for V1EnvFromSource
        //private V1EnvFromSource instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V1EnvFromSource
            //instance = new V1EnvFromSource();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1EnvFromSource
        /// </summary>
        [Test]
        public void V1EnvFromSourceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V1EnvFromSource
            //Assert.IsInstanceOfType<V1EnvFromSource> (instance, "variable 'instance' is a V1EnvFromSource");
        }

        /// <summary>
        /// Test the property 'ConfigMapRef'
        /// </summary>
        [Test]
        public void ConfigMapRefTest()
        {
            // TODO unit test for the property 'ConfigMapRef'
        }
        /// <summary>
        /// Test the property 'Prefix'
        /// </summary>
        [Test]
        public void PrefixTest()
        {
            // TODO unit test for the property 'Prefix'
        }
        /// <summary>
        /// Test the property 'SecretRef'
        /// </summary>
        [Test]
        public void SecretRefTest()
        {
            // TODO unit test for the property 'SecretRef'
        }

    }

}
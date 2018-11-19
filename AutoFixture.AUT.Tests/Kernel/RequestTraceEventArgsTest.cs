namespace AutoFixture.Kernel
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text;
    using Action = System.Action;
    using AUT.TestProjects.Analyzer;
    using AUT.TestProjects.BaseSetup.Version.V1;
    using AUT.TestProjects.BaseSetup.Version.V2;
    using AUT.TestProjects.Extensions;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
    using AUT.TestProjects.NUnitExtensionAttribute;
    using AUT.TestProjects.StaticTypes;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.Kernel;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.RequestTraceEventArgs" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RequestTraceEventArgsTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RequestTraceEventArgs" />)
        /// </summary>
        public RequestTraceEventArgsTest() : base(typeof(RequestTraceEventArgs))
        {}

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IAbstractBaseSetupV2Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RequestTraceEventArgs) Initializer

        #region General Initializer : Class (RequestTraceEventArgs) One time setup

        private Type _requestTraceEventArgsInstanceType;
        private RequestTraceEventArgs _requestTraceEventArgsInstance;
        private RequestTraceEventArgs _requestTraceEventArgsInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RequestTraceEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _requestTraceEventArgsInstanceType = typeof(RequestTraceEventArgs);
            _requestTraceEventArgsInstanceFixture = this.Create<RequestTraceEventArgs>(true);
            _requestTraceEventArgsInstance = _requestTraceEventArgsInstanceFixture ?? this.Create<RequestTraceEventArgs>(false);
            CurrentInstance = _requestTraceEventArgsInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyDepth = "Depth";
        private const string PropertyRequest = "Request";

        #endregion

        #endregion

        #region General Initializer : Class (RequestTraceEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RequestTraceEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RequestTraceEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RequestTraceEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RequestTraceEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RequestTraceEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RequestTraceEventArgs)

        #region General Initializer : Class (RequestTraceEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDepth)]
        [TestCase(PropertyRequest)]
        public void AUT_RequestTraceEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (RequestTraceEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestTraceEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _requestTraceEventArgsInstanceType.ShouldNotBeNull();
            _requestTraceEventArgsInstance.ShouldNotBeNull();
            _requestTraceEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RequestTraceEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RequestTraceEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestTraceEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _requestTraceEventArgsInstance.ShouldBeAssignableTo<RequestTraceEventArgs>();
            _requestTraceEventArgsInstanceFixture.ShouldBeAssignableTo<RequestTraceEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<RequestTraceEventArgs>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RequestTraceEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RequestTraceEventArgs_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var depth = this.CreateType<int>();
            RequestTraceEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new RequestTraceEventArgs(request, depth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _requestTraceEventArgsInstance.ShouldNotBeNull();
            _requestTraceEventArgsInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<RequestTraceEventArgs>();
        }

        #endregion

        #region General Constructor : Class (RequestTraceEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RequestTraceEventArgs_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var depth = this.CreateType<int>();
            RequestTraceEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new RequestTraceEventArgs(request, depth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _requestTraceEventArgsInstance.ShouldNotBeNull();
            _requestTraceEventArgsInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RequestTraceEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDepth)]
        [TestCase(PropertyRequest)]
        public void AUT_RequestTraceEventArgs_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (RequestTraceEventArgs) => Property (Depth) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RequestTraceEventArgs_Public_Class_Depth_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDepth);
            var propertyInfo = this.GetPropertyInfo(PropertyDepth);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RequestTraceEventArgs) => Property (Request) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RequestTraceEventArgs_Request_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequest);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequest);
            Action currentAction = () => propertyInfo.SetValue(_requestTraceEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RequestTraceEventArgs) => Property (Request) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RequestTraceEventArgs_Public_Class_Request_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequest);
            var propertyInfo = this.GetPropertyInfo(PropertyRequest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}
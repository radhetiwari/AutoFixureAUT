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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.OmitOnRecursionHandler" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OmitOnRecursionHandlerTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OmitOnRecursionHandler" />)
        /// </summary>
        public OmitOnRecursionHandlerTest() : base(typeof(OmitOnRecursionHandler))
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

        #region General Initializer : Class (OmitOnRecursionHandler) Initializer

        #region General Initializer : Class (OmitOnRecursionHandler) One time setup

        private Type _omitOnRecursionHandlerInstanceType;
        private OmitOnRecursionHandler _omitOnRecursionHandlerInstance;
        private OmitOnRecursionHandler _omitOnRecursionHandlerInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="OmitOnRecursionHandler" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _omitOnRecursionHandlerInstanceType = typeof(OmitOnRecursionHandler);
            _omitOnRecursionHandlerInstanceFixture = this.Create<OmitOnRecursionHandler>(true);
            _omitOnRecursionHandlerInstance = _omitOnRecursionHandlerInstanceFixture ?? this.Create<OmitOnRecursionHandler>(false);
            CurrentInstance = _omitOnRecursionHandlerInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodHandleRecursiveRequest = "HandleRecursiveRequest";

        #endregion

        #endregion

        #region General Initializer : Class (OmitOnRecursionHandler) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionHandler" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OmitOnRecursionHandler_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OmitOnRecursionHandler) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionHandler" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OmitOnRecursionHandler_Is_Instance_Present_Test()
        {
            // Assert
            _omitOnRecursionHandlerInstanceType.ShouldNotBeNull();
            _omitOnRecursionHandlerInstance.ShouldNotBeNull();
            _omitOnRecursionHandlerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OmitOnRecursionHandler) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionHandler" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OmitOnRecursionHandler_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _omitOnRecursionHandlerInstance.ShouldBeAssignableTo<OmitOnRecursionHandler>();
            _omitOnRecursionHandlerInstanceFixture.ShouldBeAssignableTo<OmitOnRecursionHandler>();
            CurrentInstance.ShouldBeAssignableTo<OmitOnRecursionHandler>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OmitOnRecursionHandler) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionHandler_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OmitOnRecursionHandler instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}
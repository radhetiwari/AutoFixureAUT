namespace AutoFixture
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
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
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.ObjectCreationExceptionWithPath" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ObjectCreationExceptionWithPathTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ObjectCreationExceptionWithPathNonPublicTypeName" />) using
        ///     Using a public type <see cref="AutoPropertiesTarget" /> to
        ///     create a non-public type.
        /// </summary>
        public ObjectCreationExceptionWithPathTest() : base(publicType: typeof(AutoPropertiesTarget), classNameWithNamespace: ObjectCreationExceptionWithPathNonPublicTypeName)
        {}

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ObjectCreationExceptionWithPath) Initializer

        #region Methods

        private const string MethodFormatRequestsPath = "FormatRequestsPath";
        private const string MethodShouldDisplayRequestInPath = "ShouldDisplayRequestInPath";
        private const string MethodFormatInnerExceptionMessages = "FormatInnerExceptionMessages";
        private const string MethodIndent = "Indent";

        #endregion

        private Type _objectCreationExceptionWithPathInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _objectCreationExceptionWithPathInstance;
        private object _objectCreationExceptionWithPathInstanceFixture;
        private const string ObjectCreationExceptionWithPathNonPublicTypeName = "AutoFixture.ObjectCreationExceptionWithPath";

        #region General Initializer : Class (ObjectCreationExceptionWithPath) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ObjectCreationExceptionWithPath" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _objectCreationExceptionWithPathInstanceFixture = this.CreateNonPublicType(ObjectCreationExceptionWithPathNonPublicTypeName);
            _objectCreationExceptionWithPathInstance = _objectCreationExceptionWithPathInstanceFixture;
            CurrentInstance = _objectCreationExceptionWithPathInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ObjectCreationExceptionWithPath)

        #region General Initializer : Class (ObjectCreationExceptionWithPath) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ObjectCreationExceptionWithPath" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFormatRequestsPath, 0)]
        [TestCase(MethodShouldDisplayRequestInPath, 0)]
        [TestCase(MethodFormatInnerExceptionMessages, 0)]
        [TestCase(MethodIndent, 0)]
        public void AUT_ObjectCreationExceptionWithPath_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (ObjectCreationExceptionWithPath) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ObjectCreationExceptionWithPath" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ObjectCreationExceptionWithPath_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
namespace AutoFixture.NUnit3
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
    using AutoFixture.NUnit3;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.CustomizeAttributeComparer" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomizeAttributeComparerTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CustomizeAttributeComparerNonPublicTypeName" />) using
        ///     Using a public type <see cref="AutoDataAttribute" /> to
        ///     create a non-public type.
        /// </summary>
        public CustomizeAttributeComparerTest() : base(publicType: typeof(AutoDataAttribute), classNameWithNamespace: CustomizeAttributeComparerNonPublicTypeName)
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

        #region General Initializer : Class (CustomizeAttributeComparer) Initializer

        #region Methods

        private const string MethodCompare = "Compare";

        #endregion

        private Type _customizeAttributeComparerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _customizeAttributeComparerInstance;
        private object _customizeAttributeComparerInstanceFixture;
        private const string CustomizeAttributeComparerNonPublicTypeName = "AutoFixture.NUnit3.CustomizeAttributeComparer";

        #region General Initializer : Class (CustomizeAttributeComparer) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CustomizeAttributeComparer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customizeAttributeComparerInstanceFixture = this.CreateNonPublicType(CustomizeAttributeComparerNonPublicTypeName);
            _customizeAttributeComparerInstance = _customizeAttributeComparerInstanceFixture;
            CurrentInstance = _customizeAttributeComparerInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomizeAttributeComparer)

        #region General Initializer : Class (CustomizeAttributeComparer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomizeAttributeComparer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCompare, 0)]
        public void AUT_CustomizeAttributeComparer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomizeAttributeComparer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomizeAttributeComparer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CustomizeAttributeComparer_Explore_Reflection_Based_NonListed_Methods_Test()
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
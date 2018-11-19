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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.CustomizeAttribute" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomizeAttributeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomizeAttribute" />)
        /// </summary>
        public CustomizeAttributeTest() : base(typeof(CustomizeAttribute))
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

        #region General Initializer : Class (CustomizeAttribute) Initializer

        #region General Initializer : Class (CustomizeAttribute) One time setup

        private Type _customizeAttributeInstanceType;
        private CustomizeAttribute _customizeAttributeInstance;
        private CustomizeAttribute _customizeAttributeInstanceFixture;
        private Type[] _abstractClassInstanciatedTypesList;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="CustomizeAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customizeAttributeInstanceType = typeof(CustomizeAttribute);
            _abstractClassInstanciatedTypesList = new Type[] { typeof(FavorArraysAttribute), typeof(FavorEnumerablesAttribute), typeof(FavorListsAttribute), typeof(FrozenAttribute), typeof(GreedyAttribute), typeof(ModestAttribute), typeof(NoAutoPropertiesAttribute) };
            _customizeAttributeInstanceFixture = this.Create<CustomizeAttribute>(true);
            _customizeAttributeInstance = _customizeAttributeInstanceFixture ?? this.Create<CustomizeAttribute>(false);
            CurrentInstance = _customizeAttributeInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodGetCustomization = "GetCustomization";

        #endregion

        #endregion

        #region General Initializer : Class (CustomizeAttribute) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomizeAttribute" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CustomizeAttribute_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomizeAttribute)

        #region General Initializer : Class (CustomizeAttribute) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomizeAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCustomization, 0)]
        public void AUT_CustomizeAttribute_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CustomizeAttribute) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomizeAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomizeAttribute_Is_Instance_Present_Test()
        {
            // Assert
            _customizeAttributeInstanceType.ShouldNotBeNull();
            _customizeAttributeInstance.ShouldNotBeNull();
            _customizeAttributeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomizeAttribute) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomizeAttribute" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomizeAttribute_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customizeAttributeInstance.ShouldBeAssignableTo<CustomizeAttribute>();
            _customizeAttributeInstanceFixture.ShouldBeAssignableTo<CustomizeAttribute>();
            CurrentInstance.ShouldBeAssignableTo<CustomizeAttribute>();
        }

        #endregion

        #endregion

        #endregion
    }
}
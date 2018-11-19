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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.SpecimenCreatedEventArgs" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenCreatedEventArgsTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenCreatedEventArgs" />)
        /// </summary>
        public SpecimenCreatedEventArgsTest() : base(typeof(SpecimenCreatedEventArgs))
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

        #region General Initializer : Class (SpecimenCreatedEventArgs) Initializer

        #region General Initializer : Class (SpecimenCreatedEventArgs) One time setup

        private Type _specimenCreatedEventArgsInstanceType;
        private SpecimenCreatedEventArgs _specimenCreatedEventArgsInstance;
        private SpecimenCreatedEventArgs _specimenCreatedEventArgsInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenCreatedEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenCreatedEventArgsInstanceType = typeof(SpecimenCreatedEventArgs);
            _specimenCreatedEventArgsInstanceFixture = this.Create<SpecimenCreatedEventArgs>(true);
            _specimenCreatedEventArgsInstance = _specimenCreatedEventArgsInstanceFixture ?? this.Create<SpecimenCreatedEventArgs>(false);
            CurrentInstance = _specimenCreatedEventArgsInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertySpecimen = "Specimen";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenCreatedEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenCreatedEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenCreatedEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenCreatedEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenCreatedEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenCreatedEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenCreatedEventArgs)

        #region General Initializer : Class (SpecimenCreatedEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySpecimen)]
        public void AUT_SpecimenCreatedEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SpecimenCreatedEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenCreatedEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _specimenCreatedEventArgsInstanceType.ShouldNotBeNull();
            _specimenCreatedEventArgsInstance.ShouldNotBeNull();
            _specimenCreatedEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SpecimenCreatedEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SpecimenCreatedEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenCreatedEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _specimenCreatedEventArgsInstance.ShouldBeAssignableTo<SpecimenCreatedEventArgs>();
            _specimenCreatedEventArgsInstanceFixture.ShouldBeAssignableTo<SpecimenCreatedEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<SpecimenCreatedEventArgs>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SpecimenCreatedEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenCreatedEventArgs_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var specimen = this.CreateType<object>();
            var depth = this.CreateType<int>();
            SpecimenCreatedEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenCreatedEventArgs(request, specimen, depth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenCreatedEventArgsInstance.ShouldNotBeNull();
            _specimenCreatedEventArgsInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SpecimenCreatedEventArgs>();
        }

        #endregion

        #region General Constructor : Class (SpecimenCreatedEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenCreatedEventArgs_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var specimen = this.CreateType<object>();
            var depth = this.CreateType<int>();
            SpecimenCreatedEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenCreatedEventArgs(request, specimen, depth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenCreatedEventArgsInstance.ShouldNotBeNull();
            _specimenCreatedEventArgsInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SpecimenCreatedEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySpecimen)]
        public void AUT_SpecimenCreatedEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SpecimenCreatedEventArgs) => Property (Specimen) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenCreatedEventArgs_Specimen_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecimen);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySpecimen);
            Action currentAction = () => propertyInfo.SetValue(_specimenCreatedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenCreatedEventArgs) => Property (Specimen) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenCreatedEventArgs_Public_Class_Specimen_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecimen);
            var propertyInfo = this.GetPropertyInfo(PropertySpecimen);

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
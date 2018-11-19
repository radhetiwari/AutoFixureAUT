namespace AutoFixture
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
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.SpecimenBuilderNodeEventArgs" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenBuilderNodeEventArgsTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenBuilderNodeEventArgs" />)
        /// </summary>
        public SpecimenBuilderNodeEventArgsTest() : base(typeof(SpecimenBuilderNodeEventArgs))
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

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) Initializer

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) One time setup

        private Type _specimenBuilderNodeEventArgsInstanceType;
        private SpecimenBuilderNodeEventArgs _specimenBuilderNodeEventArgsInstance;
        private SpecimenBuilderNodeEventArgs _specimenBuilderNodeEventArgsInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenBuilderNodeEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenBuilderNodeEventArgsInstanceType = typeof(SpecimenBuilderNodeEventArgs);
            _specimenBuilderNodeEventArgsInstanceFixture = this.Create<SpecimenBuilderNodeEventArgs>(true);
            _specimenBuilderNodeEventArgsInstance = _specimenBuilderNodeEventArgsInstanceFixture ?? this.Create<SpecimenBuilderNodeEventArgs>(false);
            CurrentInstance = _specimenBuilderNodeEventArgsInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyGraph = "Graph";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenBuilderNodeEventArgs)

        #region General Initializer : Class (SpecimenBuilderNodeEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyGraph)]
        public void AUT_SpecimenBuilderNodeEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SpecimenBuilderNodeEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNodeEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _specimenBuilderNodeEventArgsInstanceType.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstance.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SpecimenBuilderNodeEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNodeEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _specimenBuilderNodeEventArgsInstance.ShouldBeAssignableTo<SpecimenBuilderNodeEventArgs>();
            _specimenBuilderNodeEventArgsInstanceFixture.ShouldBeAssignableTo<SpecimenBuilderNodeEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<SpecimenBuilderNodeEventArgs>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SpecimenBuilderNodeEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenBuilderNodeEventArgs_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            SpecimenBuilderNodeEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenBuilderNodeEventArgs(graph);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstance.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SpecimenBuilderNodeEventArgs>();
        }

        #endregion

        #region General Constructor : Class (SpecimenBuilderNodeEventArgs) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenBuilderNodeEventArgs_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            SpecimenBuilderNodeEventArgs instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenBuilderNodeEventArgs(graph);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstance.ShouldNotBeNull();
            _specimenBuilderNodeEventArgsInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SpecimenBuilderNodeEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyGraph)]
        public void AUT_SpecimenBuilderNodeEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SpecimenBuilderNodeEventArgs) => Property (Graph) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeEventArgs_Graph_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGraph);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyGraph);
            Action currentAction = () => propertyInfo.SetValue(_specimenBuilderNodeEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeEventArgs) => Property (Graph) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeEventArgs_Public_Class_Graph_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGraph);
            var propertyInfo = this.GetPropertyInfo(PropertyGraph);

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
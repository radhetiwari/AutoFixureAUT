namespace AutoFixture
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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
    using AutoFixture.DataAnnotations;
    using AutoFixture.Dsl;
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Fixture" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FixtureTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Fixture" />)
        /// </summary>
        public FixtureTest() : base(typeof(Fixture))
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

        #region General Initializer : Class (Fixture) Initializer

        #region General Initializer : Class (Fixture) One time setup

        private Type _fixtureInstanceType;
        private Fixture _fixtureInstance;
        private Fixture _fixtureInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="Fixture" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fixtureInstanceType = typeof(Fixture);
            _fixtureInstanceFixture = this.Create<Fixture>(true);
            _fixtureInstance = _fixtureInstanceFixture ?? this.Create<Fixture>(false);
            CurrentInstance = _fixtureInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBehaviors = "Behaviors";
        private const string PropertyCustomizations = "Customizations";
        private const string PropertyEngine = "Engine";
        private const string PropertyOmitAutoProperties = "OmitAutoProperties";
        private const string PropertyRepeatCount = "RepeatCount";
        private const string PropertyResidueCollectors = "ResidueCollectors";
        private const string PropertyEnableAutoProperties = "EnableAutoProperties";

        #endregion

        #region Methods

        private const string MethodBuild = "Build";
        private const string MethodCustomize = "Customize";
        private const string MethodCreate = "Create";
        private const string MethodGetEnumerator = "GetEnumerator";
        private const string MethodUpdateGraphAndSetupAdapters = "UpdateGraphAndSetupAdapters";
        private const string MethodUpdateCustomizer = "UpdateCustomizer";
        private const string MethodUpdateResidueCollector = "UpdateResidueCollector";
        private const string MethodUpdateBehaviors = "UpdateBehaviors";
        private const string MethodFindAutoPropertiesPostProcessor = "FindAutoPropertiesPostProcessor";
        private const string MethodMakeFixedBuilder = "MakeFixedBuilder";
        private const string MethodMakeQueryBasedBuilderForMatchingType = "MakeQueryBasedBuilderForMatchingType";

        #endregion

        #region Fields

        private const string Fieldmultiple = "multiple";
        private const string Fieldgraph = "graph";
        private const string Fieldbehaviors = "behaviors";
        private const string Fieldcustomizer = "customizer";
        private const string FieldresidueCollector = "residueCollector";

        #endregion

        #endregion

        #region General Initializer : Class (Fixture) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_Fixture_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Fixture) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_Fixture_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Fixture) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_Fixture_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Fixture)

        #region General Initializer : Class (Fixture) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCustomize, 0)]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodGetEnumerator, 0)]
        [TestCase(MethodUpdateGraphAndSetupAdapters, 0)]
        [TestCase(MethodUpdateGraphAndSetupAdapters, 1)]
        [TestCase(MethodUpdateCustomizer, 0)]
        [TestCase(MethodUpdateResidueCollector, 0)]
        [TestCase(MethodUpdateBehaviors, 0)]
        [TestCase(MethodFindAutoPropertiesPostProcessor, 0)]
        [TestCase(MethodMakeQueryBasedBuilderForMatchingType, 0)]
        [TestCase(MethodMakeQueryBasedBuilderForMatchingType, 1)]
        public void AUT_Fixture_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Fixture) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBehaviors)]
        [TestCase(PropertyCustomizations)]
        [TestCase(PropertyEngine)]
        [TestCase(PropertyOmitAutoProperties)]
        [TestCase(PropertyRepeatCount)]
        [TestCase(PropertyResidueCollectors)]
        [TestCase(PropertyEnableAutoProperties)]
        public void AUT_Fixture_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Fixture) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldmultiple)]
        [TestCase(Fieldgraph)]
        [TestCase(Fieldbehaviors)]
        [TestCase(Fieldcustomizer)]
        [TestCase(FieldresidueCollector)]
        public void AUT_Fixture_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Fixture) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Fixture" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Fixture_Is_Instance_Present_Test()
        {
            // Assert
            _fixtureInstanceType.ShouldNotBeNull();
            _fixtureInstance.ShouldNotBeNull();
            _fixtureInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Fixture) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Fixture" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Fixture_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _fixtureInstance.ShouldBeAssignableTo<Fixture>();
            _fixtureInstanceFixture.ShouldBeAssignableTo<Fixture>();
            CurrentInstance.ShouldBeAssignableTo<Fixture>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Fixture) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Fixture instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (Fixture) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var engineParts = this.CreateType<DefaultRelays>();
            Fixture instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Fixture(engineParts);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _fixtureInstance.ShouldNotBeNull();
            _fixtureInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Fixture>();
        }

        #endregion

        #region General Constructor : Class (Fixture) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var engineParts = this.CreateType<DefaultRelays>();
            Fixture instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Fixture(engineParts);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _fixtureInstance.ShouldNotBeNull();
            _fixtureInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Fixture) instance created

        /// <summary>
        ///     Class (<see cref="Fixture" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Is_Created_Test()
        {
            // Assert
            _fixtureInstance.ShouldNotBeNull();
            _fixtureInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Fixture) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Fixture" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_Fixture_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Fixture) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Fixture" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Fixture) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Fixture" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodFixtureParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFixtureParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Fixture) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Fixture" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFixtureParametersTypes = new Type[] { typeof(DefaultRelays) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFixtureParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Fixture) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Fixture" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Fixture_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFixtureParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(MultipleRelay) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFixtureParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Fixture) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBehaviors)]
        [TestCase(PropertyCustomizations)]
        [TestCase(PropertyEngine)]
        [TestCase(PropertyOmitAutoProperties)]
        [TestCase(PropertyRepeatCount)]
        [TestCase(PropertyResidueCollectors)]
        [TestCase(PropertyEnableAutoProperties)]
        public void AUT_Fixture_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Fixture) => Property (Behaviors) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_Behaviors_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBehaviors);
            var propertyInfo = this.GetPropertyInfo(PropertyBehaviors);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (Customizations) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_Customizations_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomizations);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomizations);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (EnableAutoProperties) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_EnableAutoProperties_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnableAutoProperties);
            var propertyInfo = this.GetPropertyInfo(PropertyEnableAutoProperties);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (Engine) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Engine_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEngine);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEngine);
            Action currentAction = () => propertyInfo.SetValue(_fixtureInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (Engine) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_Engine_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEngine);
            var propertyInfo = this.GetPropertyInfo(PropertyEngine);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (OmitAutoProperties) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_OmitAutoProperties_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOmitAutoProperties);
            var propertyInfo = this.GetPropertyInfo(PropertyOmitAutoProperties);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (RepeatCount) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_RepeatCount_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRepeatCount);
            var propertyInfo = this.GetPropertyInfo(PropertyRepeatCount);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Fixture) => Property (ResidueCollectors) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Fixture_Public_Class_ResidueCollectors_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResidueCollectors);
            var propertyInfo = this.GetPropertyInfo(PropertyResidueCollectors);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Customize) (Return Type : IFixture) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_Customize_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var customization = this.CreateType<ICustomization>();

            // Act
            Action executeAction = () => _fixtureInstance.Customize(customization);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var customization = this.CreateType<ICustomization>();
            var returnedValue = default(IFixture);

            // Act
            Action executeAction = () => returnedValue = _fixtureInstance.Customize(customization);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var customization = this.CreateType<ICustomization>();
            var methodCustomizeParametersTypes = new Type[] { typeof(ICustomization) };
            object[] parametersOfCustomize = { customization };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCustomize, methodCustomizeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IFixture>(_fixtureInstanceFixture, parametersOfCustomize);
            var result2 = this.GetResultOfMethod<IFixture>(MethodCustomize, parametersOfCustomize, methodCustomizeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var customization = this.CreateType<ICustomization>();
            var methodCustomizeParametersTypes = new Type[] { typeof(ICustomization) };
            object[] parametersOfCustomize = { customization };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IFixture>(MethodCustomize, parametersOfCustomize, methodCustomizeParametersTypes);

            // Assert
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodCustomizeParametersTypes = new Type[] { typeof(ICustomization) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCustomizeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodCustomizeParametersTypes = new Type[] { typeof(ICustomization) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Customize) (Return Type : IFixture) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Customize_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _fixtureInstance.Create(request, context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _fixtureInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_fixtureInstanceFixture, parametersOfCreate);
            var result2 = this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_Create_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_GetEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);

            // Act
            Action executeAction = () => _fixtureInstance.GetEnumerator();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var returnedValue = default(IEnumerator<ISpecimenBuilder>);

            // Act
            Action executeAction = () => returnedValue = _fixtureInstance.GetEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator<ISpecimenBuilder>>(_fixtureInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_GetEnumerator_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<System.Collections.IEnumerator>(_fixtureInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Internally(Type[] types)
        {
            var methodUpdateGraphAndSetupAdaptersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var newGraph = this.CreateType<ISpecimenBuilderNode>();
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfUpdateGraphAndSetupAdapters = { newGraph };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfUpdateGraphAndSetupAdapters);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateGraphAndSetupAdapters.ShouldNotBeNull();
            parametersOfUpdateGraphAndSetupAdapters.Length.ShouldBe(1);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(1);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(parametersOfUpdateGraphAndSetupAdapters.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var newGraph = this.CreateType<ISpecimenBuilderNode>();
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfUpdateGraphAndSetupAdapters = { newGraph };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateGraphAndSetupAdapters, parametersOfUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);

            // Assert
            parametersOfUpdateGraphAndSetupAdapters.ShouldNotBeNull();
            parametersOfUpdateGraphAndSetupAdapters.Length.ShouldBe(1);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(1);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(parametersOfUpdateGraphAndSetupAdapters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);

            // Assert
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodUpdateGraphAndSetupAdaptersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var newGraph = this.CreateType<ISpecimenBuilderNode>();
            var existingBehaviors = this.CreateType<IEnumerable<ISpecimenBuilderTransformation>>();
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilderTransformation>) };
            object[] parametersOfUpdateGraphAndSetupAdapters = { newGraph, existingBehaviors };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfUpdateGraphAndSetupAdapters);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateGraphAndSetupAdapters.ShouldNotBeNull();
            parametersOfUpdateGraphAndSetupAdapters.Length.ShouldBe(2);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(2);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(parametersOfUpdateGraphAndSetupAdapters.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var newGraph = this.CreateType<ISpecimenBuilderNode>();
            var existingBehaviors = this.CreateType<IEnumerable<ISpecimenBuilderTransformation>>();
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilderTransformation>) };
            object[] parametersOfUpdateGraphAndSetupAdapters = { newGraph, existingBehaviors };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateGraphAndSetupAdapters, parametersOfUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);

            // Assert
            parametersOfUpdateGraphAndSetupAdapters.ShouldNotBeNull();
            parametersOfUpdateGraphAndSetupAdapters.Length.ShouldBe(2);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(2);
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(parametersOfUpdateGraphAndSetupAdapters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, 1);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodUpdateGraphAndSetupAdaptersParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilderTransformation>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateGraphAndSetupAdapters, methodUpdateGraphAndSetupAdaptersParametersTypes);

            // Assert
            methodUpdateGraphAndSetupAdaptersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraphAndSetupAdapters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateGraphAndSetupAdapters_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraphAndSetupAdapters);
            var methodInfo = this.GetMethodInfo(MethodUpdateGraphAndSetupAdapters, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateCustomizer) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_UpdateCustomizer_Method_Call_Internally(Type[] types)
        {
            var methodUpdateCustomizerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateCustomizer, methodUpdateCustomizerParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateCustomizer) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateCustomizer_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateCustomizer);
            Type [] methodUpdateCustomizerParametersTypes = null;
            object[] parametersOfUpdateCustomizer = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateCustomizer, methodUpdateCustomizerParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfUpdateCustomizer);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateCustomizer.ShouldBeNull();
            methodUpdateCustomizerParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateCustomizer) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateCustomizer_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateCustomizer);
            Type [] methodUpdateCustomizerParametersTypes = null;
            object[] parametersOfUpdateCustomizer = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateCustomizer, parametersOfUpdateCustomizer, methodUpdateCustomizerParametersTypes);

            // Assert
            parametersOfUpdateCustomizer.ShouldBeNull();
            methodUpdateCustomizerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateCustomizer) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateCustomizer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateCustomizer);
            Type [] methodUpdateCustomizerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateCustomizer, methodUpdateCustomizerParametersTypes);

            // Assert
            methodUpdateCustomizerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateCustomizer) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateCustomizer_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateCustomizer);
            var methodInfo = this.GetMethodInfo(MethodUpdateCustomizer, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateResidueCollector) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_UpdateResidueCollector_Method_Call_Internally(Type[] types)
        {
            var methodUpdateResidueCollectorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateResidueCollector, methodUpdateResidueCollectorParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateResidueCollector) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateResidueCollector_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResidueCollector);
            Type [] methodUpdateResidueCollectorParametersTypes = null;
            object[] parametersOfUpdateResidueCollector = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateResidueCollector, methodUpdateResidueCollectorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfUpdateResidueCollector);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateResidueCollector.ShouldBeNull();
            methodUpdateResidueCollectorParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateResidueCollector) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateResidueCollector_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResidueCollector);
            Type [] methodUpdateResidueCollectorParametersTypes = null;
            object[] parametersOfUpdateResidueCollector = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateResidueCollector, parametersOfUpdateResidueCollector, methodUpdateResidueCollectorParametersTypes);

            // Assert
            parametersOfUpdateResidueCollector.ShouldBeNull();
            methodUpdateResidueCollectorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateResidueCollector) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateResidueCollector_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResidueCollector);
            Type [] methodUpdateResidueCollectorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateResidueCollector, methodUpdateResidueCollectorParametersTypes);

            // Assert
            methodUpdateResidueCollectorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateResidueCollector) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateResidueCollector_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResidueCollector);
            var methodInfo = this.GetMethodInfo(MethodUpdateResidueCollector, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_UpdateBehaviors_Method_Call_Internally(Type[] types)
        {
            var methodUpdateBehaviorsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateBehaviors, methodUpdateBehaviorsParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateBehaviors_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateBehaviors);
            var existingTransformations = this.CreateType<ISpecimenBuilderTransformation[]>();
            var methodUpdateBehaviorsParametersTypes = new Type[] { typeof(ISpecimenBuilderTransformation[]) };
            object[] parametersOfUpdateBehaviors = { existingTransformations };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateBehaviors, methodUpdateBehaviorsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfUpdateBehaviors);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateBehaviors.ShouldNotBeNull();
            parametersOfUpdateBehaviors.Length.ShouldBe(1);
            methodUpdateBehaviorsParametersTypes.Length.ShouldBe(1);
            methodUpdateBehaviorsParametersTypes.Length.ShouldBe(parametersOfUpdateBehaviors.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateBehaviors_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateBehaviors);
            var existingTransformations = this.CreateType<ISpecimenBuilderTransformation[]>();
            var methodUpdateBehaviorsParametersTypes = new Type[] { typeof(ISpecimenBuilderTransformation[]) };
            object[] parametersOfUpdateBehaviors = { existingTransformations };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateBehaviors, parametersOfUpdateBehaviors, methodUpdateBehaviorsParametersTypes);

            // Assert
            parametersOfUpdateBehaviors.ShouldNotBeNull();
            parametersOfUpdateBehaviors.Length.ShouldBe(1);
            methodUpdateBehaviorsParametersTypes.Length.ShouldBe(1);
            methodUpdateBehaviorsParametersTypes.Length.ShouldBe(parametersOfUpdateBehaviors.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateBehaviors_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateBehaviors);
            var methodInfo = this.GetMethodInfo(MethodUpdateBehaviors, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateBehaviors_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateBehaviors);
            var methodUpdateBehaviorsParametersTypes = new Type[] { typeof(ISpecimenBuilderTransformation[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateBehaviors, methodUpdateBehaviorsParametersTypes);

            // Assert
            methodUpdateBehaviorsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateBehaviors) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_UpdateBehaviors_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateBehaviors);
            var methodInfo = this.GetMethodInfo(MethodUpdateBehaviors, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_Internally(Type[] types)
        {
            var methodFindAutoPropertiesPostProcessorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesPostProcessor);
            Type [] methodFindAutoPropertiesPostProcessorParametersTypes = null;
            object[] parametersOfFindAutoPropertiesPostProcessor = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<Postprocessor>(_fixtureInstanceFixture, parametersOfFindAutoPropertiesPostProcessor);
            var result2 = this.GetResultOfMethod<Postprocessor>(MethodFindAutoPropertiesPostProcessor, parametersOfFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFindAutoPropertiesPostProcessor.ShouldBeNull();
            methodFindAutoPropertiesPostProcessorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesPostProcessor);
            Type [] methodFindAutoPropertiesPostProcessorParametersTypes = null;
            object[] parametersOfFindAutoPropertiesPostProcessor = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Postprocessor>(MethodFindAutoPropertiesPostProcessor, parametersOfFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes);

            // Assert
            parametersOfFindAutoPropertiesPostProcessor.ShouldBeNull();
            methodFindAutoPropertiesPostProcessorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesPostProcessor);
            Type [] methodFindAutoPropertiesPostProcessorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindAutoPropertiesPostProcessorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesPostProcessor);
            Type [] methodFindAutoPropertiesPostProcessorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesPostProcessor, methodFindAutoPropertiesPostProcessorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindAutoPropertiesPostProcessorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAutoPropertiesPostProcessor) (Return Type : Postprocessor) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_FindAutoPropertiesPostProcessor_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesPostProcessor);
            var methodInfo = this.GetMethodInfo(MethodFindAutoPropertiesPostProcessor, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Internally(Type[] types)
        {
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var matchingType = this.CreateType<Type>();
            var query = this.CreateType<IMethodQuery>();
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery) };
            object[] parametersOfMakeQueryBasedBuilderForMatchingType = { matchingType, query };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodMakeQueryBasedBuilderForMatchingType, parametersOfMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfMakeQueryBasedBuilderForMatchingType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.ShouldNotBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.Length.ShouldBe(2);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var matchingType = this.CreateType<Type>();
            var query = this.CreateType<IMethodQuery>();
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery) };
            object[] parametersOfMakeQueryBasedBuilderForMatchingType = { matchingType, query };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodMakeQueryBasedBuilderForMatchingType, parametersOfMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            parametersOfMakeQueryBasedBuilderForMatchingType.ShouldNotBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.Length.ShouldBe(2);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var matchingType = this.CreateType<Type>();
            var query = this.CreateType<IMethodQuery>();
            var command = this.CreateType<ISpecimenCommand>();
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery), typeof(ISpecimenCommand) };
            object[] parametersOfMakeQueryBasedBuilderForMatchingType = { matchingType, query, command };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodMakeQueryBasedBuilderForMatchingType, parametersOfMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_fixtureInstanceFixture, parametersOfMakeQueryBasedBuilderForMatchingType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.ShouldNotBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.Length.ShouldBe(3);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var matchingType = this.CreateType<Type>();
            var query = this.CreateType<IMethodQuery>();
            var command = this.CreateType<ISpecimenCommand>();
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery), typeof(ISpecimenCommand) };
            object[] parametersOfMakeQueryBasedBuilderForMatchingType = { matchingType, query, command };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodMakeQueryBasedBuilderForMatchingType, parametersOfMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            parametersOfMakeQueryBasedBuilderForMatchingType.ShouldNotBeNull();
            parametersOfMakeQueryBasedBuilderForMatchingType.Length.ShouldBe(3);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery), typeof(ISpecimenCommand) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodMakeQueryBasedBuilderForMatchingTypeParametersTypes = new Type[] { typeof(Type), typeof(IMethodQuery), typeof(ISpecimenCommand) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMakeQueryBasedBuilderForMatchingType, methodMakeQueryBasedBuilderForMatchingTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMakeQueryBasedBuilderForMatchingTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MakeQueryBasedBuilderForMatchingType) (Return Type : ISpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Fixture_MakeQueryBasedBuilderForMatchingType_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeQueryBasedBuilderForMatchingType);
            var methodInfo = this.GetMethodInfo(MethodMakeQueryBasedBuilderForMatchingType, 1);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}
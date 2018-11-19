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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.FreezingCustomization" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FreezingCustomizationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FreezingCustomization" />)
        /// </summary>
        public FreezingCustomizationTest() : base(typeof(FreezingCustomization))
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

        #region General Initializer : Class (FreezingCustomization) Initializer

        #region General Initializer : Class (FreezingCustomization) One time setup

        private Type _freezingCustomizationInstanceType;
        private FreezingCustomization _freezingCustomizationInstance;
        private FreezingCustomization _freezingCustomizationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="FreezingCustomization" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _freezingCustomizationInstanceType = typeof(FreezingCustomization);
            _freezingCustomizationInstanceFixture = this.Create<FreezingCustomization>(true);
            _freezingCustomizationInstance = _freezingCustomizationInstanceFixture ?? this.Create<FreezingCustomization>(false);
            CurrentInstance = _freezingCustomizationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTargetType = "TargetType";
        private const string PropertyRegisteredType = "RegisteredType";

        #endregion

        #region Methods

        private const string MethodCustomize = "Customize";

        #endregion

        #endregion

        #region General Initializer : Class (FreezingCustomization) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezingCustomization_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FreezingCustomization) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezingCustomization_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FreezingCustomization) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezingCustomization_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FreezingCustomization)

        #region General Initializer : Class (FreezingCustomization) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCustomize, 0)]
        public void AUT_FreezingCustomization_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FreezingCustomization) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyRegisteredType)]
        public void AUT_FreezingCustomization_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FreezingCustomization) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FreezingCustomization_Is_Instance_Present_Test()
        {
            // Assert
            _freezingCustomizationInstanceType.ShouldNotBeNull();
            _freezingCustomizationInstance.ShouldNotBeNull();
            _freezingCustomizationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FreezingCustomization) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FreezingCustomization_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _freezingCustomizationInstance.ShouldBeAssignableTo<FreezingCustomization>();
            _freezingCustomizationInstanceFixture.ShouldBeAssignableTo<FreezingCustomization>();
            CurrentInstance.ShouldBeAssignableTo<FreezingCustomization>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FreezingCustomization) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            FreezingCustomization instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FreezingCustomization(targetType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _freezingCustomizationInstance.ShouldNotBeNull();
            _freezingCustomizationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FreezingCustomization>();
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            FreezingCustomization instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FreezingCustomization(targetType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _freezingCustomizationInstance.ShouldNotBeNull();
            _freezingCustomizationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) instance created

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_Is_Created_Test()
        {
            // Assert
            _freezingCustomizationInstance.ShouldNotBeNull();
            _freezingCustomizationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="FreezingCustomization" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_FreezingCustomization_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="FreezingCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FreezingCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFreezingCustomizationParametersTypes = new Type[] { typeof(Type) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFreezingCustomizationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (FreezingCustomization) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FreezingCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezingCustomization_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFreezingCustomizationParametersTypes = new Type[] { typeof(Type), typeof(Type) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFreezingCustomizationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (FreezingCustomization) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyRegisteredType)]
        public void AUT_FreezingCustomization_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (FreezingCustomization) => Property (RegisteredType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezingCustomization_RegisteredType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRegisteredType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRegisteredType);
            Action currentAction = () => propertyInfo.SetValue(_freezingCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FreezingCustomization) => Property (RegisteredType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezingCustomization_Public_Class_RegisteredType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRegisteredType);
            var propertyInfo = this.GetPropertyInfo(PropertyRegisteredType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (FreezingCustomization) => Property (TargetType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezingCustomization_TargetType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);
            Action currentAction = () => propertyInfo.SetValue(_freezingCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FreezingCustomization) => Property (TargetType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezingCustomization_Public_Class_TargetType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);

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

        #region Method Call : (Customize) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FreezingCustomization_Customize_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();

            // Act
            Action executeAction = () => _freezingCustomizationInstance.Customize(fixture);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCustomize, methodCustomizeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_freezingCustomizationInstanceFixture, parametersOfCustomize);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCustomize, parametersOfCustomize, methodCustomizeParametersTypes);

            // Assert
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Customize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);

            // Assert
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezingCustomization_Customize_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}
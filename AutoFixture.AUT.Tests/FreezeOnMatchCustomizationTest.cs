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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.FreezeOnMatchCustomization" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FreezeOnMatchCustomizationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FreezeOnMatchCustomization" />)
        /// </summary>
        public FreezeOnMatchCustomizationTest() : base(typeof(FreezeOnMatchCustomization))
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

        #region General Initializer : Class (FreezeOnMatchCustomization) Initializer

        #region General Initializer : Class (FreezeOnMatchCustomization) One time setup

        private Type _freezeOnMatchCustomizationInstanceType;
        private FreezeOnMatchCustomization _freezeOnMatchCustomizationInstance;
        private FreezeOnMatchCustomization _freezeOnMatchCustomizationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="FreezeOnMatchCustomization" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _freezeOnMatchCustomizationInstanceType = typeof(FreezeOnMatchCustomization);
            _freezeOnMatchCustomizationInstanceFixture = this.Create<FreezeOnMatchCustomization>(true);
            _freezeOnMatchCustomizationInstance = _freezeOnMatchCustomizationInstanceFixture ?? this.Create<FreezeOnMatchCustomization>(false);
            CurrentInstance = _freezeOnMatchCustomizationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTargetType = "TargetType";
        private const string PropertyRequest = "Request";
        private const string PropertyMatcher = "Matcher";

        #endregion

        #region Methods

        private const string MethodCustomize = "Customize";
        private const string MethodFreezeSpecimenForMatchingRequests = "FreezeSpecimenForMatchingRequests";
        private const string MethodFreezeSpecimen = "FreezeSpecimen";

        #endregion

        #endregion

        #region General Initializer : Class (FreezeOnMatchCustomization) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezeOnMatchCustomization_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FreezeOnMatchCustomization) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezeOnMatchCustomization_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FreezeOnMatchCustomization) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FreezeOnMatchCustomization_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FreezeOnMatchCustomization)

        #region General Initializer : Class (FreezeOnMatchCustomization) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCustomize, 0)]
        [TestCase(MethodFreezeSpecimenForMatchingRequests, 0)]
        [TestCase(MethodFreezeSpecimen, 0)]
        public void AUT_FreezeOnMatchCustomization_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FreezeOnMatchCustomization) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyRequest)]
        [TestCase(PropertyMatcher)]
        public void AUT_FreezeOnMatchCustomization_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FreezeOnMatchCustomization) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FreezeOnMatchCustomization_Is_Instance_Present_Test()
        {
            // Assert
            _freezeOnMatchCustomizationInstanceType.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FreezeOnMatchCustomization) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FreezeOnMatchCustomization_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _freezeOnMatchCustomizationInstance.ShouldBeAssignableTo<FreezeOnMatchCustomization>();
            _freezeOnMatchCustomizationInstanceFixture.ShouldBeAssignableTo<FreezeOnMatchCustomization>();
            CurrentInstance.ShouldBeAssignableTo<FreezeOnMatchCustomization>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FreezeOnMatchCustomization) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            FreezeOnMatchCustomization instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FreezeOnMatchCustomization(request);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FreezeOnMatchCustomization>();
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            FreezeOnMatchCustomization instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FreezeOnMatchCustomization(request);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) instance created

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_Is_Created_Test()
        {
            // Assert
            _freezeOnMatchCustomizationInstance.ShouldNotBeNull();
            _freezeOnMatchCustomizationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="FreezeOnMatchCustomization" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_FreezeOnMatchCustomization_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="FreezeOnMatchCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FreezeOnMatchCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFreezeOnMatchCustomizationParametersTypes = new Type[] { typeof(object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFreezeOnMatchCustomizationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (FreezeOnMatchCustomization) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FreezeOnMatchCustomization" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FreezeOnMatchCustomization_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFreezeOnMatchCustomizationParametersTypes = new Type[] { typeof(object), typeof(IRequestSpecification) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFreezeOnMatchCustomizationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyRequest)]
        [TestCase(PropertyMatcher)]
        public void AUT_FreezeOnMatchCustomization_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (Matcher) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_Matcher_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMatcher);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMatcher);
            Action currentAction = () => propertyInfo.SetValue(_freezeOnMatchCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (Matcher) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_Public_Class_Matcher_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMatcher);
            var propertyInfo = this.GetPropertyInfo(PropertyMatcher);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (Request) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_Request_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequest);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequest);
            Action currentAction = () => propertyInfo.SetValue(_freezeOnMatchCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (Request) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_Public_Class_Request_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (TargetType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_TargetType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);
            Action currentAction = () => propertyInfo.SetValue(_freezeOnMatchCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FreezeOnMatchCustomization) => Property (TargetType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FreezeOnMatchCustomization_Public_Class_TargetType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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
        private void AUT_FreezeOnMatchCustomization_Customize_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_Customize_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();

            // Act
            Action executeAction = () => _freezeOnMatchCustomizationInstance.Customize(fixture);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_Customize_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCustomize, methodCustomizeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_freezeOnMatchCustomizationInstanceFixture, parametersOfCustomize);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_Customize_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_FreezeOnMatchCustomization_Customize_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_FreezeOnMatchCustomization_Customize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_FreezeOnMatchCustomization_Customize_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_Internally(Type[] types)
        {
            var methodFreezeSpecimenForMatchingRequestsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFreezeSpecimenForMatchingRequests, methodFreezeSpecimenForMatchingRequestsParametersTypes);
        }

        #endregion

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimenForMatchingRequests);
            var fixture = this.CreateType<IFixture>();
            var methodFreezeSpecimenForMatchingRequestsParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfFreezeSpecimenForMatchingRequests = { fixture };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimenForMatchingRequests, methodFreezeSpecimenForMatchingRequestsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_freezeOnMatchCustomizationInstanceFixture, parametersOfFreezeSpecimenForMatchingRequests);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFreezeSpecimenForMatchingRequests.ShouldNotBeNull();
            parametersOfFreezeSpecimenForMatchingRequests.Length.ShouldBe(1);
            methodFreezeSpecimenForMatchingRequestsParametersTypes.Length.ShouldBe(1);
            methodFreezeSpecimenForMatchingRequestsParametersTypes.Length.ShouldBe(parametersOfFreezeSpecimenForMatchingRequests.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimenForMatchingRequests);
            var fixture = this.CreateType<IFixture>();
            var methodFreezeSpecimenForMatchingRequestsParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfFreezeSpecimenForMatchingRequests = { fixture };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFreezeSpecimenForMatchingRequests, parametersOfFreezeSpecimenForMatchingRequests, methodFreezeSpecimenForMatchingRequestsParametersTypes);

            // Assert
            parametersOfFreezeSpecimenForMatchingRequests.ShouldNotBeNull();
            parametersOfFreezeSpecimenForMatchingRequests.Length.ShouldBe(1);
            methodFreezeSpecimenForMatchingRequestsParametersTypes.Length.ShouldBe(1);
            methodFreezeSpecimenForMatchingRequestsParametersTypes.Length.ShouldBe(parametersOfFreezeSpecimenForMatchingRequests.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimenForMatchingRequests);
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimenForMatchingRequests, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimenForMatchingRequests);
            var methodFreezeSpecimenForMatchingRequestsParametersTypes = new Type[] { typeof(IFixture) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFreezeSpecimenForMatchingRequests, methodFreezeSpecimenForMatchingRequestsParametersTypes);

            // Assert
            methodFreezeSpecimenForMatchingRequestsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FreezeSpecimenForMatchingRequests) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimenForMatchingRequests_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimenForMatchingRequests);
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimenForMatchingRequests, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_Internally(Type[] types)
        {
            var methodFreezeSpecimenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFreezeSpecimen, methodFreezeSpecimenParametersTypes);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var fixture = this.CreateType<IFixture>();
            var methodFreezeSpecimenParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfFreezeSpecimen = { fixture };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimen, methodFreezeSpecimenParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilder>(_freezeOnMatchCustomizationInstanceFixture, parametersOfFreezeSpecimen);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodFreezeSpecimen, parametersOfFreezeSpecimen, methodFreezeSpecimenParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFreezeSpecimen.ShouldNotBeNull();
            parametersOfFreezeSpecimen.Length.ShouldBe(1);
            methodFreezeSpecimenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var fixture = this.CreateType<IFixture>();
            var methodFreezeSpecimenParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfFreezeSpecimen = { fixture };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodFreezeSpecimen, parametersOfFreezeSpecimen, methodFreezeSpecimenParametersTypes);

            // Assert
            parametersOfFreezeSpecimen.ShouldNotBeNull();
            parametersOfFreezeSpecimen.Length.ShouldBe(1);
            methodFreezeSpecimenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var methodFreezeSpecimenParametersTypes = new Type[] { typeof(IFixture) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFreezeSpecimen, methodFreezeSpecimenParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFreezeSpecimenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var methodFreezeSpecimenParametersTypes = new Type[] { typeof(IFixture) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFreezeSpecimen, methodFreezeSpecimenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFreezeSpecimenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimen, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FreezeSpecimen) (Return Type : ISpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FreezeOnMatchCustomization_FreezeSpecimen_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeSpecimen);
            var methodInfo = this.GetMethodInfo(MethodFreezeSpecimen, 0);
            const int parametersCount = 1;

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
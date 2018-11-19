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
    using System.Threading;
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
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.NUnit3;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.InlineAutoDataAttribute" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class InlineAutoDataAttributeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="InlineAutoDataAttribute" />)
        /// </summary>
        public InlineAutoDataAttributeTest() : base(typeof(InlineAutoDataAttribute))
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

        #region General Initializer : Class (InlineAutoDataAttribute) Initializer

        #region General Initializer : Class (InlineAutoDataAttribute) One time setup

        private Type _inlineAutoDataAttributeInstanceType;
        private InlineAutoDataAttribute _inlineAutoDataAttributeInstance;
        private InlineAutoDataAttribute _inlineAutoDataAttributeInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="InlineAutoDataAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _inlineAutoDataAttributeInstanceType = typeof(InlineAutoDataAttribute);
            _inlineAutoDataAttributeInstanceFixture = this.Create<InlineAutoDataAttribute>(true);
            _inlineAutoDataAttributeInstance = _inlineAutoDataAttributeInstanceFixture ?? this.Create<InlineAutoDataAttribute>(false);
            CurrentInstance = _inlineAutoDataAttributeInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyFixture = "Fixture";
        private const string PropertyTestMethodBuilder = "TestMethodBuilder";
        private const string PropertyArguments = "Arguments";

        #endregion

        #region Methods

        private const string MethodBuildFrom = "BuildFrom";
        private const string MethodGetParameterValues = "GetParameterValues";
        private const string MethodGetMissingValues = "GetMissingValues";
        private const string MethodGetValueForParameter = "GetValueForParameter";
        private const string MethodCustomizeFixtureByParameter = "CustomizeFixtureByParameter";

        #endregion

        #region Fields

        private const string FieldexistingParameterValues = "existingParameterValues";
        private const string FieldfixtureLazy = "fixtureLazy";
        private const string FieldtestMethodBuilder = "testMethodBuilder";

        #endregion

        #endregion

        #region General Initializer : Class (InlineAutoDataAttribute) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_InlineAutoDataAttribute_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (InlineAutoDataAttribute) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_InlineAutoDataAttribute_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (InlineAutoDataAttribute) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_InlineAutoDataAttribute_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (InlineAutoDataAttribute)

        #region General Initializer : Class (InlineAutoDataAttribute) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodBuildFrom, 0)]
        [TestCase(MethodGetParameterValues, 0)]
        [TestCase(MethodGetMissingValues, 0)]
        [TestCase(MethodGetValueForParameter, 0)]
        [TestCase(MethodCustomizeFixtureByParameter, 0)]
        public void AUT_InlineAutoDataAttribute_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (InlineAutoDataAttribute) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyFixture)]
        [TestCase(PropertyTestMethodBuilder)]
        [TestCase(PropertyArguments)]
        public void AUT_InlineAutoDataAttribute_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (InlineAutoDataAttribute) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldexistingParameterValues)]
        [TestCase(FieldfixtureLazy)]
        [TestCase(FieldtestMethodBuilder)]
        public void AUT_InlineAutoDataAttribute_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (InlineAutoDataAttribute) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_InlineAutoDataAttribute_Is_Instance_Present_Test()
        {
            // Assert
            _inlineAutoDataAttributeInstanceType.ShouldNotBeNull();
            _inlineAutoDataAttributeInstance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (InlineAutoDataAttribute) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_InlineAutoDataAttribute_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _inlineAutoDataAttributeInstance.ShouldBeAssignableTo<InlineAutoDataAttribute>();
            _inlineAutoDataAttributeInstanceFixture.ShouldBeAssignableTo<InlineAutoDataAttribute>();
            CurrentInstance.ShouldBeAssignableTo<InlineAutoDataAttribute>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (InlineAutoDataAttribute) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InlineAutoDataAttribute_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var arguments = this.CreateType<object[]>();
            InlineAutoDataAttribute instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new InlineAutoDataAttribute(arguments);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<InlineAutoDataAttribute>();
        }

        #endregion

        #region General Constructor : Class (InlineAutoDataAttribute) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InlineAutoDataAttribute_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var arguments = this.CreateType<object[]>();
            InlineAutoDataAttribute instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new InlineAutoDataAttribute(arguments);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (InlineAutoDataAttribute) instance created

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InlineAutoDataAttribute_Is_Created_Test()
        {
            // Assert
            _inlineAutoDataAttributeInstance.ShouldNotBeNull();
            _inlineAutoDataAttributeInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (InlineAutoDataAttribute) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="InlineAutoDataAttribute" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_InlineAutoDataAttribute_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (InlineAutoDataAttribute) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="InlineAutoDataAttribute" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InlineAutoDataAttribute_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (InlineAutoDataAttribute) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="InlineAutoDataAttribute" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InlineAutoDataAttribute_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodInlineAutoDataAttributeParametersTypes = new Type[] { typeof(object[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodInlineAutoDataAttributeParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyFixture)]
        [TestCase(PropertyTestMethodBuilder)]
        [TestCase(PropertyArguments)]
        public void AUT_InlineAutoDataAttribute_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => Property (Arguments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InlineAutoDataAttribute_Public_Class_Arguments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyArguments);
            var propertyInfo = this.GetPropertyInfo(PropertyArguments);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => Property (Fixture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InlineAutoDataAttribute_Fixture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFixture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFixture);
            Action currentAction = () => propertyInfo.SetValue(_inlineAutoDataAttributeInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => Property (Fixture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InlineAutoDataAttribute_Public_Class_Fixture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFixture);
            var propertyInfo = this.GetPropertyInfo(PropertyFixture);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => Property (TestMethodBuilder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InlineAutoDataAttribute_TestMethodBuilder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTestMethodBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTestMethodBuilder);
            Action currentAction = () => propertyInfo.SetValue(_inlineAutoDataAttributeInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InlineAutoDataAttribute) => Property (TestMethodBuilder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InlineAutoDataAttribute_Public_Class_TestMethodBuilder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTestMethodBuilder);
            var propertyInfo = this.GetPropertyInfo(PropertyTestMethodBuilder);

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

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_Internally(Type[] types)
        {
            var methodBuildFromParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildFrom, methodBuildFromParametersTypes);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();

            // Act
            Action executeAction = () => _inlineAutoDataAttributeInstance.BuildFrom(method, suite);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var returnedValue = default(IEnumerable<TestMethod>);

            // Act
            Action executeAction = () => returnedValue = _inlineAutoDataAttributeInstance.BuildFrom(method, suite);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var methodBuildFromParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test) };
            object[] parametersOfBuildFrom = { method, suite };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodBuildFrom, methodBuildFromParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<TestMethod>>(_inlineAutoDataAttributeInstanceFixture, out exception1, parametersOfBuildFrom);
            var result2 = this.GetResultOfMethod<IEnumerable<TestMethod>>(MethodBuildFrom, parametersOfBuildFrom, methodBuildFromParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildFrom.ShouldNotBeNull();
            parametersOfBuildFrom.Length.ShouldBe(2);
            methodBuildFromParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var methodBuildFromParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test) };
            object[] parametersOfBuildFrom = { method, suite };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodBuildFrom, methodBuildFromParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_inlineAutoDataAttributeInstanceFixture, parametersOfBuildFrom);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildFrom.ShouldNotBeNull();
            parametersOfBuildFrom.Length.ShouldBe(2);
            methodBuildFromParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var methodBuildFromParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test) };
            object[] parametersOfBuildFrom = { method, suite };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<TestMethod>>(MethodBuildFrom, parametersOfBuildFrom, methodBuildFromParametersTypes);

            // Assert
            parametersOfBuildFrom.ShouldNotBeNull();
            parametersOfBuildFrom.Length.ShouldBe(2);
            methodBuildFromParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var methodBuildFromParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBuildFrom, methodBuildFromParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodBuildFromParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var methodBuildFromParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildFrom, methodBuildFromParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildFromParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var methodInfo = this.GetMethodInfo(MethodBuildFrom, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (BuildFrom) (Return Type : IEnumerable<TestMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_BuildFrom_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildFrom);
            var methodInfo = this.GetMethodInfo(MethodBuildFrom, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_Internally(Type[] types)
        {
            var methodGetParameterValuesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameterValues, methodGetParameterValuesParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var method = this.CreateType<IMethodInfo>();
            var methodGetParameterValuesParametersTypes = new Type[] { typeof(IMethodInfo) };
            object[] parametersOfGetParameterValues = { method };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetParameterValues, methodGetParameterValuesParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<object>>(_inlineAutoDataAttributeInstanceFixture, out exception1, parametersOfGetParameterValues);
            var result2 = this.GetResultOfMethod<IEnumerable<object>>(MethodGetParameterValues, parametersOfGetParameterValues, methodGetParameterValuesParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetParameterValues.ShouldNotBeNull();
            parametersOfGetParameterValues.Length.ShouldBe(1);
            methodGetParameterValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var method = this.CreateType<IMethodInfo>();
            var methodGetParameterValuesParametersTypes = new Type[] { typeof(IMethodInfo) };
            object[] parametersOfGetParameterValues = { method };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetParameterValues, methodGetParameterValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_inlineAutoDataAttributeInstanceFixture, parametersOfGetParameterValues);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetParameterValues.ShouldNotBeNull();
            parametersOfGetParameterValues.Length.ShouldBe(1);
            methodGetParameterValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var method = this.CreateType<IMethodInfo>();
            var methodGetParameterValuesParametersTypes = new Type[] { typeof(IMethodInfo) };
            object[] parametersOfGetParameterValues = { method };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<object>>(MethodGetParameterValues, parametersOfGetParameterValues, methodGetParameterValuesParametersTypes);

            // Assert
            parametersOfGetParameterValues.ShouldNotBeNull();
            parametersOfGetParameterValues.Length.ShouldBe(1);
            methodGetParameterValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var methodGetParameterValuesParametersTypes = new Type[] { typeof(IMethodInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameterValues, methodGetParameterValuesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParameterValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var methodGetParameterValuesParametersTypes = new Type[] { typeof(IMethodInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameterValues, methodGetParameterValuesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParameterValuesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var methodInfo = this.GetMethodInfo(MethodGetParameterValues, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterValues) (Return Type : IEnumerable<object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetParameterValues_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterValues);
            var methodInfo = this.GetMethodInfo(MethodGetParameterValues, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_Internally(Type[] types)
        {
            var methodGetMissingValuesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMissingValues, methodGetMissingValuesParametersTypes);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var parameters = this.CreateType<IEnumerable<IParameterInfo>>();
            var methodGetMissingValuesParametersTypes = new Type[] { typeof(IEnumerable<IParameterInfo>) };
            object[] parametersOfGetMissingValues = { parameters };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetMissingValues, methodGetMissingValuesParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<object>>(_inlineAutoDataAttributeInstanceFixture, out exception1, parametersOfGetMissingValues);
            var result2 = this.GetResultOfMethod<IEnumerable<object>>(MethodGetMissingValues, parametersOfGetMissingValues, methodGetMissingValuesParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMissingValues.ShouldNotBeNull();
            parametersOfGetMissingValues.Length.ShouldBe(1);
            methodGetMissingValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var parameters = this.CreateType<IEnumerable<IParameterInfo>>();
            var methodGetMissingValuesParametersTypes = new Type[] { typeof(IEnumerable<IParameterInfo>) };
            object[] parametersOfGetMissingValues = { parameters };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetMissingValues, methodGetMissingValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_inlineAutoDataAttributeInstanceFixture, parametersOfGetMissingValues);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMissingValues.ShouldNotBeNull();
            parametersOfGetMissingValues.Length.ShouldBe(1);
            methodGetMissingValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var parameters = this.CreateType<IEnumerable<IParameterInfo>>();
            var methodGetMissingValuesParametersTypes = new Type[] { typeof(IEnumerable<IParameterInfo>) };
            object[] parametersOfGetMissingValues = { parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<object>>(MethodGetMissingValues, parametersOfGetMissingValues, methodGetMissingValuesParametersTypes);

            // Assert
            parametersOfGetMissingValues.ShouldNotBeNull();
            parametersOfGetMissingValues.Length.ShouldBe(1);
            methodGetMissingValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var methodGetMissingValuesParametersTypes = new Type[] { typeof(IEnumerable<IParameterInfo>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMissingValues, methodGetMissingValuesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMissingValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var methodGetMissingValuesParametersTypes = new Type[] { typeof(IEnumerable<IParameterInfo>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMissingValues, methodGetMissingValuesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMissingValuesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var methodInfo = this.GetMethodInfo(MethodGetMissingValues, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMissingValues) (Return Type : IEnumerable<object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetMissingValues_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMissingValues);
            var methodInfo = this.GetMethodInfo(MethodGetMissingValues, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetValueForParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetValueForParameter, methodGetValueForParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var parameterInfo = this.CreateType<IParameterInfo>();
            var methodGetValueForParameterParametersTypes = new Type[] { typeof(IParameterInfo) };
            object[] parametersOfGetValueForParameter = { parameterInfo };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetValueForParameter, methodGetValueForParameterParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_inlineAutoDataAttributeInstanceFixture, parametersOfGetValueForParameter);
            var result2 = this.GetResultOfMethod<object>(MethodGetValueForParameter, parametersOfGetValueForParameter, methodGetValueForParameterParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetValueForParameter.ShouldNotBeNull();
            parametersOfGetValueForParameter.Length.ShouldBe(1);
            methodGetValueForParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var parameterInfo = this.CreateType<IParameterInfo>();
            var methodGetValueForParameterParametersTypes = new Type[] { typeof(IParameterInfo) };
            object[] parametersOfGetValueForParameter = { parameterInfo };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetValueForParameter, parametersOfGetValueForParameter, methodGetValueForParameterParametersTypes);

            // Assert
            parametersOfGetValueForParameter.ShouldNotBeNull();
            parametersOfGetValueForParameter.Length.ShouldBe(1);
            methodGetValueForParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var methodGetValueForParameterParametersTypes = new Type[] { typeof(IParameterInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetValueForParameter, methodGetValueForParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetValueForParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var methodGetValueForParameterParametersTypes = new Type[] { typeof(IParameterInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetValueForParameter, methodGetValueForParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetValueForParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var methodInfo = this.GetMethodInfo(MethodGetValueForParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetValueForParameter) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_GetValueForParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueForParameter);
            var methodInfo = this.GetMethodInfo(MethodGetValueForParameter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeFixtureByParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomizeFixtureByParameter, methodCustomizeFixtureByParameterParametersTypes);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomizeFixtureByParameter);
            var parameter = this.CreateType<IParameterInfo>();
            var methodCustomizeFixtureByParameterParametersTypes = new Type[] { typeof(IParameterInfo) };
            object[] parametersOfCustomizeFixtureByParameter = { parameter };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCustomizeFixtureByParameter, methodCustomizeFixtureByParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_inlineAutoDataAttributeInstanceFixture, parametersOfCustomizeFixtureByParameter);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCustomizeFixtureByParameter.ShouldNotBeNull();
            parametersOfCustomizeFixtureByParameter.Length.ShouldBe(1);
            methodCustomizeFixtureByParameterParametersTypes.Length.ShouldBe(1);
            methodCustomizeFixtureByParameterParametersTypes.Length.ShouldBe(parametersOfCustomizeFixtureByParameter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomizeFixtureByParameter);
            var parameter = this.CreateType<IParameterInfo>();
            var methodCustomizeFixtureByParameterParametersTypes = new Type[] { typeof(IParameterInfo) };
            object[] parametersOfCustomizeFixtureByParameter = { parameter };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCustomizeFixtureByParameter, parametersOfCustomizeFixtureByParameter, methodCustomizeFixtureByParameterParametersTypes);

            // Assert
            parametersOfCustomizeFixtureByParameter.ShouldNotBeNull();
            parametersOfCustomizeFixtureByParameter.Length.ShouldBe(1);
            methodCustomizeFixtureByParameterParametersTypes.Length.ShouldBe(1);
            methodCustomizeFixtureByParameterParametersTypes.Length.ShouldBe(parametersOfCustomizeFixtureByParameter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomizeFixtureByParameter);
            var methodInfo = this.GetMethodInfo(MethodCustomizeFixtureByParameter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomizeFixtureByParameter);
            var methodCustomizeFixtureByParameterParametersTypes = new Type[] { typeof(IParameterInfo) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCustomizeFixtureByParameter, methodCustomizeFixtureByParameterParametersTypes);

            // Assert
            methodCustomizeFixtureByParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CustomizeFixtureByParameter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InlineAutoDataAttribute_CustomizeFixtureByParameter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomizeFixtureByParameter);
            var methodInfo = this.GetMethodInfo(MethodCustomizeFixtureByParameter, 0);

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
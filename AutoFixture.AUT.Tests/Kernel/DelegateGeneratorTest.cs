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
    using System.Linq.Expressions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.DelegateGenerator" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DelegateGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DelegateGenerator" />)
        /// </summary>
        public DelegateGeneratorTest() : base(typeof(DelegateGenerator))
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

        #region General Initializer : Class (DelegateGenerator) Initializer

        #region General Initializer : Class (DelegateGenerator) One time setup

        private Type _delegateGeneratorInstanceType;
        private DelegateGenerator _delegateGeneratorInstance;
        private DelegateGenerator _delegateGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="DelegateGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _delegateGeneratorInstanceType = typeof(DelegateGenerator);
            _delegateGeneratorInstanceFixture = this.Create<DelegateGenerator>(true);
            _delegateGeneratorInstance = _delegateGeneratorInstanceFixture ?? this.Create<DelegateGenerator>(false);
            CurrentInstance = _delegateGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertySpecification = "Specification";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodCreateMethodSpecimenParameters = "CreateMethodSpecimenParameters";
        private const string MethodCreateMethodSpecimenBody = "CreateMethodSpecimenBody";

        #endregion

        #endregion

        #region General Initializer : Class (DelegateGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DelegateGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DelegateGenerator) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DelegateGenerator_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DelegateGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DelegateGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DelegateGenerator)

        #region General Initializer : Class (DelegateGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCreateMethodSpecimenParameters, 0)]
        [TestCase(MethodCreateMethodSpecimenBody, 0)]
        public void AUT_DelegateGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DelegateGenerator) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySpecification)]
        public void AUT_DelegateGenerator_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DelegateGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DelegateGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _delegateGeneratorInstanceType.ShouldNotBeNull();
            _delegateGeneratorInstance.ShouldNotBeNull();
            _delegateGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DelegateGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DelegateGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _delegateGeneratorInstance.ShouldBeAssignableTo<DelegateGenerator>();
            _delegateGeneratorInstanceFixture.ShouldBeAssignableTo<DelegateGenerator>();
            CurrentInstance.ShouldBeAssignableTo<DelegateGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DelegateGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DelegateGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var delegateSpecification = this.CreateType<IRequestSpecification>();
            DelegateGenerator instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DelegateGenerator(delegateSpecification);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _delegateGeneratorInstance.ShouldNotBeNull();
            _delegateGeneratorInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DelegateGenerator>();
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var delegateSpecification = this.CreateType<IRequestSpecification>();
            DelegateGenerator instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DelegateGenerator(delegateSpecification);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _delegateGeneratorInstance.ShouldNotBeNull();
            _delegateGeneratorInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) instance created

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Is_Created_Test()
        {
            // Assert
            _delegateGeneratorInstance.ShouldNotBeNull();
            _delegateGeneratorInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DelegateGenerator" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DelegateGenerator_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DelegateGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DelegateGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDelegateGeneratorParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDelegateGeneratorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DelegateGenerator) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DelegateGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelegateGenerator_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDelegateGeneratorParametersTypes = new Type[] { typeof(IRequestSpecification) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDelegateGeneratorParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DelegateGenerator) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySpecification)]
        public void AUT_DelegateGenerator_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DelegateGenerator) => Property (Specification) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DelegateGenerator_Specification_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);
            Action currentAction = () => propertyInfo.SetValue(_delegateGeneratorInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DelegateGenerator) => Property (Specification) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DelegateGenerator_Public_Class_Specification_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);

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

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DelegateGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _delegateGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _delegateGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_delegateGeneratorInstanceFixture, out exception1, parametersOfCreate);
            var result2 = this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_delegateGeneratorInstanceFixture, parametersOfCreate);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DelegateGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DelegateGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DelegateGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DelegateGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateMethodSpecimenParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenParameters, methodCreateMethodSpecimenParametersParametersTypes);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var request = this.CreateType<MethodInfo>();
            var methodCreateMethodSpecimenParametersParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfCreateMethodSpecimenParameters = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenParameters, methodCreateMethodSpecimenParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_delegateGeneratorInstanceFixture, parametersOfCreateMethodSpecimenParameters);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateMethodSpecimenParameters.ShouldNotBeNull();
            parametersOfCreateMethodSpecimenParameters.Length.ShouldBe(1);
            methodCreateMethodSpecimenParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var request = this.CreateType<MethodInfo>();
            var methodCreateMethodSpecimenParametersParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfCreateMethodSpecimenParameters = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<ParameterExpression>>(MethodCreateMethodSpecimenParameters, parametersOfCreateMethodSpecimenParameters, methodCreateMethodSpecimenParametersParametersTypes);

            // Assert
            parametersOfCreateMethodSpecimenParameters.ShouldNotBeNull();
            parametersOfCreateMethodSpecimenParameters.Length.ShouldBe(1);
            methodCreateMethodSpecimenParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var methodCreateMethodSpecimenParametersParametersTypes = new Type[] { typeof(MethodInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenParameters, methodCreateMethodSpecimenParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateMethodSpecimenParametersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var methodCreateMethodSpecimenParametersParametersTypes = new Type[] { typeof(MethodInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenParameters, methodCreateMethodSpecimenParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateMethodSpecimenParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenParameters) (Return Type : IEnumerable<ParameterExpression>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenParameters);
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenParameters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateMethodSpecimenBodyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var request = this.CreateType<MethodInfo>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateMethodSpecimenBodyParametersTypes = new Type[] { typeof(MethodInfo), typeof(ISpecimenContext) };
            object[] parametersOfCreateMethodSpecimenBody = { request, context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);
            var result2 = this.GetResultOfMethod<Expression>(MethodCreateMethodSpecimenBody, parametersOfCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_delegateGeneratorInstanceFixture, parametersOfCreateMethodSpecimenBody);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateMethodSpecimenBody.ShouldNotBeNull();
            parametersOfCreateMethodSpecimenBody.Length.ShouldBe(2);
            methodCreateMethodSpecimenBodyParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var request = this.CreateType<MethodInfo>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateMethodSpecimenBodyParametersTypes = new Type[] { typeof(MethodInfo), typeof(ISpecimenContext) };
            object[] parametersOfCreateMethodSpecimenBody = { request, context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Expression>(MethodCreateMethodSpecimenBody, parametersOfCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);

            // Assert
            parametersOfCreateMethodSpecimenBody.ShouldNotBeNull();
            parametersOfCreateMethodSpecimenBody.Length.ShouldBe(2);
            methodCreateMethodSpecimenBodyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var methodCreateMethodSpecimenBodyParametersTypes = new Type[] { typeof(MethodInfo), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateMethodSpecimenBodyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var methodCreateMethodSpecimenBodyParametersTypes = new Type[] { typeof(MethodInfo), typeof(ISpecimenContext) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMethodSpecimenBody, methodCreateMethodSpecimenBodyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateMethodSpecimenBodyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenBody, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMethodSpecimenBody) (Return Type : Expression) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelegateGenerator_CreateMethodSpecimenBody_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMethodSpecimenBody);
            var methodInfo = this.GetMethodInfo(MethodCreateMethodSpecimenBody, 0);
            const int parametersCount = 2;

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
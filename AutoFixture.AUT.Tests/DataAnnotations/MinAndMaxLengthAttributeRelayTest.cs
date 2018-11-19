namespace AutoFixture.DataAnnotations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
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
    using AutoFixture.DataAnnotations;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.DataAnnotations.MinAndMaxLengthAttributeRelay" />)
    ///     and namespace <see cref="AutoFixture.DataAnnotations"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MinAndMaxLengthAttributeRelayTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MinAndMaxLengthAttributeRelay" />)
        /// </summary>
        public MinAndMaxLengthAttributeRelayTest() : base(typeof(MinAndMaxLengthAttributeRelay))
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

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) Initializer

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) One time setup

        private Type _minAndMaxLengthAttributeRelayInstanceType;
        private MinAndMaxLengthAttributeRelay _minAndMaxLengthAttributeRelayInstance;
        private MinAndMaxLengthAttributeRelay _minAndMaxLengthAttributeRelayInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MinAndMaxLengthAttributeRelay" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _minAndMaxLengthAttributeRelayInstanceType = typeof(MinAndMaxLengthAttributeRelay);
            _minAndMaxLengthAttributeRelayInstanceFixture = this.Create<MinAndMaxLengthAttributeRelay>(true);
            _minAndMaxLengthAttributeRelayInstance = _minAndMaxLengthAttributeRelayInstanceFixture ?? this.Create<MinAndMaxLengthAttributeRelay>(false);
            CurrentInstance = _minAndMaxLengthAttributeRelayInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyRequestMemberTypeResolver = "RequestMemberTypeResolver";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodResolveString = "ResolveString";
        private const string MethodResolveArray = "ResolveArray";

        #endregion

        #region Fields

        private const string FieldrequestMemberTypeResolver = "requestMemberTypeResolver";

        #endregion

        #endregion

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MinAndMaxLengthAttributeRelay_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MinAndMaxLengthAttributeRelay_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MinAndMaxLengthAttributeRelay_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MinAndMaxLengthAttributeRelay)

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodResolveString, 0)]
        [TestCase(MethodResolveArray, 0)]
        public void AUT_MinAndMaxLengthAttributeRelay_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRequestMemberTypeResolver)]
        public void AUT_MinAndMaxLengthAttributeRelay_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (MinAndMaxLengthAttributeRelay) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldrequestMemberTypeResolver)]
        public void AUT_MinAndMaxLengthAttributeRelay_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MinAndMaxLengthAttributeRelay) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MinAndMaxLengthAttributeRelay_Is_Instance_Present_Test()
        {
            // Assert
            _minAndMaxLengthAttributeRelayInstanceType.ShouldNotBeNull();
            _minAndMaxLengthAttributeRelayInstance.ShouldNotBeNull();
            _minAndMaxLengthAttributeRelayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MinAndMaxLengthAttributeRelay) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MinAndMaxLengthAttributeRelay" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MinAndMaxLengthAttributeRelay_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _minAndMaxLengthAttributeRelayInstance.ShouldBeAssignableTo<MinAndMaxLengthAttributeRelay>();
            _minAndMaxLengthAttributeRelayInstanceFixture.ShouldBeAssignableTo<MinAndMaxLengthAttributeRelay>();
            CurrentInstance.ShouldBeAssignableTo<MinAndMaxLengthAttributeRelay>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MinAndMaxLengthAttributeRelay) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MinAndMaxLengthAttributeRelay_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MinAndMaxLengthAttributeRelay instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MinAndMaxLengthAttributeRelay) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRequestMemberTypeResolver)]
        public void AUT_MinAndMaxLengthAttributeRelay_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MinAndMaxLengthAttributeRelay) => Property (RequestMemberTypeResolver) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MinAndMaxLengthAttributeRelay_RequestMemberTypeResolver_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestMemberTypeResolver);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequestMemberTypeResolver);
            Action currentAction = () => propertyInfo.SetValue(_minAndMaxLengthAttributeRelayInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (MinAndMaxLengthAttributeRelay) => Property (RequestMemberTypeResolver) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MinAndMaxLengthAttributeRelay_Public_Class_RequestMemberTypeResolver_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestMemberTypeResolver);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestMemberTypeResolver);

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
        private void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _minAndMaxLengthAttributeRelayInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _minAndMaxLengthAttributeRelayInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_minAndMaxLengthAttributeRelayInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_minAndMaxLengthAttributeRelayInstanceFixture, parametersOfCreate);

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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_MinAndMaxLengthAttributeRelay_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (ResolveString) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_Internally(Type[] types)
        {
            var methodResolveStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveString, methodResolveStringParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var context = this.CreateType<ISpecimenContext>();
            var range = this.CreateType<Range>();
            var methodResolveStringParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Range) };
            object[] parametersOfResolveString = { context, range };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodResolveString, methodResolveStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodResolveString, methodResolveStringParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodResolveString, parametersOfResolveString, methodResolveStringParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_minAndMaxLengthAttributeRelayInstanceFixture, parametersOfResolveString);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveString.ShouldNotBeNull();
            parametersOfResolveString.Length.ShouldBe(2);
            methodResolveStringParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var context = this.CreateType<ISpecimenContext>();
            var range = this.CreateType<Range>();
            var methodResolveStringParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Range) };
            object[] parametersOfResolveString = { context, range };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodResolveString, parametersOfResolveString, methodResolveStringParametersTypes);

            // Assert
            parametersOfResolveString.ShouldNotBeNull();
            parametersOfResolveString.Length.ShouldBe(2);
            methodResolveStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var methodResolveStringParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Range) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveString, methodResolveStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var methodResolveStringParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Range) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveString, methodResolveStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var methodInfo = this.GetMethodInfo(MethodResolveString, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveString) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveString);
            var methodInfo = this.GetMethodInfo(MethodResolveString, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodResolveArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveArray, methodResolveArrayParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var context = this.CreateType<ISpecimenContext>();
            var arrayType = this.CreateType<Type>();
            var range = this.CreateType<Range>();
            var methodResolveArrayParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Type), typeof(Range) };
            object[] parametersOfResolveArray = { context, arrayType, range };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodResolveArray, methodResolveArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodResolveArray, methodResolveArrayParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodResolveArray, parametersOfResolveArray, methodResolveArrayParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_minAndMaxLengthAttributeRelayInstanceFixture, parametersOfResolveArray);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveArray.ShouldNotBeNull();
            parametersOfResolveArray.Length.ShouldBe(3);
            methodResolveArrayParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var context = this.CreateType<ISpecimenContext>();
            var arrayType = this.CreateType<Type>();
            var range = this.CreateType<Range>();
            var methodResolveArrayParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Type), typeof(Range) };
            object[] parametersOfResolveArray = { context, arrayType, range };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodResolveArray, parametersOfResolveArray, methodResolveArrayParametersTypes);

            // Assert
            parametersOfResolveArray.ShouldNotBeNull();
            parametersOfResolveArray.Length.ShouldBe(3);
            methodResolveArrayParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var methodResolveArrayParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Type), typeof(Range) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveArray, methodResolveArrayParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveArrayParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var methodResolveArrayParametersTypes = new Type[] { typeof(ISpecimenContext), typeof(Type), typeof(Range) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveArray, methodResolveArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var methodInfo = this.GetMethodInfo(MethodResolveArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveArray) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MinAndMaxLengthAttributeRelay_ResolveArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveArray);
            var methodInfo = this.GetMethodInfo(MethodResolveArray, 0);
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
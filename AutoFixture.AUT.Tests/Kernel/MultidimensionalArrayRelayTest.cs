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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MultidimensionalArrayRelay" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MultidimensionalArrayRelayTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MultidimensionalArrayRelay" />)
        /// </summary>
        public MultidimensionalArrayRelayTest() : base(typeof(MultidimensionalArrayRelay))
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

        #region General Initializer : Class (MultidimensionalArrayRelay) Initializer

        #region General Initializer : Class (MultidimensionalArrayRelay) One time setup

        private Type _multidimensionalArrayRelayInstanceType;
        private MultidimensionalArrayRelay _multidimensionalArrayRelayInstance;
        private MultidimensionalArrayRelay _multidimensionalArrayRelayInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MultidimensionalArrayRelay" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _multidimensionalArrayRelayInstanceType = typeof(MultidimensionalArrayRelay);
            _multidimensionalArrayRelayInstanceFixture = this.Create<MultidimensionalArrayRelay>(true);
            _multidimensionalArrayRelayInstance = _multidimensionalArrayRelayInstanceFixture ?? this.Create<MultidimensionalArrayRelay>(false);
            CurrentInstance = _multidimensionalArrayRelayInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodIsMultidimensionalArray = "IsMultidimensionalArray";
        private const string MethodCreateMultidimensionalArray = "CreateMultidimensionalArray";
        private const string MethodMakeJaggedArrayType = "MakeJaggedArrayType";
        private const string MethodGetInnerLength = "GetInnerLength";
        private const string MethodCopy = "Copy";
        private const string MethodCopyNextDimension = "CopyNextDimension";
        private const string MethodCopyLastDimension = "CopyLastDimension";

        #endregion

        #endregion

        #region General Initializer : Class (MultidimensionalArrayRelay) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MultidimensionalArrayRelay" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MultidimensionalArrayRelay_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MultidimensionalArrayRelay)

        #region General Initializer : Class (MultidimensionalArrayRelay) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MultidimensionalArrayRelay" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodIsMultidimensionalArray, 0)]
        [TestCase(MethodCreateMultidimensionalArray, 0)]
        [TestCase(MethodMakeJaggedArrayType, 0)]
        [TestCase(MethodGetInnerLength, 0)]
        [TestCase(MethodCopy, 0)]
        [TestCase(MethodCopyNextDimension, 0)]
        [TestCase(MethodCopyLastDimension, 0)]
        public void AUT_MultidimensionalArrayRelay_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MultidimensionalArrayRelay) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MultidimensionalArrayRelay" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MultidimensionalArrayRelay_Is_Instance_Present_Test()
        {
            // Assert
            _multidimensionalArrayRelayInstanceType.ShouldNotBeNull();
            _multidimensionalArrayRelayInstance.ShouldNotBeNull();
            _multidimensionalArrayRelayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MultidimensionalArrayRelay) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MultidimensionalArrayRelay" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MultidimensionalArrayRelay_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _multidimensionalArrayRelayInstance.ShouldBeAssignableTo<MultidimensionalArrayRelay>();
            _multidimensionalArrayRelayInstanceFixture.ShouldBeAssignableTo<MultidimensionalArrayRelay>();
            CurrentInstance.ShouldBeAssignableTo<MultidimensionalArrayRelay>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MultidimensionalArrayRelay) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MultidimensionalArrayRelay_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MultidimensionalArrayRelay instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _multidimensionalArrayRelayInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _multidimensionalArrayRelayInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_multidimensionalArrayRelayInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfCreate);

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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_MultidimensionalArrayRelay_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsMultidimensionalArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsMultidimensionalArray, methodIsMultidimensionalArrayParametersTypes);
        }

        #endregion

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMultidimensionalArray);
            var type = this.CreateType<Type>();
            var methodIsMultidimensionalArrayParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsMultidimensionalArray = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsMultidimensionalArray, methodIsMultidimensionalArrayParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfIsMultidimensionalArray);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsMultidimensionalArray.ShouldNotBeNull();
            parametersOfIsMultidimensionalArray.Length.ShouldBe(1);
            methodIsMultidimensionalArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMultidimensionalArray);
            var type = this.CreateType<Type>();
            var methodIsMultidimensionalArrayParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsMultidimensionalArray = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsMultidimensionalArray, parametersOfIsMultidimensionalArray, methodIsMultidimensionalArrayParametersTypes);

            // Assert
            parametersOfIsMultidimensionalArray.ShouldNotBeNull();
            parametersOfIsMultidimensionalArray.Length.ShouldBe(1);
            methodIsMultidimensionalArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMultidimensionalArray);
            var methodIsMultidimensionalArrayParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsMultidimensionalArray, methodIsMultidimensionalArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsMultidimensionalArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMultidimensionalArray);
            var methodInfo = this.GetMethodInfo(MethodIsMultidimensionalArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsMultidimensionalArray) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_IsMultidimensionalArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMultidimensionalArray);
            var methodInfo = this.GetMethodInfo(MethodIsMultidimensionalArray, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateMultidimensionalArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var arrayType = this.CreateType<Type>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateMultidimensionalArrayParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            object[] parametersOfCreateMultidimensionalArray = { arrayType, context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodCreateMultidimensionalArray, parametersOfCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfCreateMultidimensionalArray);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateMultidimensionalArray.ShouldNotBeNull();
            parametersOfCreateMultidimensionalArray.Length.ShouldBe(2);
            methodCreateMultidimensionalArrayParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var arrayType = this.CreateType<Type>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateMultidimensionalArrayParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            object[] parametersOfCreateMultidimensionalArray = { arrayType, context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateMultidimensionalArray, parametersOfCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);

            // Assert
            parametersOfCreateMultidimensionalArray.ShouldNotBeNull();
            parametersOfCreateMultidimensionalArray.Length.ShouldBe(2);
            methodCreateMultidimensionalArrayParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var methodCreateMultidimensionalArrayParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateMultidimensionalArrayParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var methodCreateMultidimensionalArrayParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMultidimensionalArray, methodCreateMultidimensionalArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateMultidimensionalArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var methodInfo = this.GetMethodInfo(MethodCreateMultidimensionalArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMultidimensionalArray) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CreateMultidimensionalArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMultidimensionalArray);
            var methodInfo = this.GetMethodInfo(MethodCreateMultidimensionalArray, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_Internally(Type[] types)
        {
            var methodMakeJaggedArrayTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMakeJaggedArrayType, methodMakeJaggedArrayTypeParametersTypes);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var elementType = this.CreateType<Type>();
            var dimension = this.CreateType<int>();
            var methodMakeJaggedArrayTypeParametersTypes = new Type[] { typeof(Type), typeof(int) };
            object[] parametersOfMakeJaggedArrayType = { elementType, dimension };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodMakeJaggedArrayType, methodMakeJaggedArrayTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfMakeJaggedArrayType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMakeJaggedArrayType.ShouldNotBeNull();
            parametersOfMakeJaggedArrayType.Length.ShouldBe(2);
            methodMakeJaggedArrayTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var elementType = this.CreateType<Type>();
            var dimension = this.CreateType<int>();
            var methodMakeJaggedArrayTypeParametersTypes = new Type[] { typeof(Type), typeof(int) };
            object[] parametersOfMakeJaggedArrayType = { elementType, dimension };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodMakeJaggedArrayType, parametersOfMakeJaggedArrayType, methodMakeJaggedArrayTypeParametersTypes);

            // Assert
            parametersOfMakeJaggedArrayType.ShouldNotBeNull();
            parametersOfMakeJaggedArrayType.Length.ShouldBe(2);
            methodMakeJaggedArrayTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var methodMakeJaggedArrayTypeParametersTypes = new Type[] { typeof(Type), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMakeJaggedArrayType, methodMakeJaggedArrayTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMakeJaggedArrayTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var methodMakeJaggedArrayTypeParametersTypes = new Type[] { typeof(Type), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMakeJaggedArrayType, methodMakeJaggedArrayTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMakeJaggedArrayTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var methodInfo = this.GetMethodInfo(MethodMakeJaggedArrayType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MakeJaggedArrayType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_MakeJaggedArrayType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeJaggedArrayType);
            var methodInfo = this.GetMethodInfo(MethodMakeJaggedArrayType, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetInnerLengthParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetInnerLength, methodGetInnerLengthParametersTypes);
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerLength);
            var jagged = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var methodGetInnerLengthParametersTypes = new Type[] { typeof(Array), typeof(int) };
            object[] parametersOfGetInnerLength = { jagged, dimension };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetInnerLength, methodGetInnerLengthParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfGetInnerLength);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetInnerLength.ShouldNotBeNull();
            parametersOfGetInnerLength.Length.ShouldBe(2);
            methodGetInnerLengthParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerLength);
            var jagged = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var methodGetInnerLengthParametersTypes = new Type[] { typeof(Array), typeof(int) };
            object[] parametersOfGetInnerLength = { jagged, dimension };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetInnerLength, parametersOfGetInnerLength, methodGetInnerLengthParametersTypes);

            // Assert
            parametersOfGetInnerLength.ShouldNotBeNull();
            parametersOfGetInnerLength.Length.ShouldBe(2);
            methodGetInnerLengthParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerLength);
            var methodGetInnerLengthParametersTypes = new Type[] { typeof(Array), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetInnerLength, methodGetInnerLengthParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetInnerLengthParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerLength);
            var methodInfo = this.GetMethodInfo(MethodGetInnerLength, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInnerLength) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_GetInnerLength_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerLength);
            var methodInfo = this.GetMethodInfo(MethodGetInnerLength, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_Internally(Type[] types)
        {
            var methodCopyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopy, methodCopyParametersTypes);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopy);
            var array = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };
            object[] parametersOfCopy = { array, dimension, jagged, indices };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCopy, methodCopyParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfCopy);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopy.ShouldNotBeNull();
            parametersOfCopy.Length.ShouldBe(4);
            methodCopyParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopy);
            var array = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };
            object[] parametersOfCopy = { array, dimension, jagged, indices };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCopy, parametersOfCopy, methodCopyParametersTypes);

            // Assert
            parametersOfCopy.ShouldNotBeNull();
            parametersOfCopy.Length.ShouldBe(4);
            methodCopyParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopy);
            var methodInfo = this.GetMethodInfo(MethodCopy, 0);
            const int parametersCount = 4;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopy);
            var methodCopyParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCopy, methodCopyParametersTypes);

            // Assert
            methodCopyParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Copy) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_Copy_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopy);
            var methodInfo = this.GetMethodInfo(MethodCopy, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_Internally(Type[] types)
        {
            var methodCopyNextDimensionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopyNextDimension, methodCopyNextDimensionParametersTypes);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyNextDimension);
            var array = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyNextDimensionParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };
            object[] parametersOfCopyNextDimension = { array, dimension, jagged, indices };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCopyNextDimension, methodCopyNextDimensionParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfCopyNextDimension);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopyNextDimension.ShouldNotBeNull();
            parametersOfCopyNextDimension.Length.ShouldBe(4);
            methodCopyNextDimensionParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyNextDimension);
            var array = this.CreateType<Array>();
            var dimension = this.CreateType<int>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyNextDimensionParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };
            object[] parametersOfCopyNextDimension = { array, dimension, jagged, indices };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCopyNextDimension, parametersOfCopyNextDimension, methodCopyNextDimensionParametersTypes);

            // Assert
            parametersOfCopyNextDimension.ShouldNotBeNull();
            parametersOfCopyNextDimension.Length.ShouldBe(4);
            methodCopyNextDimensionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyNextDimension);
            var methodInfo = this.GetMethodInfo(MethodCopyNextDimension, 0);
            const int parametersCount = 4;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyNextDimension);
            var methodCopyNextDimensionParametersTypes = new Type[] { typeof(Array), typeof(int), typeof(Array), typeof(int[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCopyNextDimension, methodCopyNextDimensionParametersTypes);

            // Assert
            methodCopyNextDimensionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyNextDimension) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyNextDimension_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyNextDimension);
            var methodInfo = this.GetMethodInfo(MethodCopyNextDimension, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_Internally(Type[] types)
        {
            var methodCopyLastDimensionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopyLastDimension, methodCopyLastDimensionParametersTypes);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyLastDimension);
            var array = this.CreateType<Array>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyLastDimensionParametersTypes = new Type[] { typeof(Array), typeof(Array), typeof(int[]) };
            object[] parametersOfCopyLastDimension = { array, jagged, indices };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCopyLastDimension, methodCopyLastDimensionParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multidimensionalArrayRelayInstanceFixture, parametersOfCopyLastDimension);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopyLastDimension.ShouldNotBeNull();
            parametersOfCopyLastDimension.Length.ShouldBe(3);
            methodCopyLastDimensionParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyLastDimension);
            var array = this.CreateType<Array>();
            var jagged = this.CreateType<Array>();
            var indices = this.CreateType<int[]>();
            var methodCopyLastDimensionParametersTypes = new Type[] { typeof(Array), typeof(Array), typeof(int[]) };
            object[] parametersOfCopyLastDimension = { array, jagged, indices };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCopyLastDimension, parametersOfCopyLastDimension, methodCopyLastDimensionParametersTypes);

            // Assert
            parametersOfCopyLastDimension.ShouldNotBeNull();
            parametersOfCopyLastDimension.Length.ShouldBe(3);
            methodCopyLastDimensionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyLastDimension);
            var methodInfo = this.GetMethodInfo(MethodCopyLastDimension, 0);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyLastDimension);
            var methodCopyLastDimensionParametersTypes = new Type[] { typeof(Array), typeof(Array), typeof(int[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCopyLastDimension, methodCopyLastDimensionParametersTypes);

            // Assert
            methodCopyLastDimensionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyLastDimension) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultidimensionalArrayRelay_CopyLastDimension_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyLastDimension);
            var methodInfo = this.GetMethodInfo(MethodCopyLastDimension, 0);

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
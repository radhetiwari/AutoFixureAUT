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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MultipleToEnumerableRelay" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MultipleToEnumerableRelayTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MultipleToEnumerableRelay" />)
        /// </summary>
        public MultipleToEnumerableRelayTest() : base(typeof(MultipleToEnumerableRelay))
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

        #region General Initializer : Class (MultipleToEnumerableRelay) Initializer

        #region General Initializer : Class (MultipleToEnumerableRelay) One time setup

        private Type _multipleToEnumerableRelayInstanceType;
        private MultipleToEnumerableRelay _multipleToEnumerableRelayInstance;
        private MultipleToEnumerableRelay _multipleToEnumerableRelayInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MultipleToEnumerableRelay" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _multipleToEnumerableRelayInstanceType = typeof(MultipleToEnumerableRelay);
            _multipleToEnumerableRelayInstanceFixture = this.Create<MultipleToEnumerableRelay>(true);
            _multipleToEnumerableRelayInstance = _multipleToEnumerableRelayInstanceFixture ?? this.Create<MultipleToEnumerableRelay>(false);
            CurrentInstance = _multipleToEnumerableRelayInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodGetInnerRequest = "GetInnerRequest";

        #endregion

        #endregion

        #region General Initializer : Class (MultipleToEnumerableRelay) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MultipleToEnumerableRelay" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MultipleToEnumerableRelay_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MultipleToEnumerableRelay)

        #region General Initializer : Class (MultipleToEnumerableRelay) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MultipleToEnumerableRelay" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodGetInnerRequest, 0)]
        public void AUT_MultipleToEnumerableRelay_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MultipleToEnumerableRelay) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MultipleToEnumerableRelay" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MultipleToEnumerableRelay_Is_Instance_Present_Test()
        {
            // Assert
            _multipleToEnumerableRelayInstanceType.ShouldNotBeNull();
            _multipleToEnumerableRelayInstance.ShouldNotBeNull();
            _multipleToEnumerableRelayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MultipleToEnumerableRelay) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MultipleToEnumerableRelay" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MultipleToEnumerableRelay_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _multipleToEnumerableRelayInstance.ShouldBeAssignableTo<MultipleToEnumerableRelay>();
            _multipleToEnumerableRelayInstanceFixture.ShouldBeAssignableTo<MultipleToEnumerableRelay>();
            CurrentInstance.ShouldBeAssignableTo<MultipleToEnumerableRelay>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MultipleToEnumerableRelay) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MultipleToEnumerableRelay_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MultipleToEnumerableRelay instance = null;

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
        private void AUT_MultipleToEnumerableRelay_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _multipleToEnumerableRelayInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _multipleToEnumerableRelayInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_multipleToEnumerableRelayInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_multipleToEnumerableRelayInstanceFixture, parametersOfCreate);

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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_MultipleToEnumerableRelay_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetInnerRequest) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetInnerRequestParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetInnerRequest, methodGetInnerRequestParametersTypes);
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var multipleRequest = this.CreateType<MultipleRequest>();
            var methodGetInnerRequestParametersTypes = new Type[] { typeof(MultipleRequest) };
            object[] parametersOfGetInnerRequest = { multipleRequest };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetInnerRequest, methodGetInnerRequestParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_multipleToEnumerableRelayInstanceFixture, parametersOfGetInnerRequest);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetInnerRequest.ShouldNotBeNull();
            parametersOfGetInnerRequest.Length.ShouldBe(1);
            methodGetInnerRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var multipleRequest = this.CreateType<MultipleRequest>();
            var methodGetInnerRequestParametersTypes = new Type[] { typeof(MultipleRequest) };
            object[] parametersOfGetInnerRequest = { multipleRequest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetInnerRequest, parametersOfGetInnerRequest, methodGetInnerRequestParametersTypes);

            // Assert
            parametersOfGetInnerRequest.ShouldNotBeNull();
            parametersOfGetInnerRequest.Length.ShouldBe(1);
            methodGetInnerRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var methodGetInnerRequestParametersTypes = new Type[] { typeof(MultipleRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetInnerRequest, methodGetInnerRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetInnerRequestParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var methodGetInnerRequestParametersTypes = new Type[] { typeof(MultipleRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetInnerRequest, methodGetInnerRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetInnerRequestParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var methodInfo = this.GetMethodInfo(MethodGetInnerRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInnerRequest) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MultipleToEnumerableRelay_GetInnerRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInnerRequest);
            var methodInfo = this.GetMethodInfo(MethodGetInnerRequest, 0);
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
namespace AutoFixture.Kernel
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
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.Kernel;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.FiniteSequenceRequest" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FiniteSequenceRequestTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FiniteSequenceRequest" />)
        /// </summary>
        public FiniteSequenceRequestTest() : base(typeof(FiniteSequenceRequest))
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

        #region General Initializer : Class (FiniteSequenceRequest) Initializer

        #region General Initializer : Class (FiniteSequenceRequest) One time setup

        private Type _finiteSequenceRequestInstanceType;
        private FiniteSequenceRequest _finiteSequenceRequestInstance;
        private FiniteSequenceRequest _finiteSequenceRequestInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="FiniteSequenceRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _finiteSequenceRequestInstanceType = typeof(FiniteSequenceRequest);
            _finiteSequenceRequestInstanceFixture = this.Create<FiniteSequenceRequest>(true);
            _finiteSequenceRequestInstance = _finiteSequenceRequestInstanceFixture ?? this.Create<FiniteSequenceRequest>(false);
            CurrentInstance = _finiteSequenceRequestInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";
        private const string MethodCreateRequests = "CreateRequests";

        #endregion

        #region Fields

        private const string Fieldrequest = "request";
        private const string Fieldcount = "count";

        #endregion

        #endregion

        #region General Initializer : Class (FiniteSequenceRequest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FiniteSequenceRequest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FiniteSequenceRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FiniteSequenceRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FiniteSequenceRequest)

        #region General Initializer : Class (FiniteSequenceRequest) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        [TestCase(MethodCreateRequests, 0)]
        [TestCase(MethodEquals, 1)]
        public void AUT_FiniteSequenceRequest_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FiniteSequenceRequest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldrequest)]
        [TestCase(Fieldcount)]
        public void AUT_FiniteSequenceRequest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FiniteSequenceRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FiniteSequenceRequest_Is_Instance_Present_Test()
        {
            // Assert
            _finiteSequenceRequestInstanceType.ShouldNotBeNull();
            _finiteSequenceRequestInstance.ShouldNotBeNull();
            _finiteSequenceRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FiniteSequenceRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FiniteSequenceRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FiniteSequenceRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _finiteSequenceRequestInstance.ShouldBeAssignableTo<FiniteSequenceRequest>();
            _finiteSequenceRequestInstanceFixture.ShouldBeAssignableTo<FiniteSequenceRequest>();
            CurrentInstance.ShouldBeAssignableTo<FiniteSequenceRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FiniteSequenceRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FiniteSequenceRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var count = this.CreateType<int>();
            FiniteSequenceRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FiniteSequenceRequest(request, count);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _finiteSequenceRequestInstance.ShouldNotBeNull();
            _finiteSequenceRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FiniteSequenceRequest>();
        }

        #endregion

        #region General Constructor : Class (FiniteSequenceRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FiniteSequenceRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var request = this.CreateType<object>();
            var count = this.CreateType<int>();
            FiniteSequenceRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FiniteSequenceRequest(request, count);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _finiteSequenceRequestInstance.ShouldNotBeNull();
            _finiteSequenceRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FiniteSequenceRequest_Equals_Method_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();

            // Act
            Action executeAction = () => _finiteSequenceRequestInstance.Equals(obj);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_finiteSequenceRequestInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_finiteSequenceRequestInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_finiteSequenceRequestInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);

            // Act
            Action executeAction = () => _finiteSequenceRequestInstance.GetHashCode();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_finiteSequenceRequestInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_finiteSequenceRequestInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_finiteSequenceRequestInstanceFixture, parametersOfGetHashCode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_Internally(Type[] types)
        {
            var methodCreateRequestsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRequests, methodCreateRequestsParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);

            // Act
            Action executeAction = () => _finiteSequenceRequestInstance.CreateRequests();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            var returnedValue = default(IEnumerable<object>);

            // Act
            Action executeAction = () => returnedValue = _finiteSequenceRequestInstance.CreateRequests();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            Type [] methodCreateRequestsParametersTypes = null;
            object[] parametersOfCreateRequests = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreateRequests, methodCreateRequestsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<object>>(_finiteSequenceRequestInstanceFixture, out exception1, parametersOfCreateRequests);
            var result2 = this.GetResultOfMethod<IEnumerable<object>>(MethodCreateRequests, parametersOfCreateRequests, methodCreateRequestsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateRequests.ShouldBeNull();
            methodCreateRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            Type [] methodCreateRequestsParametersTypes = null;
            object[] parametersOfCreateRequests = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateRequests, methodCreateRequestsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_finiteSequenceRequestInstanceFixture, parametersOfCreateRequests);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRequests.ShouldBeNull();
            methodCreateRequestsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            Type [] methodCreateRequestsParametersTypes = null;
            object[] parametersOfCreateRequests = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<object>>(MethodCreateRequests, parametersOfCreateRequests, methodCreateRequestsParametersTypes);

            // Assert
            parametersOfCreateRequests.ShouldBeNull();
            methodCreateRequestsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            Type [] methodCreateRequestsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRequests, methodCreateRequestsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            Type [] methodCreateRequestsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRequests, methodCreateRequestsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRequests) (Return Type : IEnumerable<object>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_CreateRequests_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequests);
            var methodInfo = this.GetMethodInfo(MethodCreateRequests, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FiniteSequenceRequest_Equals_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<FiniteSequenceRequest>();

            // Act
            Action executeAction = () => _finiteSequenceRequestInstance.Equals(other);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<FiniteSequenceRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };
            object[] parametersOfEquals = { other };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_finiteSequenceRequestInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<FiniteSequenceRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };
            object[] parametersOfEquals = { other };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_finiteSequenceRequestInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<FiniteSequenceRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };
            object[] parametersOfEquals = { other };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_finiteSequenceRequestInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<FiniteSequenceRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };
            object[] parametersOfEquals = { other };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(FiniteSequenceRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FiniteSequenceRequest_Equals_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);
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
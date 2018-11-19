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
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.RequestMemberTypeResolver" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RequestMemberTypeResolverTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RequestMemberTypeResolver" />)
        /// </summary>
        public RequestMemberTypeResolverTest() : base(typeof(RequestMemberTypeResolver))
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

        #region General Initializer : Class (RequestMemberTypeResolver) Initializer

        #region General Initializer : Class (RequestMemberTypeResolver) One time setup

        private Type _requestMemberTypeResolverInstanceType;
        private RequestMemberTypeResolver _requestMemberTypeResolverInstance;
        private RequestMemberTypeResolver _requestMemberTypeResolverInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RequestMemberTypeResolver" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _requestMemberTypeResolverInstanceType = typeof(RequestMemberTypeResolver);
            _requestMemberTypeResolverInstanceFixture = this.Create<RequestMemberTypeResolver>(true);
            _requestMemberTypeResolverInstance = _requestMemberTypeResolverInstanceFixture ?? this.Create<RequestMemberTypeResolver>(false);
            CurrentInstance = _requestMemberTypeResolverInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodTryGetMemberType = "TryGetMemberType";

        #endregion

        #endregion

        #region General Initializer : Class (RequestMemberTypeResolver) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RequestMemberTypeResolver" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RequestMemberTypeResolver_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RequestMemberTypeResolver)

        #region General Initializer : Class (RequestMemberTypeResolver) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RequestMemberTypeResolver" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTryGetMemberType, 0)]
        public void AUT_RequestMemberTypeResolver_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (RequestMemberTypeResolver) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RequestMemberTypeResolver" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestMemberTypeResolver_Is_Instance_Present_Test()
        {
            // Assert
            _requestMemberTypeResolverInstanceType.ShouldNotBeNull();
            _requestMemberTypeResolverInstance.ShouldNotBeNull();
            _requestMemberTypeResolverInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RequestMemberTypeResolver) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RequestMemberTypeResolver" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestMemberTypeResolver_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _requestMemberTypeResolverInstance.ShouldBeAssignableTo<RequestMemberTypeResolver>();
            _requestMemberTypeResolverInstanceFixture.ShouldBeAssignableTo<RequestMemberTypeResolver>();
            CurrentInstance.ShouldBeAssignableTo<RequestMemberTypeResolver>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RequestMemberTypeResolver) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RequestMemberTypeResolver_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RequestMemberTypeResolver instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (TryGetMemberType) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Internally(Type[] types)
        {
            var methodTryGetMemberTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var request = this.CreateType<object>();
            var memberType = this.CreateType<Type>();

            // Act
            Action executeAction = () => _requestMemberTypeResolverInstance.TryGetMemberType(request, out memberType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var request = this.CreateType<object>();
            var memberType = this.CreateType<Type>();
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfTryGetMemberType = { request, memberType };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_requestMemberTypeResolverInstanceFixture, parametersOfTryGetMemberType);
            var result2 = this.GetResultOfMethod<bool>(MethodTryGetMemberType, parametersOfTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryGetMemberType.ShouldNotBeNull();
            parametersOfTryGetMemberType.Length.ShouldBe(2);
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var request = this.CreateType<object>();
            var memberType = this.CreateType<Type>();
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfTryGetMemberType = { request, memberType };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_requestMemberTypeResolverInstanceFixture, out exception1, parametersOfTryGetMemberType);
            var result2 = this.GetResultOfMethod<bool>(MethodTryGetMemberType, parametersOfTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryGetMemberType.ShouldNotBeNull();
            parametersOfTryGetMemberType.Length.ShouldBe(2);
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var request = this.CreateType<object>();
            var memberType = this.CreateType<Type>();
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfTryGetMemberType = { request, memberType };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_requestMemberTypeResolverInstanceFixture, parametersOfTryGetMemberType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryGetMemberType.ShouldNotBeNull();
            parametersOfTryGetMemberType.Length.ShouldBe(2);
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var request = this.CreateType<object>();
            var memberType = this.CreateType<Type>();
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfTryGetMemberType = { request, memberType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodTryGetMemberType, parametersOfTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            parametersOfTryGetMemberType.ShouldNotBeNull();
            parametersOfTryGetMemberType.Length.ShouldBe(2);
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var methodTryGetMemberTypeParametersTypes = new Type[] { typeof(object), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryGetMemberType, methodTryGetMemberTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryGetMemberTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var methodInfo = this.GetMethodInfo(MethodTryGetMemberType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryGetMemberType) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestMemberTypeResolver_TryGetMemberType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetMemberType);
            var methodInfo = this.GetMethodInfo(MethodTryGetMemberType, 0);
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
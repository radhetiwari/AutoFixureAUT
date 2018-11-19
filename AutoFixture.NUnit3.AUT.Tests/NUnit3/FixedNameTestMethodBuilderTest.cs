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
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using NUnit.Framework.Internal.Builders;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.NUnit3;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.FixedNameTestMethodBuilder" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FixedNameTestMethodBuilderTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FixedNameTestMethodBuilder" />)
        /// </summary>
        public FixedNameTestMethodBuilderTest() : base(typeof(FixedNameTestMethodBuilder))
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

        #region General Initializer : Class (FixedNameTestMethodBuilder) Initializer

        #region General Initializer : Class (FixedNameTestMethodBuilder) One time setup

        private Type _fixedNameTestMethodBuilderInstanceType;
        private FixedNameTestMethodBuilder _fixedNameTestMethodBuilderInstance;
        private FixedNameTestMethodBuilder _fixedNameTestMethodBuilderInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="FixedNameTestMethodBuilder" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fixedNameTestMethodBuilderInstanceType = typeof(FixedNameTestMethodBuilder);
            _fixedNameTestMethodBuilderInstanceFixture = this.Create<FixedNameTestMethodBuilder>(true);
            _fixedNameTestMethodBuilderInstance = _fixedNameTestMethodBuilderInstanceFixture ?? this.Create<FixedNameTestMethodBuilder>(false);
            CurrentInstance = _fixedNameTestMethodBuilderInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodBuild = "Build";
        private const string MethodGetParametersForMethod = "GetParametersForMethod";
        private const string MethodEnsureOriginalArgumentsArrayIsNotShared = "EnsureOriginalArgumentsArrayIsNotShared";

        #endregion

        #endregion

        #region General Initializer : Class (FixedNameTestMethodBuilder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FixedNameTestMethodBuilder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FixedNameTestMethodBuilder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FixedNameTestMethodBuilder)

        #region General Initializer : Class (FixedNameTestMethodBuilder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FixedNameTestMethodBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodBuild, 0)]
        [TestCase(MethodGetParametersForMethod, 0)]
        [TestCase(MethodGetParametersForMethod, 1)]
        [TestCase(MethodEnsureOriginalArgumentsArrayIsNotShared, 0)]
        public void AUT_FixedNameTestMethodBuilder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FixedNameTestMethodBuilder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FixedNameTestMethodBuilder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FixedNameTestMethodBuilder_Is_Instance_Present_Test()
        {
            // Assert
            _fixedNameTestMethodBuilderInstanceType.ShouldNotBeNull();
            _fixedNameTestMethodBuilderInstance.ShouldNotBeNull();
            _fixedNameTestMethodBuilderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FixedNameTestMethodBuilder) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FixedNameTestMethodBuilder" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FixedNameTestMethodBuilder_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _fixedNameTestMethodBuilderInstance.ShouldBeAssignableTo<FixedNameTestMethodBuilder>();
            _fixedNameTestMethodBuilderInstanceFixture.ShouldBeAssignableTo<FixedNameTestMethodBuilder>();
            CurrentInstance.ShouldBeAssignableTo<FixedNameTestMethodBuilder>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FixedNameTestMethodBuilder) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FixedNameTestMethodBuilder_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FixedNameTestMethodBuilder instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Build) (Return Type : TestMethod) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FixedNameTestMethodBuilder_Build_Method_Call_Internally(Type[] types)
        {
            var methodBuildParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuild, methodBuildParametersTypes);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();

            // Act
            Action executeAction = () => _fixedNameTestMethodBuilderInstance.Build(method, suite, parameterValues, autoDataStartIndex);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var returnedValue = default(TestMethod);

            // Act
            Action executeAction = () => returnedValue = _fixedNameTestMethodBuilderInstance.Build(method, suite, parameterValues, autoDataStartIndex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodBuildParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfBuild = { method, suite, parameterValues, autoDataStartIndex };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodBuild, methodBuildParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<TestMethod>(_fixedNameTestMethodBuilderInstanceFixture, out exception1, parametersOfBuild);
            var result2 = this.GetResultOfMethod<TestMethod>(MethodBuild, parametersOfBuild, methodBuildParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuild.ShouldNotBeNull();
            parametersOfBuild.Length.ShouldBe(4);
            methodBuildParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodBuildParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfBuild = { method, suite, parameterValues, autoDataStartIndex };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodBuild, methodBuildParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixedNameTestMethodBuilderInstanceFixture, parametersOfBuild);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuild.ShouldNotBeNull();
            parametersOfBuild.Length.ShouldBe(4);
            methodBuildParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var method = this.CreateType<IMethodInfo>();
            var suite = this.CreateType<Test>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodBuildParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfBuild = { method, suite, parameterValues, autoDataStartIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TestMethod>(MethodBuild, parametersOfBuild, methodBuildParametersTypes);

            // Assert
            parametersOfBuild.ShouldNotBeNull();
            parametersOfBuild.Length.ShouldBe(4);
            methodBuildParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var methodBuildParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test), typeof(IEnumerable<object>), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBuild, methodBuildParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBuildParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var methodBuildParametersTypes = new Type[] { typeof(IMethodInfo), typeof(Test), typeof(IEnumerable<object>), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuild, methodBuildParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var methodInfo = this.GetMethodInfo(MethodBuild, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Build) (Return Type : TestMethod) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_Build_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuild);
            var methodInfo = this.GetMethodInfo(MethodBuild, 0);
            const int parametersCount = 4;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersForMethodParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var method = this.CreateType<IMethodInfo>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfGetParametersForMethod = { method, parameterValues, autoDataStartIndex };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);
            var result2 = this.GetResultOfMethod<TestCaseParameters>(MethodGetParametersForMethod, parametersOfGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetParametersForMethod.ShouldNotBeNull();
            parametersOfGetParametersForMethod.Length.ShouldBe(3);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<TestCaseParameters>(MethodGetParametersForMethod, parametersOfGetParametersForMethod, methodGetParametersForMethodParametersTypes));
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var method = this.CreateType<IMethodInfo>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfGetParametersForMethod = { method, parameterValues, autoDataStartIndex };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixedNameTestMethodBuilderInstanceFixture, parametersOfGetParametersForMethod);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetParametersForMethod.ShouldNotBeNull();
            parametersOfGetParametersForMethod.Length.ShouldBe(3);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var method = this.CreateType<IMethodInfo>();
            var parameterValues = this.CreateType<IEnumerable<object>>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(IEnumerable<object>), typeof(int) };
            object[] parametersOfGetParametersForMethod = { method, parameterValues, autoDataStartIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TestCaseParameters>(MethodGetParametersForMethod, parametersOfGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            parametersOfGetParametersForMethod.ShouldNotBeNull();
            parametersOfGetParametersForMethod.Length.ShouldBe(3);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(IEnumerable<object>), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(IEnumerable<object>), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, 0);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetParametersForMethodParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var method = this.CreateType<IMethodInfo>();
            var args = this.CreateType<object[]>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(object[]), typeof(int) };
            object[] parametersOfGetParametersForMethod = { method, args, autoDataStartIndex };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);
            var result2 = this.GetResultOfMethod<TestCaseParameters>(MethodGetParametersForMethod, parametersOfGetParametersForMethod, methodGetParametersForMethodParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_fixedNameTestMethodBuilderInstanceFixture, parametersOfGetParametersForMethod);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParametersForMethod.ShouldNotBeNull();
            parametersOfGetParametersForMethod.Length.ShouldBe(3);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var method = this.CreateType<IMethodInfo>();
            var args = this.CreateType<object[]>();
            var autoDataStartIndex = this.CreateType<int>();
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(object[]), typeof(int) };
            object[] parametersOfGetParametersForMethod = { method, args, autoDataStartIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TestCaseParameters>(MethodGetParametersForMethod, parametersOfGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            parametersOfGetParametersForMethod.ShouldNotBeNull();
            parametersOfGetParametersForMethod.Length.ShouldBe(3);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(object[]), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodGetParametersForMethodParametersTypes = new Type[] { typeof(IMethodInfo), typeof(object[]), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParametersForMethod, methodGetParametersForMethodParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersForMethodParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParametersForMethod) (Return Type : TestCaseParameters) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_GetParametersForMethod_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersForMethod);
            var methodInfo = this.GetMethodInfo(MethodGetParametersForMethod, 1);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_Internally(Type[] types)
        {
            var methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEnsureOriginalArgumentsArrayIsNotShared, methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnsureOriginalArgumentsArrayIsNotShared);
            var parameters = this.CreateType<TestCaseParameters>();
            var methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes = new Type[] { typeof(TestCaseParameters) };
            object[] parametersOfEnsureOriginalArgumentsArrayIsNotShared = { parameters };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEnsureOriginalArgumentsArrayIsNotShared, methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_fixedNameTestMethodBuilderInstanceFixture, parametersOfEnsureOriginalArgumentsArrayIsNotShared);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEnsureOriginalArgumentsArrayIsNotShared.ShouldNotBeNull();
            parametersOfEnsureOriginalArgumentsArrayIsNotShared.Length.ShouldBe(1);
            methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnsureOriginalArgumentsArrayIsNotShared);
            var parameters = this.CreateType<TestCaseParameters>();
            var methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes = new Type[] { typeof(TestCaseParameters) };
            object[] parametersOfEnsureOriginalArgumentsArrayIsNotShared = { parameters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEnsureOriginalArgumentsArrayIsNotShared, parametersOfEnsureOriginalArgumentsArrayIsNotShared, methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes);

            // Assert
            parametersOfEnsureOriginalArgumentsArrayIsNotShared.ShouldNotBeNull();
            parametersOfEnsureOriginalArgumentsArrayIsNotShared.Length.ShouldBe(1);
            methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnsureOriginalArgumentsArrayIsNotShared);
            var methodInfo = this.GetMethodInfo(MethodEnsureOriginalArgumentsArrayIsNotShared, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnsureOriginalArgumentsArrayIsNotShared);
            var methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes = new Type[] { typeof(TestCaseParameters) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEnsureOriginalArgumentsArrayIsNotShared, methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes);

            // Assert
            methodEnsureOriginalArgumentsArrayIsNotSharedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnsureOriginalArgumentsArrayIsNotShared) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FixedNameTestMethodBuilder_EnsureOriginalArgumentsArrayIsNotShared_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnsureOriginalArgumentsArrayIsNotShared);
            var methodInfo = this.GetMethodInfo(MethodEnsureOriginalArgumentsArrayIsNotShared, 0);

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
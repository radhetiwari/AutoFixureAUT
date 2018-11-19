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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.ModestConstructorQuery" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModestConstructorQueryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModestConstructorQuery" />)
        /// </summary>
        public ModestConstructorQueryTest() : base(typeof(ModestConstructorQuery))
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

        #region General Initializer : Class (ModestConstructorQuery) Initializer

        #region General Initializer : Class (ModestConstructorQuery) One time setup

        private Type _modestConstructorQueryInstanceType;
        private ModestConstructorQuery _modestConstructorQueryInstance;
        private ModestConstructorQuery _modestConstructorQueryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ModestConstructorQuery" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modestConstructorQueryInstanceType = typeof(ModestConstructorQuery);
            _modestConstructorQueryInstanceFixture = this.Create<ModestConstructorQuery>(true);
            _modestConstructorQueryInstance = _modestConstructorQueryInstanceFixture ?? this.Create<ModestConstructorQuery>(false);
            CurrentInstance = _modestConstructorQueryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodSelectMethods = "SelectMethods";

        #endregion

        #endregion

        #region General Initializer : Class (ModestConstructorQuery) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModestConstructorQuery" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ModestConstructorQuery_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModestConstructorQuery)

        #region General Initializer : Class (ModestConstructorQuery) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ModestConstructorQuery" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSelectMethods, 0)]
        public void AUT_ModestConstructorQuery_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ModestConstructorQuery) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ModestConstructorQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModestConstructorQuery_Is_Instance_Present_Test()
        {
            // Assert
            _modestConstructorQueryInstanceType.ShouldNotBeNull();
            _modestConstructorQueryInstance.ShouldNotBeNull();
            _modestConstructorQueryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ModestConstructorQuery) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ModestConstructorQuery" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModestConstructorQuery_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modestConstructorQueryInstance.ShouldBeAssignableTo<ModestConstructorQuery>();
            _modestConstructorQueryInstanceFixture.ShouldBeAssignableTo<ModestConstructorQuery>();
            CurrentInstance.ShouldBeAssignableTo<ModestConstructorQuery>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ModestConstructorQuery) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ModestConstructorQuery_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ModestConstructorQuery instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModestConstructorQuery_SelectMethods_Method_Call_Internally(Type[] types)
        {
            var methodSelectMethodsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _modestConstructorQueryInstance.SelectMethods(type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var returnedValue = default(IEnumerable<IMethod>);

            // Act
            Action executeAction = () => returnedValue = _modestConstructorQueryInstance.SelectMethods(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<IMethod>>(_modestConstructorQueryInstanceFixture, out exception1, parametersOfSelectMethods);
            var result2 = this.GetResultOfMethod<IEnumerable<IMethod>>(MethodSelectMethods, parametersOfSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_modestConstructorQueryInstanceFixture, parametersOfSelectMethods);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<IMethod>>(MethodSelectMethods, parametersOfSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSelectMethodsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModestConstructorQuery_SelectMethods_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, 0);
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
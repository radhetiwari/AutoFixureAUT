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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.ArrayFavoringConstructorQuery" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ArrayFavoringConstructorQueryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ArrayFavoringConstructorQuery" />)
        /// </summary>
        public ArrayFavoringConstructorQueryTest() : base(typeof(ArrayFavoringConstructorQuery))
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

        #region General Initializer : Class (ArrayFavoringConstructorQuery) Initializer

        #region General Initializer : Class (ArrayFavoringConstructorQuery) One time setup

        private Type _arrayFavoringConstructorQueryInstanceType;
        private ArrayFavoringConstructorQuery _arrayFavoringConstructorQueryInstance;
        private ArrayFavoringConstructorQuery _arrayFavoringConstructorQueryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ArrayFavoringConstructorQuery" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _arrayFavoringConstructorQueryInstanceType = typeof(ArrayFavoringConstructorQuery);
            _arrayFavoringConstructorQueryInstanceFixture = this.Create<ArrayFavoringConstructorQuery>(true);
            _arrayFavoringConstructorQueryInstance = _arrayFavoringConstructorQueryInstanceFixture ?? this.Create<ArrayFavoringConstructorQuery>(false);
            CurrentInstance = _arrayFavoringConstructorQueryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodSelectMethods = "SelectMethods";

        #endregion

        #endregion

        #region General Initializer : Class (ArrayFavoringConstructorQuery) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ArrayFavoringConstructorQuery" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ArrayFavoringConstructorQuery_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ArrayFavoringConstructorQuery)

        #region General Initializer : Class (ArrayFavoringConstructorQuery) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ArrayFavoringConstructorQuery" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSelectMethods, 0)]
        public void AUT_ArrayFavoringConstructorQuery_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ArrayFavoringConstructorQuery) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ArrayFavoringConstructorQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ArrayFavoringConstructorQuery_Is_Instance_Present_Test()
        {
            // Assert
            _arrayFavoringConstructorQueryInstanceType.ShouldNotBeNull();
            _arrayFavoringConstructorQueryInstance.ShouldNotBeNull();
            _arrayFavoringConstructorQueryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ArrayFavoringConstructorQuery) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ArrayFavoringConstructorQuery" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ArrayFavoringConstructorQuery_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _arrayFavoringConstructorQueryInstance.ShouldBeAssignableTo<ArrayFavoringConstructorQuery>();
            _arrayFavoringConstructorQueryInstanceFixture.ShouldBeAssignableTo<ArrayFavoringConstructorQuery>();
            CurrentInstance.ShouldBeAssignableTo<ArrayFavoringConstructorQuery>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ArrayFavoringConstructorQuery) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ArrayFavoringConstructorQuery_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ArrayFavoringConstructorQuery instance = null;

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
        private void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_Internally(Type[] types)
        {
            var methodSelectMethodsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _arrayFavoringConstructorQueryInstance.SelectMethods(type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var returnedValue = default(IEnumerable<IMethod>);

            // Act
            Action executeAction = () => returnedValue = _arrayFavoringConstructorQueryInstance.SelectMethods(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<IMethod>>(_arrayFavoringConstructorQueryInstanceFixture, out exception1, parametersOfSelectMethods);
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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_arrayFavoringConstructorQueryInstanceFixture, parametersOfSelectMethods);

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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_ArrayFavoringConstructorQuery_SelectMethods_Method_Call_Parameters_Count_Verification_Test()
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
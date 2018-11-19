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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.TypeArgumentsCannotBeInferredException" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TypeArgumentsCannotBeInferredExceptionTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TypeArgumentsCannotBeInferredException" />)
        /// </summary>
        public TypeArgumentsCannotBeInferredExceptionTest() : base(typeof(TypeArgumentsCannotBeInferredException))
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

        #region General Initializer : Class (TypeArgumentsCannotBeInferredException) Initializer

        #region General Initializer : Class (TypeArgumentsCannotBeInferredException) One time setup

        private Type _typeArgumentsCannotBeInferredExceptionInstanceType;
        private TypeArgumentsCannotBeInferredException _typeArgumentsCannotBeInferredExceptionInstance;
        private TypeArgumentsCannotBeInferredException _typeArgumentsCannotBeInferredExceptionInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="TypeArgumentsCannotBeInferredException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _typeArgumentsCannotBeInferredExceptionInstanceType = typeof(TypeArgumentsCannotBeInferredException);
            _typeArgumentsCannotBeInferredExceptionInstanceFixture = this.Create<TypeArgumentsCannotBeInferredException>(true);
            _typeArgumentsCannotBeInferredExceptionInstance = _typeArgumentsCannotBeInferredExceptionInstanceFixture ?? this.Create<TypeArgumentsCannotBeInferredException>(false);
            CurrentInstance = _typeArgumentsCannotBeInferredExceptionInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodGetFriendlyName = "GetFriendlyName";

        #endregion

        #endregion

        #region General Initializer : Class (TypeArgumentsCannotBeInferredException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TypeArgumentsCannotBeInferredException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TypeArgumentsCannotBeInferredException)

        #region General Initializer : Class (TypeArgumentsCannotBeInferredException) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetFriendlyName, 0)]
        public void AUT_TypeArgumentsCannotBeInferredException_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TypeArgumentsCannotBeInferredException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TypeArgumentsCannotBeInferredException_Is_Instance_Present_Test()
        {
            // Assert
            _typeArgumentsCannotBeInferredExceptionInstanceType.ShouldNotBeNull();
            _typeArgumentsCannotBeInferredExceptionInstance.ShouldNotBeNull();
            _typeArgumentsCannotBeInferredExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TypeArgumentsCannotBeInferredException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TypeArgumentsCannotBeInferredException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _typeArgumentsCannotBeInferredExceptionInstance.ShouldBeAssignableTo<TypeArgumentsCannotBeInferredException>();
            _typeArgumentsCannotBeInferredExceptionInstanceFixture.ShouldBeAssignableTo<TypeArgumentsCannotBeInferredException>();
            CurrentInstance.ShouldBeAssignableTo<TypeArgumentsCannotBeInferredException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TypeArgumentsCannotBeInferredException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) instance created

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Is_Created_Test()
        {
            // Assert
            _typeArgumentsCannotBeInferredExceptionInstance.ShouldNotBeNull();
            _typeArgumentsCannotBeInferredExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TypeArgumentsCannotBeInferredException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void AUT_TypeArgumentsCannotBeInferredException_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TypeArgumentsCannotBeInferredException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TypeArgumentsCannotBeInferredException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodTypeArgumentsCannotBeInferredExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTypeArgumentsCannotBeInferredExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TypeArgumentsCannotBeInferredException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTypeArgumentsCannotBeInferredExceptionParametersTypes = new Type[] { typeof(MethodInfo) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTypeArgumentsCannotBeInferredExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TypeArgumentsCannotBeInferredException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTypeArgumentsCannotBeInferredExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTypeArgumentsCannotBeInferredExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TypeArgumentsCannotBeInferredException) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TypeArgumentsCannotBeInferredException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TypeArgumentsCannotBeInferredException_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTypeArgumentsCannotBeInferredExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTypeArgumentsCannotBeInferredExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetFriendlyName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFriendlyNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFriendlyName, methodGetFriendlyNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var type = this.CreateType<Type>();
            var methodGetFriendlyNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetFriendlyName = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetFriendlyName, methodGetFriendlyNameParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_typeArgumentsCannotBeInferredExceptionInstanceFixture, parametersOfGetFriendlyName);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFriendlyName.ShouldNotBeNull();
            parametersOfGetFriendlyName.Length.ShouldBe(1);
            methodGetFriendlyNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var type = this.CreateType<Type>();
            var methodGetFriendlyNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetFriendlyName = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetFriendlyName, parametersOfGetFriendlyName, methodGetFriendlyNameParametersTypes);

            // Assert
            parametersOfGetFriendlyName.ShouldNotBeNull();
            parametersOfGetFriendlyName.Length.ShouldBe(1);
            methodGetFriendlyNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var methodGetFriendlyNameParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFriendlyName, methodGetFriendlyNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFriendlyNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var methodGetFriendlyNameParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFriendlyName, methodGetFriendlyNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFriendlyNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var methodInfo = this.GetMethodInfo(MethodGetFriendlyName, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFriendlyName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TypeArgumentsCannotBeInferredException_GetFriendlyName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyName);
            var methodInfo = this.GetMethodInfo(MethodGetFriendlyName, 0);
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
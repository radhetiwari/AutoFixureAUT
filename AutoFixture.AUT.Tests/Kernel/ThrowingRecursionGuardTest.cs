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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.ThrowingRecursionGuard" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ThrowingRecursionGuardTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ThrowingRecursionGuard" />)
        /// </summary>
        public ThrowingRecursionGuardTest() : base(typeof(ThrowingRecursionGuard))
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

        #region General Initializer : Class (ThrowingRecursionGuard) Initializer

        #region General Initializer : Class (ThrowingRecursionGuard) One time setup

        private Type _throwingRecursionGuardInstanceType;
        private ThrowingRecursionGuard _throwingRecursionGuardInstance;
        private ThrowingRecursionGuard _throwingRecursionGuardInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ThrowingRecursionGuard" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _throwingRecursionGuardInstanceType = typeof(ThrowingRecursionGuard);
            _throwingRecursionGuardInstanceFixture = this.Create<ThrowingRecursionGuard>(true);
            _throwingRecursionGuardInstance = _throwingRecursionGuardInstanceFixture ?? this.Create<ThrowingRecursionGuard>(false);
            CurrentInstance = _throwingRecursionGuardInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodHandleRecursiveRequest = "HandleRecursiveRequest";
        private const string MethodCompose = "Compose";

        #endregion

        #endregion

        #region General Initializer : Class (ThrowingRecursionGuard) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ThrowingRecursionGuard_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ThrowingRecursionGuard) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ThrowingRecursionGuard_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ThrowingRecursionGuard) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ThrowingRecursionGuard_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ThrowingRecursionGuard)

        #region General Initializer : Class (ThrowingRecursionGuard) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCompose, 0)]
        public void AUT_ThrowingRecursionGuard_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ThrowingRecursionGuard) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThrowingRecursionGuard_Is_Instance_Present_Test()
        {
            // Assert
            _throwingRecursionGuardInstanceType.ShouldNotBeNull();
            _throwingRecursionGuardInstance.ShouldNotBeNull();
            _throwingRecursionGuardInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ThrowingRecursionGuard) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThrowingRecursionGuard_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _throwingRecursionGuardInstance.ShouldBeAssignableTo<ThrowingRecursionGuard>();
            _throwingRecursionGuardInstanceFixture.ShouldBeAssignableTo<ThrowingRecursionGuard>();
            CurrentInstance.ShouldBeAssignableTo<ThrowingRecursionGuard>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ThrowingRecursionGuard) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            var comparer = this.CreateType<IEqualityComparer>();
            ThrowingRecursionGuard instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ThrowingRecursionGuard(builder, comparer);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _throwingRecursionGuardInstance.ShouldNotBeNull();
            _throwingRecursionGuardInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ThrowingRecursionGuard>();
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            var comparer = this.CreateType<IEqualityComparer>();
            ThrowingRecursionGuard instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ThrowingRecursionGuard(builder, comparer);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _throwingRecursionGuardInstance.ShouldNotBeNull();
            _throwingRecursionGuardInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) instance created

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_Is_Created_Test()
        {
            // Assert
            _throwingRecursionGuardInstance.ShouldNotBeNull();
            _throwingRecursionGuardInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionGuard" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ThrowingRecursionGuard_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ThrowingRecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ThrowingRecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodThrowingRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IEqualityComparer) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodThrowingRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ThrowingRecursionGuard) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ThrowingRecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionGuard_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodThrowingRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodThrowingRecursionGuardParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThrowingRecursionGuard_Compose_Method_Call_Internally(Type[] types)
        {
            var methodComposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => _throwingRecursionGuardInstance.Compose(builders);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => _throwingRecursionGuardInstance.Compose(builders);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _throwingRecursionGuardInstance.Compose(builders);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _throwingRecursionGuardInstance.Compose(builders);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_throwingRecursionGuardInstanceFixture, parametersOfCompose);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_throwingRecursionGuardInstanceFixture, out exception1, parametersOfCompose);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_throwingRecursionGuardInstanceFixture, parametersOfCompose);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodComposeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionGuard_Compose_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 0);
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
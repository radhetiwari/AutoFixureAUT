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
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.ThrowingRecursionBehavior" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ThrowingRecursionBehaviorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ThrowingRecursionBehavior" />)
        /// </summary>
        public ThrowingRecursionBehaviorTest() : base(typeof(ThrowingRecursionBehavior))
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

        #region General Initializer : Class (ThrowingRecursionBehavior) Initializer

        #region General Initializer : Class (ThrowingRecursionBehavior) One time setup

        private Type _throwingRecursionBehaviorInstanceType;
        private ThrowingRecursionBehavior _throwingRecursionBehaviorInstance;
        private ThrowingRecursionBehavior _throwingRecursionBehaviorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ThrowingRecursionBehavior" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _throwingRecursionBehaviorInstanceType = typeof(ThrowingRecursionBehavior);
            _throwingRecursionBehaviorInstanceFixture = this.Create<ThrowingRecursionBehavior>(true);
            _throwingRecursionBehaviorInstance = _throwingRecursionBehaviorInstanceFixture ?? this.Create<ThrowingRecursionBehavior>(false);
            CurrentInstance = _throwingRecursionBehaviorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodTransform = "Transform";

        #endregion

        #endregion

        #region General Initializer : Class (ThrowingRecursionBehavior) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionBehavior" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ThrowingRecursionBehavior_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ThrowingRecursionBehavior)

        #region General Initializer : Class (ThrowingRecursionBehavior) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransform, 0)]
        public void AUT_ThrowingRecursionBehavior_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ThrowingRecursionBehavior) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionBehavior" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThrowingRecursionBehavior_Is_Instance_Present_Test()
        {
            // Assert
            _throwingRecursionBehaviorInstanceType.ShouldNotBeNull();
            _throwingRecursionBehaviorInstance.ShouldNotBeNull();
            _throwingRecursionBehaviorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ThrowingRecursionBehavior) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ThrowingRecursionBehavior" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThrowingRecursionBehavior_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _throwingRecursionBehaviorInstance.ShouldBeAssignableTo<ThrowingRecursionBehavior>();
            _throwingRecursionBehaviorInstanceFixture.ShouldBeAssignableTo<ThrowingRecursionBehavior>();
            CurrentInstance.ShouldBeAssignableTo<ThrowingRecursionBehavior>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ThrowingRecursionBehavior) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ThrowingRecursionBehavior_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ThrowingRecursionBehavior instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThrowingRecursionBehavior_Transform_Method_Call_Internally(Type[] types)
        {
            var methodTransformParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTransform, methodTransformParametersTypes);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _throwingRecursionBehaviorInstance.Transform(builder);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _throwingRecursionBehaviorInstance.Transform(builder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_throwingRecursionBehaviorInstanceFixture, out exception1, parametersOfTransform);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodTransform, parametersOfTransform, methodTransformParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTransform.ShouldNotBeNull();
            parametersOfTransform.Length.ShouldBe(1);
            methodTransformParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_throwingRecursionBehaviorInstanceFixture, parametersOfTransform);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTransform.ShouldNotBeNull();
            parametersOfTransform.Length.ShouldBe(1);
            methodTransformParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodTransform, parametersOfTransform, methodTransformParametersTypes);

            // Assert
            parametersOfTransform.ShouldNotBeNull();
            parametersOfTransform.Length.ShouldBe(1);
            methodTransformParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTransform, methodTransformParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodTransformParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTransform, methodTransformParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTransformParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var methodInfo = this.GetMethodInfo(MethodTransform, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThrowingRecursionBehavior_Transform_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var methodInfo = this.GetMethodInfo(MethodTransform, 0);
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
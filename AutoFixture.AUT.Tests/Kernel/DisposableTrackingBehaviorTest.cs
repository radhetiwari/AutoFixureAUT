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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.DisposableTrackingBehavior" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DisposableTrackingBehaviorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DisposableTrackingBehavior" />)
        /// </summary>
        public DisposableTrackingBehaviorTest() : base(typeof(DisposableTrackingBehavior))
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

        #region General Initializer : Class (DisposableTrackingBehavior) Initializer

        #region General Initializer : Class (DisposableTrackingBehavior) One time setup

        private Type _disposableTrackingBehaviorInstanceType;
        private DisposableTrackingBehavior _disposableTrackingBehaviorInstance;
        private DisposableTrackingBehavior _disposableTrackingBehaviorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="DisposableTrackingBehavior" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _disposableTrackingBehaviorInstanceType = typeof(DisposableTrackingBehavior);
            _disposableTrackingBehaviorInstanceFixture = this.Create<DisposableTrackingBehavior>(true);
            _disposableTrackingBehaviorInstance = _disposableTrackingBehaviorInstanceFixture ?? this.Create<DisposableTrackingBehavior>(false);
            CurrentInstance = _disposableTrackingBehaviorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTrackers = "Trackers";

        #endregion

        #region Methods

        private const string MethodTransform = "Transform";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Fieldtrackers = "trackers";

        #endregion

        #endregion

        #region General Initializer : Class (DisposableTrackingBehavior) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingBehavior_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DisposableTrackingBehavior) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingBehavior_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DisposableTrackingBehavior) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingBehavior_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DisposableTrackingBehavior)

        #region General Initializer : Class (DisposableTrackingBehavior) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransform, 0)]
        public void AUT_DisposableTrackingBehavior_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DisposableTrackingBehavior) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTrackers)]
        public void AUT_DisposableTrackingBehavior_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (DisposableTrackingBehavior) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldtrackers)]
        public void AUT_DisposableTrackingBehavior_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DisposableTrackingBehavior) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DisposableTrackingBehavior_Is_Instance_Present_Test()
        {
            // Assert
            _disposableTrackingBehaviorInstanceType.ShouldNotBeNull();
            _disposableTrackingBehaviorInstance.ShouldNotBeNull();
            _disposableTrackingBehaviorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DisposableTrackingBehavior) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DisposableTrackingBehavior" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DisposableTrackingBehavior_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _disposableTrackingBehaviorInstance.ShouldBeAssignableTo<DisposableTrackingBehavior>();
            _disposableTrackingBehaviorInstanceFixture.ShouldBeAssignableTo<DisposableTrackingBehavior>();
            CurrentInstance.ShouldBeAssignableTo<DisposableTrackingBehavior>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DisposableTrackingBehavior) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DisposableTrackingBehavior_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DisposableTrackingBehavior instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DisposableTrackingBehavior) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTrackers)]
        public void AUT_DisposableTrackingBehavior_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (DisposableTrackingBehavior) => Property (Trackers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DisposableTrackingBehavior_Public_Class_Trackers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTrackers);
            var propertyInfo = this.GetPropertyInfo(PropertyTrackers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingBehavior_Transform_Method_Call_Internally(Type[] types)
        {
            var methodTransformParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTransform, methodTransformParametersTypes);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingBehavior_Transform_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _disposableTrackingBehaviorInstance.Transform(builder);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingBehavior_Transform_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _disposableTrackingBehaviorInstance.Transform(builder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_disposableTrackingBehaviorInstanceFixture, out exception1, parametersOfTransform);
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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_disposableTrackingBehaviorInstanceFixture, parametersOfTransform);

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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DisposableTrackingBehavior_Transform_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingBehavior_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingBehavior_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}
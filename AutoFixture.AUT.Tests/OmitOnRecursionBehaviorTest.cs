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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.OmitOnRecursionBehavior" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OmitOnRecursionBehaviorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OmitOnRecursionBehavior" />)
        /// </summary>
        public OmitOnRecursionBehaviorTest() : base(typeof(OmitOnRecursionBehavior))
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

        #region General Initializer : Class (OmitOnRecursionBehavior) Initializer

        #region General Initializer : Class (OmitOnRecursionBehavior) One time setup

        private Type _omitOnRecursionBehaviorInstanceType;
        private OmitOnRecursionBehavior _omitOnRecursionBehaviorInstance;
        private OmitOnRecursionBehavior _omitOnRecursionBehaviorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="OmitOnRecursionBehavior" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _omitOnRecursionBehaviorInstanceType = typeof(OmitOnRecursionBehavior);
            _omitOnRecursionBehaviorInstanceFixture = this.Create<OmitOnRecursionBehavior>(true);
            _omitOnRecursionBehaviorInstance = _omitOnRecursionBehaviorInstanceFixture ?? this.Create<OmitOnRecursionBehavior>(false);
            CurrentInstance = _omitOnRecursionBehaviorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodTransform = "Transform";

        #endregion

        #region Fields

        private const string FieldDefaultRecursionDepth = "DefaultRecursionDepth";
        private const string FieldrecursionDepth = "recursionDepth";

        #endregion

        #endregion

        #region General Initializer : Class (OmitOnRecursionBehavior) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OmitOnRecursionBehavior_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OmitOnRecursionBehavior) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OmitOnRecursionBehavior_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OmitOnRecursionBehavior)

        #region General Initializer : Class (OmitOnRecursionBehavior) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransform, 0)]
        public void AUT_OmitOnRecursionBehavior_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OmitOnRecursionBehavior) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDefaultRecursionDepth)]
        [TestCase(FieldrecursionDepth)]
        public void AUT_OmitOnRecursionBehavior_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OmitOnRecursionBehavior) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OmitOnRecursionBehavior_Is_Instance_Present_Test()
        {
            // Assert
            _omitOnRecursionBehaviorInstanceType.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OmitOnRecursionBehavior) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OmitOnRecursionBehavior_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _omitOnRecursionBehaviorInstance.ShouldBeAssignableTo<OmitOnRecursionBehavior>();
            _omitOnRecursionBehaviorInstanceFixture.ShouldBeAssignableTo<OmitOnRecursionBehavior>();
            CurrentInstance.ShouldBeAssignableTo<OmitOnRecursionBehavior>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OmitOnRecursionBehavior) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OmitOnRecursionBehavior instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var recursionDepth = this.CreateType<int>();
            OmitOnRecursionBehavior instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OmitOnRecursionBehavior(recursionDepth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OmitOnRecursionBehavior>();
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var recursionDepth = this.CreateType<int>();
            OmitOnRecursionBehavior instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OmitOnRecursionBehavior(recursionDepth);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) instance created

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Is_Created_Test()
        {
            // Assert
            _omitOnRecursionBehaviorInstance.ShouldNotBeNull();
            _omitOnRecursionBehaviorInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OmitOnRecursionBehavior" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OmitOnRecursionBehavior_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OmitOnRecursionBehavior" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OmitOnRecursionBehavior" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodOmitOnRecursionBehaviorParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOmitOnRecursionBehaviorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OmitOnRecursionBehavior) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OmitOnRecursionBehavior" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OmitOnRecursionBehavior_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOmitOnRecursionBehaviorParametersTypes = new Type[] { typeof(int) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOmitOnRecursionBehaviorParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OmitOnRecursionBehavior_Transform_Method_Call_Internally(Type[] types)
        {
            var methodTransformParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTransform, methodTransformParametersTypes);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OmitOnRecursionBehavior_Transform_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _omitOnRecursionBehaviorInstance.Transform(builder);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OmitOnRecursionBehavior_Transform_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _omitOnRecursionBehaviorInstance.Transform(builder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Transform) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_omitOnRecursionBehaviorInstanceFixture, out exception1, parametersOfTransform);
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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransform);
            var builder = this.CreateType<ISpecimenBuilder>();
            var methodTransformParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfTransform = { builder };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodTransform, methodTransformParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_omitOnRecursionBehaviorInstanceFixture, parametersOfTransform);

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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_OmitOnRecursionBehavior_Transform_Method_Call_Parameters_Count_Verification_Test()
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
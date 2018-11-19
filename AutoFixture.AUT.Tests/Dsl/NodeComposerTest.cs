namespace AutoFixture.Dsl
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
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
    using AutoFixture.Dsl;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Dsl.NodeComposer<dynamic>" />)
    ///     and namespace <see cref="AutoFixture.Dsl"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NodeComposerTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NodeComposer<dynamic>" />)
        /// </summary>
        public NodeComposerTest() : base(typeof(NodeComposer<dynamic>))
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

        #region General Initializer : Class (NodeComposer) Initializer

        #region General Initializer : Class (NodeComposer) One time setup

        private Type _nodeComposerInstanceType;
        private NodeComposer<dynamic> _nodeComposerInstance;
        private NodeComposer<dynamic> _nodeComposerInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="NodeComposer<dynamic>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _nodeComposerInstanceType = typeof(NodeComposer<dynamic>);
            _nodeComposerInstanceFixture = this.Create<NodeComposer<dynamic>>(true);
            _nodeComposerInstance = _nodeComposerInstanceFixture ?? this.Create<NodeComposer<dynamic>>(false);
            CurrentInstance = _nodeComposerInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBuilder = "Builder";

        #endregion

        #region Methods

        private const string MethodFromSeed = "FromSeed";
        private const string MethodFromFactory = "FromFactory";
        private const string MethodCompose = "Compose";
        private const string MethodDo = "Do";
        private const string MethodWithDoNode = "WithDoNode";
        private const string MethodOmitAutoProperties = "OmitAutoProperties";
        private const string MethodWith = "With";
        private const string MethodWithAutoProperties = "WithAutoProperties";
        private const string MethodWithout = "Without";
        private const string MethodWithFactory = "WithFactory";
        private const string MethodCreateSpecification = "CreateSpecification";
        private const string MethodCreate = "Create";
        private const string MethodGetEnumerator = "GetEnumerator";
        private const string MethodGetGraphWithAutoPropertiesNode = "GetGraphWithAutoPropertiesNode";
        private const string MethodFindAutoPropertiesNode = "FindAutoPropertiesNode";
        private const string MethodExcludeMemberFromAutoProperties = "ExcludeMemberFromAutoProperties";
        private const string MethodWithoutSeedIgnoringRelay = "WithoutSeedIgnoringRelay";
        private const string MethodFindContainer = "FindContainer";

        #endregion

        #endregion

        #region General Initializer : Class (NodeComposer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NodeComposer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NodeComposer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NodeComposer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NodeComposer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NodeComposer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NodeComposer)

        #region General Initializer : Class (NodeComposer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFromSeed, 0)]
        [TestCase(MethodFromFactory, 0)]
        [TestCase(MethodFromFactory, 1)]
        [TestCase(MethodCompose, 0)]
        [TestCase(MethodDo, 0)]
        [TestCase(MethodWithDoNode, 0)]
        [TestCase(MethodOmitAutoProperties, 0)]
        [TestCase(MethodWithAutoProperties, 0)]
        [TestCase(MethodWithAutoProperties, 1)]
        [TestCase(MethodWithFactory, 0)]
        [TestCase(MethodCreateSpecification, 0)]
        [TestCase(MethodCompose, 1)]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodGetEnumerator, 0)]
        [TestCase(MethodGetGraphWithAutoPropertiesNode, 0)]
        [TestCase(MethodFindAutoPropertiesNode, 0)]
        [TestCase(MethodExcludeMemberFromAutoProperties, 0)]
        [TestCase(MethodWithoutSeedIgnoringRelay, 0)]
        [TestCase(MethodFindContainer, 0)]
        public void AUT_NodeComposer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NodeComposer) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBuilder)]
        public void AUT_NodeComposer_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (NodeComposer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NodeComposer_Is_Instance_Present_Test()
        {
            // Assert
            _nodeComposerInstanceType.ShouldNotBeNull();
            _nodeComposerInstance.ShouldNotBeNull();
            _nodeComposerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NodeComposer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NodeComposer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NodeComposer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _nodeComposerInstance.ShouldBeAssignableTo<NodeComposer<dynamic>>();
            _nodeComposerInstanceFixture.ShouldBeAssignableTo<NodeComposer<dynamic>>();
            CurrentInstance.ShouldBeAssignableTo<NodeComposer<dynamic>>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NodeComposer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NodeComposer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            NodeComposer<dynamic> instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NodeComposer<dynamic>(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _nodeComposerInstance.ShouldNotBeNull();
            _nodeComposerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NodeComposer<dynamic>>();
        }

        #endregion

        #region General Constructor : Class (NodeComposer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NodeComposer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            NodeComposer<dynamic> instance= null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NodeComposer<dynamic>(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _nodeComposerInstance.ShouldNotBeNull();
            _nodeComposerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NodeComposer) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBuilder)]
        public void AUT_NodeComposer_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NodeComposer) => Property (Builder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NodeComposer_Builder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);
            Action currentAction = () => propertyInfo.SetValue(_nodeComposerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NodeComposer) => Property (Builder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NodeComposer_Public_Class_Builder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);

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

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_Compose_Method_Call_Internally(Type[] types)
        {
            var methodComposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);

            // Act
            Action executeAction = () => _nodeComposerInstance.Compose();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var returnedValue = default(ISpecimenBuilder);

            // Act
            Action executeAction = () => returnedValue = _nodeComposerInstance.Compose();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            Type [] methodComposeParametersTypes = null;
            object[] parametersOfCompose = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilder>(_nodeComposerInstanceFixture, out exception1, parametersOfCompose);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompose.ShouldBeNull();
            methodComposeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            Type [] methodComposeParametersTypes = null;
            object[] parametersOfCompose = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfCompose);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompose.ShouldBeNull();
            methodComposeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            Type [] methodComposeParametersTypes = null;
            object[] parametersOfCompose = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            parametersOfCompose.ShouldBeNull();
            methodComposeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            Type [] methodComposeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodComposeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            Type [] methodComposeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodComposeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilder) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_CreateSpecification_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateSpecificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateSpecification, methodCreateSpecificationParametersTypes);
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            Type [] methodCreateSpecificationParametersTypes = null;
            object[] parametersOfCreateSpecification = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreateSpecification, methodCreateSpecificationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateSpecification, methodCreateSpecificationParametersTypes);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodCreateSpecification, parametersOfCreateSpecification, methodCreateSpecificationParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateSpecification.ShouldBeNull();
            methodCreateSpecificationParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<IRequestSpecification>(MethodCreateSpecification, parametersOfCreateSpecification, methodCreateSpecificationParametersTypes));
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            Type [] methodCreateSpecificationParametersTypes = null;
            object[] parametersOfCreateSpecification = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateSpecification, methodCreateSpecificationParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfCreateSpecification);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateSpecification.ShouldBeNull();
            methodCreateSpecificationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            Type [] methodCreateSpecificationParametersTypes = null;
            object[] parametersOfCreateSpecification = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodCreateSpecification, parametersOfCreateSpecification, methodCreateSpecificationParametersTypes);

            // Assert
            parametersOfCreateSpecification.ShouldBeNull();
            methodCreateSpecificationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            Type [] methodCreateSpecificationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSpecification, methodCreateSpecificationParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateSpecificationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            Type [] methodCreateSpecificationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSpecification, methodCreateSpecificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateSpecificationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSpecification) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_CreateSpecification_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSpecification);
            var methodInfo = this.GetMethodInfo(MethodCreateSpecification, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_Compose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodComposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => _nodeComposerInstance.Compose(builders);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _nodeComposerInstance.Compose(builders);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_nodeComposerInstanceFixture, out exception1, parametersOfCompose);
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
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfCompose);

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
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 1);

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
        public void AUT_NodeComposer_Compose_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 1);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _nodeComposerInstance.Create(request, context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _nodeComposerInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_nodeComposerInstanceFixture, parametersOfCreate);
            var result2 = this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_Create_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_GetEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);

            // Act
            Action executeAction = () => _nodeComposerInstance.GetEnumerator();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var returnedValue = default(IEnumerator<ISpecimenBuilder>);

            // Act
            Action executeAction = () => returnedValue = _nodeComposerInstance.GetEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator<ISpecimenBuilder>>(_nodeComposerInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_GetEnumerator_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<System.Collections.IEnumerator>(_nodeComposerInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodFindAutoPropertiesNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesNode, methodFindAutoPropertiesNodeParametersTypes);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodFindAutoPropertiesNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfFindAutoPropertiesNode = { graph };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodFindAutoPropertiesNode, methodFindAutoPropertiesNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfFindAutoPropertiesNode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFindAutoPropertiesNode.ShouldNotBeNull();
            parametersOfFindAutoPropertiesNode.Length.ShouldBe(1);
            methodFindAutoPropertiesNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodFindAutoPropertiesNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfFindAutoPropertiesNode = { graph };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Postprocessor>(MethodFindAutoPropertiesNode, parametersOfFindAutoPropertiesNode, methodFindAutoPropertiesNodeParametersTypes);

            // Assert
            parametersOfFindAutoPropertiesNode.ShouldNotBeNull();
            parametersOfFindAutoPropertiesNode.Length.ShouldBe(1);
            methodFindAutoPropertiesNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var methodFindAutoPropertiesNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesNode, methodFindAutoPropertiesNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindAutoPropertiesNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var methodFindAutoPropertiesNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindAutoPropertiesNode, methodFindAutoPropertiesNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindAutoPropertiesNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var methodInfo = this.GetMethodInfo(MethodFindAutoPropertiesNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAutoPropertiesNode) (Return Type : Postprocessor) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindAutoPropertiesNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAutoPropertiesNode);
            var methodInfo = this.GetMethodInfo(MethodFindAutoPropertiesNode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_Internally(Type[] types)
        {
            var methodExcludeMemberFromAutoPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExcludeMemberFromAutoProperties, methodExcludeMemberFromAutoPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var member = this.CreateType<MemberInfo>();
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodExcludeMemberFromAutoPropertiesParametersTypes = new Type[] { typeof(MemberInfo), typeof(ISpecimenBuilderNode) };
            object[] parametersOfExcludeMemberFromAutoProperties = { member, graph };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodExcludeMemberFromAutoProperties, methodExcludeMemberFromAutoPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfExcludeMemberFromAutoProperties);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExcludeMemberFromAutoProperties.ShouldNotBeNull();
            parametersOfExcludeMemberFromAutoProperties.Length.ShouldBe(2);
            methodExcludeMemberFromAutoPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var member = this.CreateType<MemberInfo>();
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodExcludeMemberFromAutoPropertiesParametersTypes = new Type[] { typeof(MemberInfo), typeof(ISpecimenBuilderNode) };
            object[] parametersOfExcludeMemberFromAutoProperties = { member, graph };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodExcludeMemberFromAutoProperties, parametersOfExcludeMemberFromAutoProperties, methodExcludeMemberFromAutoPropertiesParametersTypes);

            // Assert
            parametersOfExcludeMemberFromAutoProperties.ShouldNotBeNull();
            parametersOfExcludeMemberFromAutoProperties.Length.ShouldBe(2);
            methodExcludeMemberFromAutoPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var methodExcludeMemberFromAutoPropertiesParametersTypes = new Type[] { typeof(MemberInfo), typeof(ISpecimenBuilderNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExcludeMemberFromAutoProperties, methodExcludeMemberFromAutoPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExcludeMemberFromAutoPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var methodExcludeMemberFromAutoPropertiesParametersTypes = new Type[] { typeof(MemberInfo), typeof(ISpecimenBuilderNode) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExcludeMemberFromAutoProperties, methodExcludeMemberFromAutoPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExcludeMemberFromAutoPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var methodInfo = this.GetMethodInfo(MethodExcludeMemberFromAutoProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExcludeMemberFromAutoProperties) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_ExcludeMemberFromAutoProperties_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExcludeMemberFromAutoProperties);
            var methodInfo = this.GetMethodInfo(MethodExcludeMemberFromAutoProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_Internally(Type[] types)
        {
            var methodWithoutSeedIgnoringRelayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWithoutSeedIgnoringRelay, methodWithoutSeedIgnoringRelayParametersTypes);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodWithoutSeedIgnoringRelayParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfWithoutSeedIgnoringRelay = { graph };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodWithoutSeedIgnoringRelay, methodWithoutSeedIgnoringRelayParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfWithoutSeedIgnoringRelay);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWithoutSeedIgnoringRelay.ShouldNotBeNull();
            parametersOfWithoutSeedIgnoringRelay.Length.ShouldBe(1);
            methodWithoutSeedIgnoringRelayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodWithoutSeedIgnoringRelayParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfWithoutSeedIgnoringRelay = { graph };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodWithoutSeedIgnoringRelay, parametersOfWithoutSeedIgnoringRelay, methodWithoutSeedIgnoringRelayParametersTypes);

            // Assert
            parametersOfWithoutSeedIgnoringRelay.ShouldNotBeNull();
            parametersOfWithoutSeedIgnoringRelay.Length.ShouldBe(1);
            methodWithoutSeedIgnoringRelayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var methodWithoutSeedIgnoringRelayParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWithoutSeedIgnoringRelay, methodWithoutSeedIgnoringRelayParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodWithoutSeedIgnoringRelayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var methodWithoutSeedIgnoringRelayParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWithoutSeedIgnoringRelay, methodWithoutSeedIgnoringRelayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWithoutSeedIgnoringRelayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var methodInfo = this.GetMethodInfo(MethodWithoutSeedIgnoringRelay, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WithoutSeedIgnoringRelay) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_WithoutSeedIgnoringRelay_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWithoutSeedIgnoringRelay);
            var methodInfo = this.GetMethodInfo(MethodWithoutSeedIgnoringRelay, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NodeComposer_FindContainer_Static_Method_Call_Internally(Type[] types)
        {
            var methodFindContainerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindContainer, methodFindContainerParametersTypes);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodFindContainerParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfFindContainer = { graph };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodFindContainer, methodFindContainerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodFindContainer, methodFindContainerParametersTypes);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindContainer, parametersOfFindContainer, methodFindContainerParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_nodeComposerInstanceFixture, parametersOfFindContainer);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFindContainer.ShouldNotBeNull();
            parametersOfFindContainer.Length.ShouldBe(1);
            methodFindContainerParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var methodFindContainerParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            object[] parametersOfFindContainer = { graph };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindContainer, parametersOfFindContainer, methodFindContainerParametersTypes);

            // Assert
            parametersOfFindContainer.ShouldNotBeNull();
            parametersOfFindContainer.Length.ShouldBe(1);
            methodFindContainerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var methodFindContainerParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindContainer, methodFindContainerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindContainerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var methodFindContainerParametersTypes = new Type[] { typeof(ISpecimenBuilderNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindContainer, methodFindContainerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindContainerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var methodInfo = this.GetMethodInfo(MethodFindContainer, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindContainer) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NodeComposer_FindContainer_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContainer);
            var methodInfo = this.GetMethodInfo(MethodFindContainer, 0);
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
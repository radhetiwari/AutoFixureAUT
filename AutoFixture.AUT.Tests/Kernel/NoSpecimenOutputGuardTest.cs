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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.NoSpecimenOutputGuard" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NoSpecimenOutputGuardTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NoSpecimenOutputGuard" />)
        /// </summary>
        public NoSpecimenOutputGuardTest() : base(typeof(NoSpecimenOutputGuard))
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

        #region General Initializer : Class (NoSpecimenOutputGuard) Initializer

        #region General Initializer : Class (NoSpecimenOutputGuard) One time setup

        private Type _noSpecimenOutputGuardInstanceType;
        private NoSpecimenOutputGuard _noSpecimenOutputGuardInstance;
        private NoSpecimenOutputGuard _noSpecimenOutputGuardInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="NoSpecimenOutputGuard" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _noSpecimenOutputGuardInstanceType = typeof(NoSpecimenOutputGuard);
            _noSpecimenOutputGuardInstanceFixture = this.Create<NoSpecimenOutputGuard>(true);
            _noSpecimenOutputGuardInstance = _noSpecimenOutputGuardInstanceFixture ?? this.Create<NoSpecimenOutputGuard>(false);
            CurrentInstance = _noSpecimenOutputGuardInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBuilder = "Builder";
        private const string PropertySpecification = "Specification";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodCompose = "Compose";
        private const string MethodGetEnumerator = "GetEnumerator";

        #endregion

        #endregion

        #region General Initializer : Class (NoSpecimenOutputGuard) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NoSpecimenOutputGuard_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NoSpecimenOutputGuard) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NoSpecimenOutputGuard_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NoSpecimenOutputGuard) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NoSpecimenOutputGuard_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NoSpecimenOutputGuard)

        #region General Initializer : Class (NoSpecimenOutputGuard) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCompose, 0)]
        [TestCase(MethodGetEnumerator, 0)]
        public void AUT_NoSpecimenOutputGuard_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NoSpecimenOutputGuard) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertySpecification)]
        public void AUT_NoSpecimenOutputGuard_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NoSpecimenOutputGuard) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NoSpecimenOutputGuard_Is_Instance_Present_Test()
        {
            // Assert
            _noSpecimenOutputGuardInstanceType.ShouldNotBeNull();
            _noSpecimenOutputGuardInstance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NoSpecimenOutputGuard) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NoSpecimenOutputGuard_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _noSpecimenOutputGuardInstance.ShouldBeAssignableTo<NoSpecimenOutputGuard>();
            _noSpecimenOutputGuardInstanceFixture.ShouldBeAssignableTo<NoSpecimenOutputGuard>();
            CurrentInstance.ShouldBeAssignableTo<NoSpecimenOutputGuard>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NoSpecimenOutputGuard) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            NoSpecimenOutputGuard instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NoSpecimenOutputGuard(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NoSpecimenOutputGuard>();
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            NoSpecimenOutputGuard instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NoSpecimenOutputGuard(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) instance created

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_Is_Created_Test()
        {
            // Assert
            _noSpecimenOutputGuardInstance.ShouldNotBeNull();
            _noSpecimenOutputGuardInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="NoSpecimenOutputGuard" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_NoSpecimenOutputGuard_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="NoSpecimenOutputGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="NoSpecimenOutputGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodNoSpecimenOutputGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodNoSpecimenOutputGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (NoSpecimenOutputGuard) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="NoSpecimenOutputGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoSpecimenOutputGuard_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodNoSpecimenOutputGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IRequestSpecification) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodNoSpecimenOutputGuardParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NoSpecimenOutputGuard) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertySpecification)]
        public void AUT_NoSpecimenOutputGuard_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NoSpecimenOutputGuard) => Property (Builder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NoSpecimenOutputGuard_Builder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);
            Action currentAction = () => propertyInfo.SetValue(_noSpecimenOutputGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NoSpecimenOutputGuard) => Property (Builder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NoSpecimenOutputGuard_Public_Class_Builder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NoSpecimenOutputGuard) => Property (Specification) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NoSpecimenOutputGuard_Specification_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);
            Action currentAction = () => propertyInfo.SetValue(_noSpecimenOutputGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NoSpecimenOutputGuard) => Property (Specification) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NoSpecimenOutputGuard_Public_Class_Specification_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);

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

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NoSpecimenOutputGuard_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _noSpecimenOutputGuardInstance.Create(request, context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _noSpecimenOutputGuardInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_noSpecimenOutputGuardInstanceFixture, parametersOfCreate);
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
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NoSpecimenOutputGuard_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NoSpecimenOutputGuard_Compose_Method_Call_Internally(Type[] types)
        {
            var methodComposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Compose_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => _noSpecimenOutputGuardInstance.Compose(builders);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Compose_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _noSpecimenOutputGuardInstance.Compose(builders);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_noSpecimenOutputGuardInstanceFixture, out exception1, parametersOfCompose);
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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_noSpecimenOutputGuardInstanceFixture, parametersOfCompose);

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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NoSpecimenOutputGuard_Compose_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);

            // Act
            Action executeAction = () => _noSpecimenOutputGuardInstance.GetEnumerator();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var returnedValue = default(IEnumerator<ISpecimenBuilder>);

            // Act
            Action executeAction = () => returnedValue = _noSpecimenOutputGuardInstance.GetEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator<ISpecimenBuilder>>(_noSpecimenOutputGuardInstanceFixture, out exception1, parametersOfGetEnumerator);
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_noSpecimenOutputGuardInstanceFixture, parametersOfGetEnumerator);

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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        private void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<System.Collections.IEnumerator>(_noSpecimenOutputGuardInstanceFixture, out exception1, parametersOfGetEnumerator);
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_noSpecimenOutputGuardInstanceFixture, parametersOfGetEnumerator);

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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_NoSpecimenOutputGuard_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #endregion

        #endregion
    }
}
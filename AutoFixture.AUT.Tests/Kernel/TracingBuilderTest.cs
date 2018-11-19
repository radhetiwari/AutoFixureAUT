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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.TracingBuilder" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TracingBuilderTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TracingBuilder" />)
        /// </summary>
        public TracingBuilderTest() : base(typeof(TracingBuilder))
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

        #region General Initializer : Class (TracingBuilder) Initializer

        #region General Initializer : Class (TracingBuilder) One time setup

        private Type _tracingBuilderInstanceType;
        private TracingBuilder _tracingBuilderInstance;
        private TracingBuilder _tracingBuilderInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="TracingBuilder" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _tracingBuilderInstanceType = typeof(TracingBuilder);
            _tracingBuilderInstanceFixture = this.Create<TracingBuilder>(true);
            _tracingBuilderInstance = _tracingBuilderInstanceFixture ?? this.Create<TracingBuilder>(false);
            CurrentInstance = _tracingBuilderInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBuilder = "Builder";
        private const string PropertyFilter = "Filter";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodOnSpecimenCreated = "OnSpecimenCreated";
        private const string MethodOnSpecimenRequested = "OnSpecimenRequested";

        #endregion

        #region Fields

        private const string Fieldfilter = "filter";
        private const string Fielddepth = "depth";

        #endregion

        #endregion

        #region General Initializer : Class (TracingBuilder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TracingBuilder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TracingBuilder) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TracingBuilder_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TracingBuilder) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TracingBuilder_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TracingBuilder)

        #region General Initializer : Class (TracingBuilder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodOnSpecimenCreated, 0)]
        [TestCase(MethodOnSpecimenRequested, 0)]
        public void AUT_TracingBuilder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TracingBuilder) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertyFilter)]
        public void AUT_TracingBuilder_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TracingBuilder) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldfilter)]
        [TestCase(Fielddepth)]
        public void AUT_TracingBuilder_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TracingBuilder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TracingBuilder_Is_Instance_Present_Test()
        {
            // Assert
            _tracingBuilderInstanceType.ShouldNotBeNull();
            _tracingBuilderInstance.ShouldNotBeNull();
            _tracingBuilderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TracingBuilder) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TracingBuilder" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TracingBuilder_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _tracingBuilderInstance.ShouldBeAssignableTo<TracingBuilder>();
            _tracingBuilderInstanceFixture.ShouldBeAssignableTo<TracingBuilder>();
            CurrentInstance.ShouldBeAssignableTo<TracingBuilder>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TracingBuilder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TracingBuilder_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            TracingBuilder instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TracingBuilder(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _tracingBuilderInstance.ShouldNotBeNull();
            _tracingBuilderInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TracingBuilder>();
        }

        #endregion

        #region General Constructor : Class (TracingBuilder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TracingBuilder_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            TracingBuilder instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TracingBuilder(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _tracingBuilderInstance.ShouldNotBeNull();
            _tracingBuilderInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TracingBuilder) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertyFilter)]
        public void AUT_TracingBuilder_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TracingBuilder) => Property (Builder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TracingBuilder_Builder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);
            Action currentAction = () => propertyInfo.SetValue(_tracingBuilderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TracingBuilder) => Property (Builder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TracingBuilder_Public_Class_Builder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TracingBuilder) => Property (Filter) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TracingBuilder_Filter_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFilter);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFilter);
            Action currentAction = () => propertyInfo.SetValue(_tracingBuilderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TracingBuilder) => Property (Filter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TracingBuilder_Public_Class_Filter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFilter);
            var propertyInfo = this.GetPropertyInfo(PropertyFilter);

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
        private void AUT_TracingBuilder_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _tracingBuilderInstance.Create(request, context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _tracingBuilderInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_tracingBuilderInstanceFixture, parametersOfCreate);
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
        public void AUT_TracingBuilder_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_TracingBuilder_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_TracingBuilder_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_TracingBuilder_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_TracingBuilder_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (OnSpecimenCreated) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_Internally(Type[] types)
        {
            var methodOnSpecimenCreatedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnSpecimenCreated, methodOnSpecimenCreatedParametersTypes);
        }

        #endregion

        #region Method Call : (OnSpecimenCreated) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenCreated);
            var e = this.CreateType<SpecimenCreatedEventArgs>();
            var methodOnSpecimenCreatedParametersTypes = new Type[] { typeof(SpecimenCreatedEventArgs) };
            object[] parametersOfOnSpecimenCreated = { e };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenCreated, methodOnSpecimenCreatedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_tracingBuilderInstanceFixture, parametersOfOnSpecimenCreated);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSpecimenCreated.ShouldNotBeNull();
            parametersOfOnSpecimenCreated.Length.ShouldBe(1);
            methodOnSpecimenCreatedParametersTypes.Length.ShouldBe(1);
            methodOnSpecimenCreatedParametersTypes.Length.ShouldBe(parametersOfOnSpecimenCreated.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenCreated) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenCreated);
            var e = this.CreateType<SpecimenCreatedEventArgs>();
            var methodOnSpecimenCreatedParametersTypes = new Type[] { typeof(SpecimenCreatedEventArgs) };
            object[] parametersOfOnSpecimenCreated = { e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSpecimenCreated, parametersOfOnSpecimenCreated, methodOnSpecimenCreatedParametersTypes);

            // Assert
            parametersOfOnSpecimenCreated.ShouldNotBeNull();
            parametersOfOnSpecimenCreated.Length.ShouldBe(1);
            methodOnSpecimenCreatedParametersTypes.Length.ShouldBe(1);
            methodOnSpecimenCreatedParametersTypes.Length.ShouldBe(parametersOfOnSpecimenCreated.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenCreated) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenCreated);
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenCreated, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSpecimenCreated) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenCreated);
            var methodOnSpecimenCreatedParametersTypes = new Type[] { typeof(SpecimenCreatedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSpecimenCreated, methodOnSpecimenCreatedParametersTypes);

            // Assert
            methodOnSpecimenCreatedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenCreated) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenCreated_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenCreated);
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenCreated, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_Internally(Type[] types)
        {
            var methodOnSpecimenRequestedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnSpecimenRequested, methodOnSpecimenRequestedParametersTypes);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenRequested);
            var e = this.CreateType<RequestTraceEventArgs>();
            var methodOnSpecimenRequestedParametersTypes = new Type[] { typeof(RequestTraceEventArgs) };
            object[] parametersOfOnSpecimenRequested = { e };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenRequested, methodOnSpecimenRequestedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_tracingBuilderInstanceFixture, parametersOfOnSpecimenRequested);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSpecimenRequested.ShouldNotBeNull();
            parametersOfOnSpecimenRequested.Length.ShouldBe(1);
            methodOnSpecimenRequestedParametersTypes.Length.ShouldBe(1);
            methodOnSpecimenRequestedParametersTypes.Length.ShouldBe(parametersOfOnSpecimenRequested.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenRequested);
            var e = this.CreateType<RequestTraceEventArgs>();
            var methodOnSpecimenRequestedParametersTypes = new Type[] { typeof(RequestTraceEventArgs) };
            object[] parametersOfOnSpecimenRequested = { e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSpecimenRequested, parametersOfOnSpecimenRequested, methodOnSpecimenRequestedParametersTypes);

            // Assert
            parametersOfOnSpecimenRequested.ShouldNotBeNull();
            parametersOfOnSpecimenRequested.Length.ShouldBe(1);
            methodOnSpecimenRequestedParametersTypes.Length.ShouldBe(1);
            methodOnSpecimenRequestedParametersTypes.Length.ShouldBe(parametersOfOnSpecimenRequested.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenRequested);
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenRequested, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenRequested);
            var methodOnSpecimenRequestedParametersTypes = new Type[] { typeof(RequestTraceEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSpecimenRequested, methodOnSpecimenRequestedParametersTypes);

            // Assert
            methodOnSpecimenRequestedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSpecimenRequested) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TracingBuilder_OnSpecimenRequested_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSpecimenRequested);
            var methodInfo = this.GetMethodInfo(MethodOnSpecimenRequested, 0);

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
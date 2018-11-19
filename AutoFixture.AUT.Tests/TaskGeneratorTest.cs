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
    using System.Threading.Tasks;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.TaskGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TaskGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TaskGenerator" />)
        /// </summary>
        public TaskGeneratorTest() : base(typeof(TaskGenerator))
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

        #region General Initializer : Class (TaskGenerator) Initializer

        #region General Initializer : Class (TaskGenerator) One time setup

        private Type _taskGeneratorInstanceType;
        private TaskGenerator _taskGeneratorInstance;
        private TaskGenerator _taskGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="TaskGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _taskGeneratorInstanceType = typeof(TaskGenerator);
            _taskGeneratorInstanceFixture = this.Create<TaskGenerator>(true);
            _taskGeneratorInstance = _taskGeneratorInstanceFixture ?? this.Create<TaskGenerator>(false);
            CurrentInstance = _taskGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodCreateGenericTask = "CreateGenericTask";
        private const string MethodCreateNonGenericTask = "CreateNonGenericTask";
        private const string MethodCreateTask = "CreateTask";

        #endregion

        #endregion

        #region General Initializer : Class (TaskGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TaskGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TaskGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TaskGenerator)

        #region General Initializer : Class (TaskGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TaskGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCreateGenericTask, 0)]
        [TestCase(MethodCreateNonGenericTask, 0)]
        [TestCase(MethodCreateTask, 0)]
        public void AUT_TaskGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TaskGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TaskGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _taskGeneratorInstanceType.ShouldNotBeNull();
            _taskGeneratorInstance.ShouldNotBeNull();
            _taskGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TaskGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TaskGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _taskGeneratorInstance.ShouldBeAssignableTo<TaskGenerator>();
            _taskGeneratorInstanceFixture.ShouldBeAssignableTo<TaskGenerator>();
            CurrentInstance.ShouldBeAssignableTo<TaskGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TaskGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TaskGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _taskGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _taskGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_taskGeneratorInstanceFixture, out exception1, parametersOfCreate);
            var result2 = this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_taskGeneratorInstanceFixture, parametersOfCreate);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_TaskGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_TaskGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_TaskGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_TaskGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (CreateGenericTask) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateGenericTaskParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateGenericTask, methodCreateGenericTaskParametersTypes);
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var resultType = this.CreateType<Type>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateGenericTaskParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            object[] parametersOfCreateGenericTask = { resultType, context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateGenericTask, methodCreateGenericTaskParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_taskGeneratorInstanceFixture, parametersOfCreateGenericTask);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateGenericTask.ShouldNotBeNull();
            parametersOfCreateGenericTask.Length.ShouldBe(2);
            methodCreateGenericTaskParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var resultType = this.CreateType<Type>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateGenericTaskParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            object[] parametersOfCreateGenericTask = { resultType, context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateGenericTask, parametersOfCreateGenericTask, methodCreateGenericTaskParametersTypes);

            // Assert
            parametersOfCreateGenericTask.ShouldNotBeNull();
            parametersOfCreateGenericTask.Length.ShouldBe(2);
            methodCreateGenericTaskParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var methodCreateGenericTaskParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateGenericTask, methodCreateGenericTaskParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateGenericTaskParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var methodCreateGenericTaskParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenContext) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateGenericTask, methodCreateGenericTaskParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateGenericTaskParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var methodInfo = this.GetMethodInfo(MethodCreateGenericTask, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateGenericTask) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateGenericTask_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericTask);
            var methodInfo = this.GetMethodInfo(MethodCreateGenericTask, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateNonGenericTaskParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            Type [] methodCreateNonGenericTaskParametersTypes = null;
            object[] parametersOfCreateNonGenericTask = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodCreateNonGenericTask, parametersOfCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNonGenericTask.ShouldBeNull();
            methodCreateNonGenericTaskParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<object>(MethodCreateNonGenericTask, parametersOfCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes));
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            Type [] methodCreateNonGenericTaskParametersTypes = null;
            object[] parametersOfCreateNonGenericTask = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_taskGeneratorInstanceFixture, parametersOfCreateNonGenericTask);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateNonGenericTask.ShouldBeNull();
            methodCreateNonGenericTaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            Type [] methodCreateNonGenericTaskParametersTypes = null;
            object[] parametersOfCreateNonGenericTask = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateNonGenericTask, parametersOfCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);

            // Assert
            parametersOfCreateNonGenericTask.ShouldBeNull();
            methodCreateNonGenericTaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            Type [] methodCreateNonGenericTaskParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNonGenericTaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            Type [] methodCreateNonGenericTaskParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNonGenericTask, methodCreateNonGenericTaskParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNonGenericTaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNonGenericTask) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateNonGenericTask_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNonGenericTask);
            var methodInfo = this.GetMethodInfo(MethodCreateNonGenericTask, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskGenerator_CreateTask_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateTaskParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateTask, methodCreateTaskParametersTypes);
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var resultType = this.CreateType<Type>();
            var result = this.CreateType<object>();
            var methodCreateTaskParametersTypes = new Type[] { typeof(Type), typeof(object) };
            object[] parametersOfCreateTask = { resultType, result };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateTask, methodCreateTaskParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_taskGeneratorInstanceFixture, parametersOfCreateTask);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateTask.ShouldNotBeNull();
            parametersOfCreateTask.Length.ShouldBe(2);
            methodCreateTaskParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var resultType = this.CreateType<Type>();
            var result = this.CreateType<object>();
            var methodCreateTaskParametersTypes = new Type[] { typeof(Type), typeof(object) };
            object[] parametersOfCreateTask = { resultType, result };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateTask, parametersOfCreateTask, methodCreateTaskParametersTypes);

            // Assert
            parametersOfCreateTask.ShouldNotBeNull();
            parametersOfCreateTask.Length.ShouldBe(2);
            methodCreateTaskParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var methodCreateTaskParametersTypes = new Type[] { typeof(Type), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateTask, methodCreateTaskParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateTaskParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var methodCreateTaskParametersTypes = new Type[] { typeof(Type), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateTask, methodCreateTaskParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateTaskParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var methodInfo = this.GetMethodInfo(MethodCreateTask, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateTask) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskGenerator_CreateTask_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTask);
            var methodInfo = this.GetMethodInfo(MethodCreateTask, 0);
            const int parametersCount = 2;

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
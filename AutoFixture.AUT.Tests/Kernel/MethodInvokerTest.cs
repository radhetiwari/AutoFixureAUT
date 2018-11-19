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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MethodInvoker" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MethodInvokerTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MethodInvoker" />)
        /// </summary>
        public MethodInvokerTest() : base(typeof(MethodInvoker))
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

        #region General Initializer : Class (MethodInvoker) Initializer

        #region General Initializer : Class (MethodInvoker) One time setup

        private Type _methodInvokerInstanceType;
        private MethodInvoker _methodInvokerInstance;
        private MethodInvoker _methodInvokerInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MethodInvoker" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _methodInvokerInstanceType = typeof(MethodInvoker);
            _methodInvokerInstanceFixture = this.Create<MethodInvoker>(true);
            _methodInvokerInstance = _methodInvokerInstanceFixture ?? this.Create<MethodInvoker>(false);
            CurrentInstance = _methodInvokerInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyQuery = "Query";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodGetConstructors = "GetConstructors";
        private const string MethodIsValueValid = "IsValueValid";

        #endregion

        #endregion

        #region General Initializer : Class (MethodInvoker) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MethodInvoker_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MethodInvoker) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MethodInvoker_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MethodInvoker) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MethodInvoker_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MethodInvoker)

        #region General Initializer : Class (MethodInvoker) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodGetConstructors, 0)]
        [TestCase(MethodIsValueValid, 0)]
        public void AUT_MethodInvoker_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MethodInvoker) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyQuery)]
        public void AUT_MethodInvoker_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MethodInvoker) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MethodInvoker_Is_Instance_Present_Test()
        {
            // Assert
            _methodInvokerInstanceType.ShouldNotBeNull();
            _methodInvokerInstance.ShouldNotBeNull();
            _methodInvokerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MethodInvoker) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MethodInvoker" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MethodInvoker_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _methodInvokerInstance.ShouldBeAssignableTo<MethodInvoker>();
            _methodInvokerInstanceFixture.ShouldBeAssignableTo<MethodInvoker>();
            CurrentInstance.ShouldBeAssignableTo<MethodInvoker>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MethodInvoker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MethodInvoker_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var query = this.CreateType<IMethodQuery>();
            MethodInvoker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new MethodInvoker(query);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _methodInvokerInstance.ShouldNotBeNull();
            _methodInvokerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<MethodInvoker>();
        }

        #endregion

        #region General Constructor : Class (MethodInvoker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MethodInvoker_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var query = this.CreateType<IMethodQuery>();
            MethodInvoker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new MethodInvoker(query);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _methodInvokerInstance.ShouldNotBeNull();
            _methodInvokerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MethodInvoker) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyQuery)]
        public void AUT_MethodInvoker_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MethodInvoker) => Property (Query) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MethodInvoker_Query_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuery);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyQuery);
            Action currentAction = () => propertyInfo.SetValue(_methodInvokerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (MethodInvoker) => Property (Query) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MethodInvoker_Public_Class_Query_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyQuery);

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
        private void AUT_MethodInvoker_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _methodInvokerInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _methodInvokerInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_methodInvokerInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_MethodInvoker_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_methodInvokerInstanceFixture, parametersOfCreate);

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
        public void AUT_MethodInvoker_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MethodInvoker_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_MethodInvoker_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MethodInvoker_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_MethodInvoker_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MethodInvoker_GetConstructors_Method_Call_Internally(Type[] types)
        {
            var methodGetConstructorsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConstructors, methodGetConstructorsParametersTypes);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var request = this.CreateType<object>();
            var methodGetConstructorsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetConstructors = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetConstructors, methodGetConstructorsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<IMethod>>(_methodInvokerInstanceFixture, out exception1, parametersOfGetConstructors);
            var result2 = this.GetResultOfMethod<IEnumerable<IMethod>>(MethodGetConstructors, parametersOfGetConstructors, methodGetConstructorsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConstructors.ShouldNotBeNull();
            parametersOfGetConstructors.Length.ShouldBe(1);
            methodGetConstructorsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var request = this.CreateType<object>();
            var methodGetConstructorsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetConstructors = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetConstructors, methodGetConstructorsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_methodInvokerInstanceFixture, parametersOfGetConstructors);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConstructors.ShouldNotBeNull();
            parametersOfGetConstructors.Length.ShouldBe(1);
            methodGetConstructorsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var request = this.CreateType<object>();
            var methodGetConstructorsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetConstructors = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<IMethod>>(MethodGetConstructors, parametersOfGetConstructors, methodGetConstructorsParametersTypes);

            // Assert
            parametersOfGetConstructors.ShouldNotBeNull();
            parametersOfGetConstructors.Length.ShouldBe(1);
            methodGetConstructorsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var methodGetConstructorsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConstructors, methodGetConstructorsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetConstructorsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var methodGetConstructorsParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConstructors, methodGetConstructorsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConstructorsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var methodInfo = this.GetMethodInfo(MethodGetConstructors, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConstructors) (Return Type : IEnumerable<IMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_GetConstructors_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConstructors);
            var methodInfo = this.GetMethodInfo(MethodGetConstructors, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsValueValidParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsValueValid, methodIsValueValidParametersTypes);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var value = this.CreateType<object>();
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsValueValid = { value };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsValueValid, methodIsValueValidParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsValueValid, methodIsValueValidParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsValueValid, parametersOfIsValueValid, methodIsValueValidParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsValueValid.ShouldNotBeNull();
            parametersOfIsValueValid.Length.ShouldBe(1);
            methodIsValueValidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsValueValid, parametersOfIsValueValid, methodIsValueValidParametersTypes));
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var value = this.CreateType<object>();
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsValueValid = { value };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsValueValid, methodIsValueValidParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_methodInvokerInstanceFixture, parametersOfIsValueValid);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsValueValid.ShouldNotBeNull();
            parametersOfIsValueValid.Length.ShouldBe(1);
            methodIsValueValidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var value = this.CreateType<object>();
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsValueValid = { value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsValueValid, parametersOfIsValueValid, methodIsValueValidParametersTypes);

            // Assert
            parametersOfIsValueValid.ShouldNotBeNull();
            parametersOfIsValueValid.Length.ShouldBe(1);
            methodIsValueValidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsValueValid, methodIsValueValidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsValueValidParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsValueValid, methodIsValueValidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsValueValidParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var methodIsValueValidParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsValueValid, methodIsValueValidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsValueValidParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var methodInfo = this.GetMethodInfo(MethodIsValueValid, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsValueValid) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodInvoker_IsValueValid_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValueValid);
            var methodInfo = this.GetMethodInfo(MethodIsValueValid, 0);
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
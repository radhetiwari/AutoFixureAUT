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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.RandomDateTimeSequenceGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RandomDateTimeSequenceGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RandomDateTimeSequenceGenerator" />)
        /// </summary>
        public RandomDateTimeSequenceGeneratorTest() : base(typeof(RandomDateTimeSequenceGenerator))
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

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) Initializer

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) One time setup

        private Type _randomDateTimeSequenceGeneratorInstanceType;
        private RandomDateTimeSequenceGenerator _randomDateTimeSequenceGeneratorInstance;
        private RandomDateTimeSequenceGenerator _randomDateTimeSequenceGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RandomDateTimeSequenceGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _randomDateTimeSequenceGeneratorInstanceType = typeof(RandomDateTimeSequenceGenerator);
            _randomDateTimeSequenceGeneratorInstanceFixture = this.Create<RandomDateTimeSequenceGenerator>(true);
            _randomDateTimeSequenceGeneratorInstance = _randomDateTimeSequenceGeneratorInstanceFixture ?? this.Create<RandomDateTimeSequenceGenerator>(false);
            CurrentInstance = _randomDateTimeSequenceGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodIsNotDateTimeRequest = "IsNotDateTimeRequest";
        private const string MethodCreateRandomDate = "CreateRandomDate";
        private const string MethodGetRandomNumberOfTicks = "GetRandomNumberOfTicks";

        #endregion

        #region Fields

        private const string Fieldrandomizer = "randomizer";

        #endregion

        #endregion

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomDateTimeSequenceGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomDateTimeSequenceGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RandomDateTimeSequenceGenerator)

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodIsNotDateTimeRequest, 0)]
        [TestCase(MethodCreateRandomDate, 0)]
        [TestCase(MethodGetRandomNumberOfTicks, 0)]
        public void AUT_RandomDateTimeSequenceGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RandomDateTimeSequenceGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldrandomizer)]
        public void AUT_RandomDateTimeSequenceGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RandomDateTimeSequenceGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomDateTimeSequenceGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _randomDateTimeSequenceGeneratorInstanceType.ShouldNotBeNull();
            _randomDateTimeSequenceGeneratorInstance.ShouldNotBeNull();
            _randomDateTimeSequenceGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RandomDateTimeSequenceGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomDateTimeSequenceGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _randomDateTimeSequenceGeneratorInstance.ShouldBeAssignableTo<RandomDateTimeSequenceGenerator>();
            _randomDateTimeSequenceGeneratorInstanceFixture.ShouldBeAssignableTo<RandomDateTimeSequenceGenerator>();
            CurrentInstance.ShouldBeAssignableTo<RandomDateTimeSequenceGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomDateTimeSequenceGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RandomDateTimeSequenceGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) instance created

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomDateTimeSequenceGenerator_Is_Created_Test()
        {
            // Assert
            _randomDateTimeSequenceGeneratorInstance.ShouldNotBeNull();
            _randomDateTimeSequenceGeneratorInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="RandomDateTimeSequenceGenerator" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_RandomDateTimeSequenceGenerator_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="RandomDateTimeSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomDateTimeSequenceGenerator_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RandomDateTimeSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomDateTimeSequenceGenerator_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodRandomDateTimeSequenceGeneratorParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRandomDateTimeSequenceGeneratorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RandomDateTimeSequenceGenerator) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RandomDateTimeSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomDateTimeSequenceGenerator_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRandomDateTimeSequenceGeneratorParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRandomDateTimeSequenceGeneratorParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _randomDateTimeSequenceGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _randomDateTimeSequenceGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_randomDateTimeSequenceGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_randomDateTimeSequenceGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_RandomDateTimeSequenceGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsNotDateTimeRequestParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var request = this.CreateType<object>();
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsNotDateTimeRequest = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsNotDateTimeRequest, parametersOfIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsNotDateTimeRequest.ShouldNotBeNull();
            parametersOfIsNotDateTimeRequest.Length.ShouldBe(1);
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsNotDateTimeRequest, parametersOfIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes));
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var request = this.CreateType<object>();
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsNotDateTimeRequest = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomDateTimeSequenceGeneratorInstanceFixture, parametersOfIsNotDateTimeRequest);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsNotDateTimeRequest.ShouldNotBeNull();
            parametersOfIsNotDateTimeRequest.Length.ShouldBe(1);
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var request = this.CreateType<object>();
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsNotDateTimeRequest = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsNotDateTimeRequest, parametersOfIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);

            // Assert
            parametersOfIsNotDateTimeRequest.ShouldNotBeNull();
            parametersOfIsNotDateTimeRequest.Length.ShouldBe(1);
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var methodIsNotDateTimeRequestParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsNotDateTimeRequest, methodIsNotDateTimeRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsNotDateTimeRequestParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var methodInfo = this.GetMethodInfo(MethodIsNotDateTimeRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsNotDateTimeRequest) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_IsNotDateTimeRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNotDateTimeRequest);
            var methodInfo = this.GetMethodInfo(MethodIsNotDateTimeRequest, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_Internally(Type[] types)
        {
            var methodCreateRandomDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRandomDate, methodCreateRandomDateParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateRandomDateParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfCreateRandomDate = { context };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreateRandomDate, methodCreateRandomDateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_randomDateTimeSequenceGeneratorInstanceFixture, out exception1, parametersOfCreateRandomDate);
            var result2 = this.GetResultOfMethod<object>(MethodCreateRandomDate, parametersOfCreateRandomDate, methodCreateRandomDateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateRandomDate.ShouldNotBeNull();
            parametersOfCreateRandomDate.Length.ShouldBe(1);
            methodCreateRandomDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateRandomDateParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfCreateRandomDate = { context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateRandomDate, methodCreateRandomDateParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomDateTimeSequenceGeneratorInstanceFixture, parametersOfCreateRandomDate);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRandomDate.ShouldNotBeNull();
            parametersOfCreateRandomDate.Length.ShouldBe(1);
            methodCreateRandomDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateRandomDateParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfCreateRandomDate = { context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateRandomDate, parametersOfCreateRandomDate, methodCreateRandomDateParametersTypes);

            // Assert
            parametersOfCreateRandomDate.ShouldNotBeNull();
            parametersOfCreateRandomDate.Length.ShouldBe(1);
            methodCreateRandomDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var methodCreateRandomDateParametersTypes = new Type[] { typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRandomDate, methodCreateRandomDateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateRandomDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var methodCreateRandomDateParametersTypes = new Type[] { typeof(ISpecimenContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRandomDate, methodCreateRandomDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRandomDateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var methodInfo = this.GetMethodInfo(MethodCreateRandomDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRandomDate) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_CreateRandomDate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomDate);
            var methodInfo = this.GetMethodInfo(MethodCreateRandomDate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Internally(Type[] types)
        {
            var methodGetRandomNumberOfTicksParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var context = this.CreateType<ISpecimenContext>();
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfGetRandomNumberOfTicks = { context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomDateTimeSequenceGeneratorInstanceFixture, parametersOfGetRandomNumberOfTicks);
            var result2 = this.GetResultOfMethod<long>(MethodGetRandomNumberOfTicks, parametersOfGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.Length.ShouldBe(1);
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var context = this.CreateType<ISpecimenContext>();
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfGetRandomNumberOfTicks = { context };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomDateTimeSequenceGeneratorInstanceFixture, out exception1, parametersOfGetRandomNumberOfTicks);
            var result2 = this.GetResultOfMethod<long>(MethodGetRandomNumberOfTicks, parametersOfGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.Length.ShouldBe(1);
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var context = this.CreateType<ISpecimenContext>();
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfGetRandomNumberOfTicks = { context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomDateTimeSequenceGeneratorInstanceFixture, parametersOfGetRandomNumberOfTicks);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRandomNumberOfTicks.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.Length.ShouldBe(1);
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var context = this.CreateType<ISpecimenContext>();
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };
            object[] parametersOfGetRandomNumberOfTicks = { context };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodGetRandomNumberOfTicks, parametersOfGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            parametersOfGetRandomNumberOfTicks.ShouldNotBeNull();
            parametersOfGetRandomNumberOfTicks.Length.ShouldBe(1);
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var methodGetRandomNumberOfTicksParametersTypes = new Type[] { typeof(ISpecimenContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRandomNumberOfTicks, methodGetRandomNumberOfTicksParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRandomNumberOfTicksParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var methodInfo = this.GetMethodInfo(MethodGetRandomNumberOfTicks, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRandomNumberOfTicks) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomDateTimeSequenceGenerator_GetRandomNumberOfTicks_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRandomNumberOfTicks);
            var methodInfo = this.GetMethodInfo(MethodGetRandomNumberOfTicks, 0);
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
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
    using System.Threading;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NumericSequenceGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NumericSequenceGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NumericSequenceGenerator" />)
        /// </summary>
        public NumericSequenceGeneratorTest() : base(typeof(NumericSequenceGenerator))
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

        #region General Initializer : Class (NumericSequenceGenerator) Initializer

        #region General Initializer : Class (NumericSequenceGenerator) One time setup

        private Type _numericSequenceGeneratorInstanceType;
        private NumericSequenceGenerator _numericSequenceGeneratorInstance;
        private NumericSequenceGenerator _numericSequenceGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="NumericSequenceGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _numericSequenceGeneratorInstanceType = typeof(NumericSequenceGenerator);
            _numericSequenceGeneratorInstanceFixture = this.Create<NumericSequenceGenerator>(true);
            _numericSequenceGeneratorInstance = _numericSequenceGeneratorInstanceFixture ?? this.Create<NumericSequenceGenerator>(false);
            CurrentInstance = _numericSequenceGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodCreateNumericSpecimen = "CreateNumericSpecimen";
        private const string MethodGetNextNumber = "GetNextNumber";

        #endregion

        #region Fields

        private const string Fieldvalue = "value";

        #endregion

        #endregion

        #region General Initializer : Class (NumericSequenceGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NumericSequenceGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NumericSequenceGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NumericSequenceGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NumericSequenceGenerator)

        #region General Initializer : Class (NumericSequenceGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCreateNumericSpecimen, 0)]
        [TestCase(MethodGetNextNumber, 0)]
        public void AUT_NumericSequenceGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NumericSequenceGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldvalue)]
        public void AUT_NumericSequenceGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NumericSequenceGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NumericSequenceGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _numericSequenceGeneratorInstanceType.ShouldNotBeNull();
            _numericSequenceGeneratorInstance.ShouldNotBeNull();
            _numericSequenceGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NumericSequenceGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NumericSequenceGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NumericSequenceGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _numericSequenceGeneratorInstance.ShouldBeAssignableTo<NumericSequenceGenerator>();
            _numericSequenceGeneratorInstanceFixture.ShouldBeAssignableTo<NumericSequenceGenerator>();
            CurrentInstance.ShouldBeAssignableTo<NumericSequenceGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NumericSequenceGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NumericSequenceGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NumericSequenceGenerator instance = null;

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
        private void AUT_NumericSequenceGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _numericSequenceGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _numericSequenceGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_numericSequenceGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_NumericSequenceGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_numericSequenceGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_NumericSequenceGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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

        #region Method Call : (Create) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (Create) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_Internally(Type[] types)
        {
            var methodCreateNumericSpecimenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var request = this.CreateType<Type>();
            var methodCreateNumericSpecimenParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateNumericSpecimen = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_numericSequenceGeneratorInstanceFixture, out exception1, parametersOfCreateNumericSpecimen);
            var result2 = this.GetResultOfMethod<object>(MethodCreateNumericSpecimen, parametersOfCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNumericSpecimen.ShouldNotBeNull();
            parametersOfCreateNumericSpecimen.Length.ShouldBe(1);
            methodCreateNumericSpecimenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var request = this.CreateType<Type>();
            var methodCreateNumericSpecimenParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateNumericSpecimen = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_numericSequenceGeneratorInstanceFixture, parametersOfCreateNumericSpecimen);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateNumericSpecimen.ShouldNotBeNull();
            parametersOfCreateNumericSpecimen.Length.ShouldBe(1);
            methodCreateNumericSpecimenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var request = this.CreateType<Type>();
            var methodCreateNumericSpecimenParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateNumericSpecimen = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateNumericSpecimen, parametersOfCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes);

            // Assert
            parametersOfCreateNumericSpecimen.ShouldNotBeNull();
            parametersOfCreateNumericSpecimen.Length.ShouldBe(1);
            methodCreateNumericSpecimenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var methodCreateNumericSpecimenParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNumericSpecimenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var methodCreateNumericSpecimenParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNumericSpecimen, methodCreateNumericSpecimenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNumericSpecimenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var methodInfo = this.GetMethodInfo(MethodCreateNumericSpecimen, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateNumericSpecimen) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_CreateNumericSpecimen_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNumericSpecimen);
            var methodInfo = this.GetMethodInfo(MethodCreateNumericSpecimen, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_Internally(Type[] types)
        {
            var methodGetNextNumberParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNextNumber, methodGetNextNumberParametersTypes);
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;
            object[] parametersOfGetNextNumber = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetNextNumber, methodGetNextNumberParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_numericSequenceGeneratorInstanceFixture, parametersOfGetNextNumber);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextNumber, parametersOfGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextNumber.ShouldBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;
            object[] parametersOfGetNextNumber = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetNextNumber, methodGetNextNumberParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_numericSequenceGeneratorInstanceFixture, out exception1, parametersOfGetNextNumber);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextNumber, parametersOfGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextNumber.ShouldBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;
            object[] parametersOfGetNextNumber = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetNextNumber, methodGetNextNumberParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_numericSequenceGeneratorInstanceFixture, parametersOfGetNextNumber);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNextNumber.ShouldBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;
            object[] parametersOfGetNextNumber = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodGetNextNumber, parametersOfGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            parametersOfGetNextNumber.ShouldBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextNumberParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            Type [] methodGetNextNumberParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNextNumber, methodGetNextNumberParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNextNumberParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextNumber) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NumericSequenceGenerator_GetNextNumber_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextNumber);
            var methodInfo = this.GetMethodInfo(MethodGetNextNumber, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}
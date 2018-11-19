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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.DoubleSequenceGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DoubleSequenceGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoubleSequenceGenerator" />)
        /// </summary>
        public DoubleSequenceGeneratorTest() : base(typeof(DoubleSequenceGenerator))
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

        #region General Initializer : Class (DoubleSequenceGenerator) Initializer

        #region General Initializer : Class (DoubleSequenceGenerator) One time setup

        private Type _doubleSequenceGeneratorInstanceType;
        private DoubleSequenceGenerator _doubleSequenceGeneratorInstance;
        private DoubleSequenceGenerator _doubleSequenceGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="DoubleSequenceGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doubleSequenceGeneratorInstanceType = typeof(DoubleSequenceGenerator);
            _doubleSequenceGeneratorInstanceFixture = this.Create<DoubleSequenceGenerator>(true);
            _doubleSequenceGeneratorInstance = _doubleSequenceGeneratorInstanceFixture ?? this.Create<DoubleSequenceGenerator>(false);
            CurrentInstance = _doubleSequenceGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodCreateAnonymous = "CreateAnonymous";

        #endregion

        #region Fields

        private const string Fieldd = "d";
        private const string FieldsyncRoot = "syncRoot";

        #endregion

        #endregion

        #region General Initializer : Class (DoubleSequenceGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DoubleSequenceGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DoubleSequenceGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DoubleSequenceGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoubleSequenceGenerator)

        #region General Initializer : Class (DoubleSequenceGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCreateAnonymous, 0)]
        [TestCase(MethodCreate, 1)]
        public void AUT_DoubleSequenceGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DoubleSequenceGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldd)]
        [TestCase(FieldsyncRoot)]
        public void AUT_DoubleSequenceGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoubleSequenceGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoubleSequenceGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _doubleSequenceGeneratorInstanceType.ShouldNotBeNull();
            _doubleSequenceGeneratorInstance.ShouldNotBeNull();
            _doubleSequenceGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoubleSequenceGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoubleSequenceGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoubleSequenceGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doubleSequenceGeneratorInstance.ShouldBeAssignableTo<DoubleSequenceGenerator>();
            _doubleSequenceGeneratorInstanceFixture.ShouldBeAssignableTo<DoubleSequenceGenerator>();
            CurrentInstance.ShouldBeAssignableTo<DoubleSequenceGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoubleSequenceGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoubleSequenceGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoubleSequenceGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoubleSequenceGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);

            // Act
            Action executeAction = () => _doubleSequenceGeneratorInstance.Create();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;
            object[] parametersOfCreate = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<double>(_doubleSequenceGeneratorInstanceFixture, parametersOfCreate);
            var result2 = this.GetResultOfMethod<double>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreate.ShouldBeNull();
            methodCreateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;
            object[] parametersOfCreate = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<double>(_doubleSequenceGeneratorInstanceFixture, out exception1, parametersOfCreate);
            var result2 = this.GetResultOfMethod<double>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreate.ShouldBeNull();
            methodCreateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;
            object[] parametersOfCreate = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_doubleSequenceGeneratorInstanceFixture, parametersOfCreate);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreate.ShouldBeNull();
            methodCreateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;
            object[] parametersOfCreate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            parametersOfCreate.ShouldBeNull();
            methodCreateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            Type [] methodCreateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoubleSequenceGenerator_Create_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _doubleSequenceGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _doubleSequenceGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_doubleSequenceGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_doubleSequenceGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 1);

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
        public void AUT_DoubleSequenceGenerator_Create_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 1);
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
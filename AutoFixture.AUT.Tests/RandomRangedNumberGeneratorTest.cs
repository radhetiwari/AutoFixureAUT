namespace AutoFixture
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
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
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.RandomRangedNumberGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RandomRangedNumberGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RandomRangedNumberGenerator" />)
        /// </summary>
        public RandomRangedNumberGeneratorTest() : base(typeof(RandomRangedNumberGenerator))
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

        #region General Initializer : Class (RandomRangedNumberGenerator) Initializer

        #region General Initializer : Class (RandomRangedNumberGenerator) One time setup

        private Type _randomRangedNumberGeneratorInstanceType;
        private RandomRangedNumberGenerator _randomRangedNumberGeneratorInstance;
        private RandomRangedNumberGenerator _randomRangedNumberGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RandomRangedNumberGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _randomRangedNumberGeneratorInstanceType = typeof(RandomRangedNumberGenerator);
            _randomRangedNumberGeneratorInstanceFixture = this.Create<RandomRangedNumberGenerator>(true);
            _randomRangedNumberGeneratorInstance = _randomRangedNumberGeneratorInstanceFixture ?? this.Create<RandomRangedNumberGenerator>(false);
            CurrentInstance = _randomRangedNumberGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodSelectGenerator = "SelectGenerator";
        private const string MethodCreateRandomGenerator = "CreateRandomGenerator";

        #endregion

        #region Fields

        private const string FieldgeneratorMap = "generatorMap";

        #endregion

        #endregion

        #region General Initializer : Class (RandomRangedNumberGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomRangedNumberGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RandomRangedNumberGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomRangedNumberGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RandomRangedNumberGenerator)

        #region General Initializer : Class (RandomRangedNumberGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodSelectGenerator, 0)]
        [TestCase(MethodCreateRandomGenerator, 0)]
        public void AUT_RandomRangedNumberGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RandomRangedNumberGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldgeneratorMap)]
        public void AUT_RandomRangedNumberGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RandomRangedNumberGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomRangedNumberGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _randomRangedNumberGeneratorInstanceType.ShouldNotBeNull();
            _randomRangedNumberGeneratorInstance.ShouldNotBeNull();
            _randomRangedNumberGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RandomRangedNumberGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RandomRangedNumberGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomRangedNumberGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _randomRangedNumberGeneratorInstance.ShouldBeAssignableTo<RandomRangedNumberGenerator>();
            _randomRangedNumberGeneratorInstanceFixture.ShouldBeAssignableTo<RandomRangedNumberGenerator>();
            CurrentInstance.ShouldBeAssignableTo<RandomRangedNumberGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RandomRangedNumberGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomRangedNumberGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RandomRangedNumberGenerator instance = null;

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
        private void AUT_RandomRangedNumberGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _randomRangedNumberGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _randomRangedNumberGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_randomRangedNumberGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_randomRangedNumberGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_RandomRangedNumberGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_Internally(Type[] types)
        {
            var methodSelectGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectGenerator, methodSelectGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var request = this.CreateType<RangedNumberRequest>();
            var methodSelectGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            object[] parametersOfSelectGenerator = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodSelectGenerator, methodSelectGeneratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilder>(_randomRangedNumberGeneratorInstanceFixture, parametersOfSelectGenerator);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodSelectGenerator, parametersOfSelectGenerator, methodSelectGeneratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSelectGenerator.ShouldNotBeNull();
            parametersOfSelectGenerator.Length.ShouldBe(1);
            methodSelectGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var request = this.CreateType<RangedNumberRequest>();
            var methodSelectGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            object[] parametersOfSelectGenerator = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodSelectGenerator, parametersOfSelectGenerator, methodSelectGeneratorParametersTypes);

            // Assert
            parametersOfSelectGenerator.ShouldNotBeNull();
            parametersOfSelectGenerator.Length.ShouldBe(1);
            methodSelectGeneratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var methodSelectGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSelectGenerator, methodSelectGeneratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSelectGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var methodSelectGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSelectGenerator, methodSelectGeneratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSelectGeneratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var methodInfo = this.GetMethodInfo(MethodSelectGenerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SelectGenerator) (Return Type : ISpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_SelectGenerator_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectGenerator);
            var methodInfo = this.GetMethodInfo(MethodSelectGenerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateRandomGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var request = this.CreateType<RangedNumberRequest>();
            var methodCreateRandomGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            object[] parametersOfCreateRandomGenerator = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);
            var result2 = this.GetResultOfMethod<ISpecimenBuilder>(MethodCreateRandomGenerator, parametersOfCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_randomRangedNumberGeneratorInstanceFixture, parametersOfCreateRandomGenerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateRandomGenerator.ShouldNotBeNull();
            parametersOfCreateRandomGenerator.Length.ShouldBe(1);
            methodCreateRandomGeneratorParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var request = this.CreateType<RangedNumberRequest>();
            var methodCreateRandomGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            object[] parametersOfCreateRandomGenerator = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilder>(MethodCreateRandomGenerator, parametersOfCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);

            // Assert
            parametersOfCreateRandomGenerator.ShouldNotBeNull();
            parametersOfCreateRandomGenerator.Length.ShouldBe(1);
            methodCreateRandomGeneratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var methodCreateRandomGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateRandomGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var methodCreateRandomGeneratorParametersTypes = new Type[] { typeof(RangedNumberRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRandomGenerator, methodCreateRandomGeneratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRandomGeneratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var methodInfo = this.GetMethodInfo(MethodCreateRandomGenerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRandomGenerator) (Return Type : ISpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomRangedNumberGenerator_CreateRandomGenerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandomGenerator);
            var methodInfo = this.GetMethodInfo(MethodCreateRandomGenerator, 0);
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
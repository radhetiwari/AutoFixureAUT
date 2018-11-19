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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.RandomNumericSequenceGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RandomNumericSequenceGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RandomNumericSequenceGenerator" />)
        /// </summary>
        public RandomNumericSequenceGeneratorTest() : base(typeof(RandomNumericSequenceGenerator))
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

        #region General Initializer : Class (RandomNumericSequenceGenerator) Initializer

        #region General Initializer : Class (RandomNumericSequenceGenerator) One time setup

        private Type _randomNumericSequenceGeneratorInstanceType;
        private RandomNumericSequenceGenerator _randomNumericSequenceGeneratorInstance;
        private RandomNumericSequenceGenerator _randomNumericSequenceGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RandomNumericSequenceGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _randomNumericSequenceGeneratorInstanceType = typeof(RandomNumericSequenceGenerator);
            _randomNumericSequenceGeneratorInstanceFixture = this.Create<RandomNumericSequenceGenerator>(true);
            _randomNumericSequenceGeneratorInstance = _randomNumericSequenceGeneratorInstanceFixture ?? this.Create<RandomNumericSequenceGenerator>(false);
            CurrentInstance = _randomNumericSequenceGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyLimits = "Limits";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodValidateThatLimitsAreStrictlyAscending = "ValidateThatLimitsAreStrictlyAscending";
        private const string MethodCreateRandom = "CreateRandom";
        private const string MethodGetNextRandom = "GetNextRandom";
        private const string MethodEvaluateRange = "EvaluateRange";
        private const string MethodCreateRange = "CreateRange";
        private const string MethodGetUpperRangeFromLimits = "GetUpperRangeFromLimits";
        private const string MethodGetNextInt64InRange = "GetNextInt64InRange";

        #endregion

        #region Fields

        private const string Fieldlimits = "limits";
        private const string FieldsyncRoot = "syncRoot";
        private const string Fieldrandom = "random";
        private const string Fieldnumbers = "numbers";
        private const string Fieldlower = "lower";
        private const string Fieldupper = "upper";
        private const string Fieldcount = "count";

        #endregion

        #endregion

        #region General Initializer : Class (RandomNumericSequenceGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomNumericSequenceGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RandomNumericSequenceGenerator) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomNumericSequenceGenerator_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RandomNumericSequenceGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RandomNumericSequenceGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RandomNumericSequenceGenerator)

        #region General Initializer : Class (RandomNumericSequenceGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodValidateThatLimitsAreStrictlyAscending, 0)]
        [TestCase(MethodCreateRandom, 0)]
        [TestCase(MethodGetNextRandom, 0)]
        [TestCase(MethodEvaluateRange, 0)]
        [TestCase(MethodCreateRange, 0)]
        [TestCase(MethodGetUpperRangeFromLimits, 0)]
        [TestCase(MethodGetNextInt64InRange, 0)]
        public void AUT_RandomNumericSequenceGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RandomNumericSequenceGenerator) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyLimits)]
        public void AUT_RandomNumericSequenceGenerator_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (RandomNumericSequenceGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldlimits)]
        [TestCase(FieldsyncRoot)]
        [TestCase(Fieldrandom)]
        [TestCase(Fieldnumbers)]
        [TestCase(Fieldlower)]
        [TestCase(Fieldupper)]
        [TestCase(Fieldcount)]
        public void AUT_RandomNumericSequenceGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RandomNumericSequenceGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomNumericSequenceGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _randomNumericSequenceGeneratorInstanceType.ShouldNotBeNull();
            _randomNumericSequenceGeneratorInstance.ShouldNotBeNull();
            _randomNumericSequenceGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RandomNumericSequenceGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RandomNumericSequenceGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _randomNumericSequenceGeneratorInstance.ShouldBeAssignableTo<RandomNumericSequenceGenerator>();
            _randomNumericSequenceGeneratorInstanceFixture.ShouldBeAssignableTo<RandomNumericSequenceGenerator>();
            CurrentInstance.ShouldBeAssignableTo<RandomNumericSequenceGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RandomNumericSequenceGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RandomNumericSequenceGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) instance created

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_Is_Created_Test()
        {
            // Assert
            _randomNumericSequenceGeneratorInstance.ShouldNotBeNull();
            _randomNumericSequenceGeneratorInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="RandomNumericSequenceGenerator" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_RandomNumericSequenceGenerator_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="RandomNumericSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RandomNumericSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodRandomNumericSequenceGeneratorParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRandomNumericSequenceGeneratorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RandomNumericSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRandomNumericSequenceGeneratorParametersTypes = new Type[] { typeof(IEnumerable<long>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRandomNumericSequenceGeneratorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RandomNumericSequenceGenerator) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RandomNumericSequenceGenerator" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RandomNumericSequenceGenerator_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRandomNumericSequenceGeneratorParametersTypes = new Type[] { typeof(long[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRandomNumericSequenceGeneratorParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RandomNumericSequenceGenerator) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyLimits)]
        public void AUT_RandomNumericSequenceGenerator_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RandomNumericSequenceGenerator) => Property (Limits) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RandomNumericSequenceGenerator_Public_Class_Limits_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLimits);
            var propertyInfo = this.GetPropertyInfo(PropertyLimits);

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
        private void AUT_RandomNumericSequenceGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _randomNumericSequenceGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _randomNumericSequenceGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_randomNumericSequenceGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_RandomNumericSequenceGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_Internally(Type[] types)
        {
            var methodValidateThatLimitsAreStrictlyAscendingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateThatLimitsAreStrictlyAscending, methodValidateThatLimitsAreStrictlyAscendingParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateThatLimitsAreStrictlyAscending);
            var limits = this.CreateType<long[]>();
            var methodValidateThatLimitsAreStrictlyAscendingParametersTypes = new Type[] { typeof(long[]) };
            object[] parametersOfValidateThatLimitsAreStrictlyAscending = { limits };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodValidateThatLimitsAreStrictlyAscending, methodValidateThatLimitsAreStrictlyAscendingParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfValidateThatLimitsAreStrictlyAscending);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidateThatLimitsAreStrictlyAscending.ShouldNotBeNull();
            parametersOfValidateThatLimitsAreStrictlyAscending.Length.ShouldBe(1);
            methodValidateThatLimitsAreStrictlyAscendingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateThatLimitsAreStrictlyAscending);
            var limits = this.CreateType<long[]>();
            var methodValidateThatLimitsAreStrictlyAscendingParametersTypes = new Type[] { typeof(long[]) };
            object[] parametersOfValidateThatLimitsAreStrictlyAscending = { limits };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodValidateThatLimitsAreStrictlyAscending, parametersOfValidateThatLimitsAreStrictlyAscending, methodValidateThatLimitsAreStrictlyAscendingParametersTypes);

            // Assert
            parametersOfValidateThatLimitsAreStrictlyAscending.ShouldNotBeNull();
            parametersOfValidateThatLimitsAreStrictlyAscending.Length.ShouldBe(1);
            methodValidateThatLimitsAreStrictlyAscendingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateThatLimitsAreStrictlyAscending);
            var methodInfo = this.GetMethodInfo(MethodValidateThatLimitsAreStrictlyAscending, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateThatLimitsAreStrictlyAscending);
            var methodValidateThatLimitsAreStrictlyAscendingParametersTypes = new Type[] { typeof(long[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateThatLimitsAreStrictlyAscending, methodValidateThatLimitsAreStrictlyAscendingParametersTypes);

            // Assert
            methodValidateThatLimitsAreStrictlyAscendingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateThatLimitsAreStrictlyAscending) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_ValidateThatLimitsAreStrictlyAscending_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateThatLimitsAreStrictlyAscending);
            var methodInfo = this.GetMethodInfo(MethodValidateThatLimitsAreStrictlyAscending, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_Internally(Type[] types)
        {
            var methodCreateRandomParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRandom, methodCreateRandomParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var request = this.CreateType<Type>();
            var methodCreateRandomParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateRandom = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCreateRandom, methodCreateRandomParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_randomNumericSequenceGeneratorInstanceFixture, out exception1, parametersOfCreateRandom);
            var result2 = this.GetResultOfMethod<object>(MethodCreateRandom, parametersOfCreateRandom, methodCreateRandomParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateRandom.ShouldNotBeNull();
            parametersOfCreateRandom.Length.ShouldBe(1);
            methodCreateRandomParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var request = this.CreateType<Type>();
            var methodCreateRandomParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateRandom = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateRandom, methodCreateRandomParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfCreateRandom);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRandom.ShouldNotBeNull();
            parametersOfCreateRandom.Length.ShouldBe(1);
            methodCreateRandomParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var request = this.CreateType<Type>();
            var methodCreateRandomParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateRandom = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateRandom, parametersOfCreateRandom, methodCreateRandomParametersTypes);

            // Assert
            parametersOfCreateRandom.ShouldNotBeNull();
            parametersOfCreateRandom.Length.ShouldBe(1);
            methodCreateRandomParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var methodCreateRandomParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRandom, methodCreateRandomParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateRandomParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var methodCreateRandomParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRandom, methodCreateRandomParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRandomParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var methodInfo = this.GetMethodInfo(MethodCreateRandom, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRandom) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRandom_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRandom);
            var methodInfo = this.GetMethodInfo(MethodCreateRandom, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_Internally(Type[] types)
        {
            var methodGetNextRandomParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNextRandom, methodGetNextRandomParametersTypes);
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;
            object[] parametersOfGetNextRandom = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetNextRandom, methodGetNextRandomParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetNextRandom);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextRandom, parametersOfGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextRandom.ShouldBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;
            object[] parametersOfGetNextRandom = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetNextRandom, methodGetNextRandomParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, out exception1, parametersOfGetNextRandom);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextRandom, parametersOfGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextRandom.ShouldBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;
            object[] parametersOfGetNextRandom = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetNextRandom, methodGetNextRandomParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetNextRandom);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNextRandom.ShouldBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;
            object[] parametersOfGetNextRandom = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodGetNextRandom, parametersOfGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            parametersOfGetNextRandom.ShouldBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextRandomParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            Type [] methodGetNextRandomParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNextRandom, methodGetNextRandomParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNextRandomParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextRandom) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextRandom_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextRandom);
            var methodInfo = this.GetMethodInfo(MethodGetNextRandom, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateRange) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_EvaluateRange_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateRangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateRange, methodEvaluateRangeParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateRange) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_EvaluateRange_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateRange);
            Type [] methodEvaluateRangeParametersTypes = null;
            object[] parametersOfEvaluateRange = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEvaluateRange, methodEvaluateRangeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfEvaluateRange);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateRange.ShouldBeNull();
            methodEvaluateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateRange) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_EvaluateRange_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateRange);
            Type [] methodEvaluateRangeParametersTypes = null;
            object[] parametersOfEvaluateRange = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEvaluateRange, parametersOfEvaluateRange, methodEvaluateRangeParametersTypes);

            // Assert
            parametersOfEvaluateRange.ShouldBeNull();
            methodEvaluateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateRange) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_EvaluateRange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateRange);
            Type [] methodEvaluateRangeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateRange, methodEvaluateRangeParametersTypes);

            // Assert
            methodEvaluateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateRange) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_EvaluateRange_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateRange);
            var methodInfo = this.GetMethodInfo(MethodEvaluateRange, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRange) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_CreateRange_Method_Call_Internally(Type[] types)
        {
            var methodCreateRangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRange, methodCreateRangeParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRange) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRange_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRange);
            Type [] methodCreateRangeParametersTypes = null;
            object[] parametersOfCreateRange = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateRange, methodCreateRangeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfCreateRange);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRange.ShouldBeNull();
            methodCreateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRange) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRange_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRange);
            Type [] methodCreateRangeParametersTypes = null;
            object[] parametersOfCreateRange = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateRange, parametersOfCreateRange, methodCreateRangeParametersTypes);

            // Assert
            parametersOfCreateRange.ShouldBeNull();
            methodCreateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRange) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRange);
            Type [] methodCreateRangeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRange, methodCreateRangeParametersTypes);

            // Assert
            methodCreateRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRange) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_CreateRange_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRange);
            var methodInfo = this.GetMethodInfo(MethodCreateRange, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_Internally(Type[] types)
        {
            var methodGetUpperRangeFromLimitsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;
            object[] parametersOfGetUpperRangeFromLimits = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetUpperRangeFromLimits);
            var result2 = this.GetResultOfMethod<long>(MethodGetUpperRangeFromLimits, parametersOfGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUpperRangeFromLimits.ShouldBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;
            object[] parametersOfGetUpperRangeFromLimits = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, out exception1, parametersOfGetUpperRangeFromLimits);
            var result2 = this.GetResultOfMethod<long>(MethodGetUpperRangeFromLimits, parametersOfGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUpperRangeFromLimits.ShouldBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;
            object[] parametersOfGetUpperRangeFromLimits = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetUpperRangeFromLimits);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUpperRangeFromLimits.ShouldBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;
            object[] parametersOfGetUpperRangeFromLimits = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodGetUpperRangeFromLimits, parametersOfGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            parametersOfGetUpperRangeFromLimits.ShouldBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            Type [] methodGetUpperRangeFromLimitsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUpperRangeFromLimits, methodGetUpperRangeFromLimitsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUpperRangeFromLimitsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpperRangeFromLimits) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetUpperRangeFromLimits_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpperRangeFromLimits);
            var methodInfo = this.GetMethodInfo(MethodGetUpperRangeFromLimits, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_Internally(Type[] types)
        {
            var methodGetNextInt64InRangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;
            object[] parametersOfGetNextInt64InRange = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetNextInt64InRange);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextInt64InRange, parametersOfGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextInt64InRange.ShouldBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;
            object[] parametersOfGetNextInt64InRange = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<long>(_randomNumericSequenceGeneratorInstanceFixture, out exception1, parametersOfGetNextInt64InRange);
            var result2 = this.GetResultOfMethod<long>(MethodGetNextInt64InRange, parametersOfGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextInt64InRange.ShouldBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;
            object[] parametersOfGetNextInt64InRange = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_randomNumericSequenceGeneratorInstanceFixture, parametersOfGetNextInt64InRange);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNextInt64InRange.ShouldBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;
            object[] parametersOfGetNextInt64InRange = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodGetNextInt64InRange, parametersOfGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            parametersOfGetNextInt64InRange.ShouldBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            Type [] methodGetNextInt64InRangeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNextInt64InRange, methodGetNextInt64InRangeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNextInt64InRangeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextInt64InRange) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RandomNumericSequenceGenerator_GetNextInt64InRange_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextInt64InRange);
            var methodInfo = this.GetMethodInfo(MethodGetNextInt64InRange, 0);

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
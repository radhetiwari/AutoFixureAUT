namespace AutoFixture.NUnit3
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
    using AutoFixture.NUnit3;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.FrozenAttribute" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FrozenAttributeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FrozenAttribute" />)
        /// </summary>
        public FrozenAttributeTest() : base(typeof(FrozenAttribute))
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

        #region General Initializer : Class (FrozenAttribute) Initializer

        #region General Initializer : Class (FrozenAttribute) One time setup

        private Type _frozenAttributeInstanceType;
        private FrozenAttribute _frozenAttributeInstance;
        private FrozenAttribute _frozenAttributeInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="FrozenAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _frozenAttributeInstanceType = typeof(FrozenAttribute);
            _frozenAttributeInstanceFixture = this.Create<FrozenAttribute>(true);
            _frozenAttributeInstance = _frozenAttributeInstanceFixture ?? this.Create<FrozenAttribute>(false);
            CurrentInstance = _frozenAttributeInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBy = "By";

        #endregion

        #region Methods

        private const string MethodGetCustomization = "GetCustomization";
        private const string MethodFreezeByCriteria = "FreezeByCriteria";
        private const string MethodByEqual = "ByEqual";
        private const string MethodByExactType = "ByExactType";
        private const string MethodByBaseType = "ByBaseType";
        private const string MethodByImplementedInterfaces = "ByImplementedInterfaces";
        private const string MethodByParameterName = "ByParameterName";
        private const string MethodByPropertyName = "ByPropertyName";
        private const string MethodByFieldName = "ByFieldName";
        private const string MethodShouldMatchBy = "ShouldMatchBy";
        private const string MethodNoMatch = "NoMatch";
        private const string MethodDerivesFrom = "DerivesFrom";
        private const string MethodIsNamed = "IsNamed";

        #endregion

        #endregion

        #region General Initializer : Class (FrozenAttribute) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FrozenAttribute_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FrozenAttribute) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FrozenAttribute_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (FrozenAttribute) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_FrozenAttribute_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FrozenAttribute)

        #region General Initializer : Class (FrozenAttribute) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCustomization, 0)]
        [TestCase(MethodFreezeByCriteria, 0)]
        [TestCase(MethodByEqual, 0)]
        [TestCase(MethodByExactType, 0)]
        [TestCase(MethodByBaseType, 0)]
        [TestCase(MethodByImplementedInterfaces, 0)]
        [TestCase(MethodByParameterName, 0)]
        [TestCase(MethodByPropertyName, 0)]
        [TestCase(MethodByFieldName, 0)]
        [TestCase(MethodShouldMatchBy, 0)]
        [TestCase(MethodNoMatch, 0)]
        [TestCase(MethodDerivesFrom, 0)]
        [TestCase(MethodIsNamed, 0)]
        public void AUT_FrozenAttribute_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FrozenAttribute) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBy)]
        public void AUT_FrozenAttribute_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FrozenAttribute) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FrozenAttribute_Is_Instance_Present_Test()
        {
            // Assert
            _frozenAttributeInstanceType.ShouldNotBeNull();
            _frozenAttributeInstance.ShouldNotBeNull();
            _frozenAttributeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FrozenAttribute) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FrozenAttribute_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _frozenAttributeInstance.ShouldBeAssignableTo<FrozenAttribute>();
            _frozenAttributeInstanceFixture.ShouldBeAssignableTo<FrozenAttribute>();
            CurrentInstance.ShouldBeAssignableTo<FrozenAttribute>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FrozenAttribute) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FrozenAttribute instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var by = this.CreateType<Matching>();
            FrozenAttribute instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FrozenAttribute(by);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _frozenAttributeInstance.ShouldNotBeNull();
            _frozenAttributeInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FrozenAttribute>();
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var by = this.CreateType<Matching>();
            FrozenAttribute instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FrozenAttribute(by);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _frozenAttributeInstance.ShouldNotBeNull();
            _frozenAttributeInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) instance created

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Is_Created_Test()
        {
            // Assert
            _frozenAttributeInstance.ShouldNotBeNull();
            _frozenAttributeInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="FrozenAttribute" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_FrozenAttribute_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="FrozenAttribute" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FrozenAttribute" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodFrozenAttributeParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFrozenAttributeParametersTypes);
        }

        #endregion

        #region General Constructor : Class (FrozenAttribute) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FrozenAttribute" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FrozenAttribute_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFrozenAttributeParametersTypes = new Type[] { typeof(Matching) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFrozenAttributeParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (FrozenAttribute) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBy)]
        public void AUT_FrozenAttribute_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (FrozenAttribute) => Property (By) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FrozenAttribute_By_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBy);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBy);
            Action currentAction = () => propertyInfo.SetValue(_frozenAttributeInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (FrozenAttribute) => Property (By) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FrozenAttribute_Public_Class_By_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBy);
            var propertyInfo = this.GetPropertyInfo(PropertyBy);

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

        #region Method Call : (GetCustomization) (Return Type : ICustomization) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_GetCustomization_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomizationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomization, methodGetCustomizationParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();

            // Act
            Action executeAction = () => _frozenAttributeInstance.GetCustomization(parameter);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();
            var returnedValue = default(ICustomization);

            // Act
            Action executeAction = () => returnedValue = _frozenAttributeInstance.GetCustomization(parameter);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();
            var methodGetCustomizationParametersTypes = new Type[] { typeof(ParameterInfo) };
            object[] parametersOfGetCustomization = { parameter };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetCustomization, methodGetCustomizationParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ICustomization>(_frozenAttributeInstanceFixture, parametersOfGetCustomization);
            var result2 = this.GetResultOfMethod<ICustomization>(MethodGetCustomization, parametersOfGetCustomization, methodGetCustomizationParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCustomization.ShouldNotBeNull();
            parametersOfGetCustomization.Length.ShouldBe(1);
            methodGetCustomizationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();
            var methodGetCustomizationParametersTypes = new Type[] { typeof(ParameterInfo) };
            object[] parametersOfGetCustomization = { parameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ICustomization>(MethodGetCustomization, parametersOfGetCustomization, methodGetCustomizationParametersTypes);

            // Assert
            parametersOfGetCustomization.ShouldNotBeNull();
            parametersOfGetCustomization.Length.ShouldBe(1);
            methodGetCustomizationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var methodGetCustomizationParametersTypes = new Type[] { typeof(ParameterInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomization, methodGetCustomizationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCustomizationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var methodGetCustomizationParametersTypes = new Type[] { typeof(ParameterInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomization, methodGetCustomizationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomizationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var methodInfo = this.GetMethodInfo(MethodGetCustomization, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_GetCustomization_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var methodInfo = this.GetMethodInfo(MethodGetCustomization, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_Internally(Type[] types)
        {
            var methodFreezeByCriteriaParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFreezeByCriteria, methodFreezeByCriteriaParametersTypes);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var parameter = this.CreateType<ParameterInfo>();
            var methodFreezeByCriteriaParametersTypes = new Type[] { typeof(ParameterInfo) };
            object[] parametersOfFreezeByCriteria = { parameter };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodFreezeByCriteria, methodFreezeByCriteriaParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ICustomization>(_frozenAttributeInstanceFixture, parametersOfFreezeByCriteria);
            var result2 = this.GetResultOfMethod<ICustomization>(MethodFreezeByCriteria, parametersOfFreezeByCriteria, methodFreezeByCriteriaParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFreezeByCriteria.ShouldNotBeNull();
            parametersOfFreezeByCriteria.Length.ShouldBe(1);
            methodFreezeByCriteriaParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var parameter = this.CreateType<ParameterInfo>();
            var methodFreezeByCriteriaParametersTypes = new Type[] { typeof(ParameterInfo) };
            object[] parametersOfFreezeByCriteria = { parameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ICustomization>(MethodFreezeByCriteria, parametersOfFreezeByCriteria, methodFreezeByCriteriaParametersTypes);

            // Assert
            parametersOfFreezeByCriteria.ShouldNotBeNull();
            parametersOfFreezeByCriteria.Length.ShouldBe(1);
            methodFreezeByCriteriaParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var methodFreezeByCriteriaParametersTypes = new Type[] { typeof(ParameterInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFreezeByCriteria, methodFreezeByCriteriaParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFreezeByCriteriaParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var methodFreezeByCriteriaParametersTypes = new Type[] { typeof(ParameterInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFreezeByCriteria, methodFreezeByCriteriaParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFreezeByCriteriaParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var methodInfo = this.GetMethodInfo(MethodFreezeByCriteria, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FreezeByCriteria) (Return Type : ICustomization) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_FreezeByCriteria_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFreezeByCriteria);
            var methodInfo = this.GetMethodInfo(MethodFreezeByCriteria, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByEqual_Static_Method_Call_Internally(Type[] types)
        {
            var methodByEqualParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByEqual, methodByEqualParametersTypes);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var target = this.CreateType<object>();
            var methodByEqualParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfByEqual = { target };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByEqual, methodByEqualParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByEqual);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByEqual.ShouldNotBeNull();
            parametersOfByEqual.Length.ShouldBe(1);
            methodByEqualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var target = this.CreateType<object>();
            var methodByEqualParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfByEqual = { target };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByEqual, parametersOfByEqual, methodByEqualParametersTypes);

            // Assert
            parametersOfByEqual.ShouldNotBeNull();
            parametersOfByEqual.Length.ShouldBe(1);
            methodByEqualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var methodByEqualParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByEqual, methodByEqualParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodByEqualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var methodByEqualParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByEqual, methodByEqualParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByEqualParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var methodInfo = this.GetMethodInfo(MethodByEqual, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ByEqual) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByEqual_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByEqual);
            var methodInfo = this.GetMethodInfo(MethodByEqual, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByExactType_Method_Call_Internally(Type[] types)
        {
            var methodByExactTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByExactType, methodByExactTypeParametersTypes);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var type = this.CreateType<Type>();
            var methodByExactTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByExactType = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByExactType, methodByExactTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByExactType);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByExactType, parametersOfByExactType, methodByExactTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByExactType.ShouldNotBeNull();
            parametersOfByExactType.Length.ShouldBe(1);
            methodByExactTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var type = this.CreateType<Type>();
            var methodByExactTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByExactType = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByExactType, methodByExactTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByExactType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByExactType.ShouldNotBeNull();
            parametersOfByExactType.Length.ShouldBe(1);
            methodByExactTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var type = this.CreateType<Type>();
            var methodByExactTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByExactType = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByExactType, parametersOfByExactType, methodByExactTypeParametersTypes);

            // Assert
            parametersOfByExactType.ShouldNotBeNull();
            parametersOfByExactType.Length.ShouldBe(1);
            methodByExactTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var methodByExactTypeParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByExactType, methodByExactTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodByExactTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var methodByExactTypeParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByExactType, methodByExactTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByExactTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var methodInfo = this.GetMethodInfo(MethodByExactType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ByExactType) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByExactType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByExactType);
            var methodInfo = this.GetMethodInfo(MethodByExactType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByBaseType_Method_Call_Internally(Type[] types)
        {
            var methodByBaseTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByBaseType, methodByBaseTypeParametersTypes);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var type = this.CreateType<Type>();
            var methodByBaseTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByBaseType = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByBaseType, methodByBaseTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByBaseType);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByBaseType, parametersOfByBaseType, methodByBaseTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByBaseType.ShouldNotBeNull();
            parametersOfByBaseType.Length.ShouldBe(1);
            methodByBaseTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var type = this.CreateType<Type>();
            var methodByBaseTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByBaseType = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByBaseType, methodByBaseTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByBaseType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByBaseType.ShouldNotBeNull();
            parametersOfByBaseType.Length.ShouldBe(1);
            methodByBaseTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var type = this.CreateType<Type>();
            var methodByBaseTypeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByBaseType = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByBaseType, parametersOfByBaseType, methodByBaseTypeParametersTypes);

            // Assert
            parametersOfByBaseType.ShouldNotBeNull();
            parametersOfByBaseType.Length.ShouldBe(1);
            methodByBaseTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var methodByBaseTypeParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByBaseType, methodByBaseTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByBaseTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var methodByBaseTypeParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByBaseType, methodByBaseTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByBaseTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var methodInfo = this.GetMethodInfo(MethodByBaseType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByBaseType) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByBaseType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByBaseType);
            var methodInfo = this.GetMethodInfo(MethodByBaseType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_Internally(Type[] types)
        {
            var methodByImplementedInterfacesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByImplementedInterfaces, methodByImplementedInterfacesParametersTypes);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var type = this.CreateType<Type>();
            var methodByImplementedInterfacesParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByImplementedInterfaces = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByImplementedInterfaces, methodByImplementedInterfacesParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByImplementedInterfaces);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByImplementedInterfaces, parametersOfByImplementedInterfaces, methodByImplementedInterfacesParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByImplementedInterfaces.ShouldNotBeNull();
            parametersOfByImplementedInterfaces.Length.ShouldBe(1);
            methodByImplementedInterfacesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var type = this.CreateType<Type>();
            var methodByImplementedInterfacesParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByImplementedInterfaces = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByImplementedInterfaces, methodByImplementedInterfacesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByImplementedInterfaces);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByImplementedInterfaces.ShouldNotBeNull();
            parametersOfByImplementedInterfaces.Length.ShouldBe(1);
            methodByImplementedInterfacesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var type = this.CreateType<Type>();
            var methodByImplementedInterfacesParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfByImplementedInterfaces = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByImplementedInterfaces, parametersOfByImplementedInterfaces, methodByImplementedInterfacesParametersTypes);

            // Assert
            parametersOfByImplementedInterfaces.ShouldNotBeNull();
            parametersOfByImplementedInterfaces.Length.ShouldBe(1);
            methodByImplementedInterfacesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var methodByImplementedInterfacesParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByImplementedInterfaces, methodByImplementedInterfacesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByImplementedInterfacesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var methodByImplementedInterfacesParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByImplementedInterfaces, methodByImplementedInterfacesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByImplementedInterfacesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var methodInfo = this.GetMethodInfo(MethodByImplementedInterfaces, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByImplementedInterfaces) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByImplementedInterfaces_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByImplementedInterfaces);
            var methodInfo = this.GetMethodInfo(MethodByImplementedInterfaces, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByParameterName_Method_Call_Internally(Type[] types)
        {
            var methodByParameterNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByParameterName, methodByParameterNameParametersTypes);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByParameterNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByParameterName = { type, name };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByParameterName, methodByParameterNameParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByParameterName);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByParameterName, parametersOfByParameterName, methodByParameterNameParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByParameterName.ShouldNotBeNull();
            parametersOfByParameterName.Length.ShouldBe(2);
            methodByParameterNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByParameterNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByParameterName = { type, name };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByParameterName, methodByParameterNameParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByParameterName);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByParameterName.ShouldNotBeNull();
            parametersOfByParameterName.Length.ShouldBe(2);
            methodByParameterNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByParameterNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByParameterName = { type, name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByParameterName, parametersOfByParameterName, methodByParameterNameParametersTypes);

            // Assert
            parametersOfByParameterName.ShouldNotBeNull();
            parametersOfByParameterName.Length.ShouldBe(2);
            methodByParameterNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var methodByParameterNameParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByParameterName, methodByParameterNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByParameterNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var methodByParameterNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByParameterName, methodByParameterNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByParameterNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var methodInfo = this.GetMethodInfo(MethodByParameterName, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByParameterName) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByParameterName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByParameterName);
            var methodInfo = this.GetMethodInfo(MethodByParameterName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByPropertyName_Method_Call_Internally(Type[] types)
        {
            var methodByPropertyNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByPropertyName, methodByPropertyNameParametersTypes);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByPropertyNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByPropertyName = { type, name };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByPropertyName, methodByPropertyNameParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByPropertyName);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByPropertyName, parametersOfByPropertyName, methodByPropertyNameParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByPropertyName.ShouldNotBeNull();
            parametersOfByPropertyName.Length.ShouldBe(2);
            methodByPropertyNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByPropertyNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByPropertyName = { type, name };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByPropertyName, methodByPropertyNameParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByPropertyName);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByPropertyName.ShouldNotBeNull();
            parametersOfByPropertyName.Length.ShouldBe(2);
            methodByPropertyNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByPropertyNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByPropertyName = { type, name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByPropertyName, parametersOfByPropertyName, methodByPropertyNameParametersTypes);

            // Assert
            parametersOfByPropertyName.ShouldNotBeNull();
            parametersOfByPropertyName.Length.ShouldBe(2);
            methodByPropertyNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var methodByPropertyNameParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByPropertyName, methodByPropertyNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByPropertyNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var methodByPropertyNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByPropertyName, methodByPropertyNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByPropertyNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var methodInfo = this.GetMethodInfo(MethodByPropertyName, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByPropertyName) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByPropertyName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByPropertyName);
            var methodInfo = this.GetMethodInfo(MethodByPropertyName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ByFieldName_Method_Call_Internally(Type[] types)
        {
            var methodByFieldNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByFieldName, methodByFieldNameParametersTypes);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByFieldNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByFieldName = { type, name };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodByFieldName, methodByFieldNameParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IRequestSpecification>(_frozenAttributeInstanceFixture, out exception1, parametersOfByFieldName);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodByFieldName, parametersOfByFieldName, methodByFieldNameParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByFieldName.ShouldNotBeNull();
            parametersOfByFieldName.Length.ShouldBe(2);
            methodByFieldNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByFieldNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByFieldName = { type, name };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodByFieldName, methodByFieldNameParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfByFieldName);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByFieldName.ShouldNotBeNull();
            parametersOfByFieldName.Length.ShouldBe(2);
            methodByFieldNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var type = this.CreateType<Type>();
            var name = this.CreateType<string>();
            var methodByFieldNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfByFieldName = { type, name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodByFieldName, parametersOfByFieldName, methodByFieldNameParametersTypes);

            // Assert
            parametersOfByFieldName.ShouldNotBeNull();
            parametersOfByFieldName.Length.ShouldBe(2);
            methodByFieldNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var methodByFieldNameParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByFieldName, methodByFieldNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByFieldNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var methodByFieldNameParametersTypes = new Type[] { typeof(Type), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByFieldName, methodByFieldNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByFieldNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var methodInfo = this.GetMethodInfo(MethodByFieldName, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByFieldName) (Return Type : IRequestSpecification) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ByFieldName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByFieldName);
            var methodInfo = this.GetMethodInfo(MethodByFieldName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Internally(Type[] types)
        {
            var methodShouldMatchByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodShouldMatchBy, methodShouldMatchByParametersTypes);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var criteria = this.CreateType<Matching>();
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };
            object[] parametersOfShouldMatchBy = { criteria };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodShouldMatchBy, methodShouldMatchByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_frozenAttributeInstanceFixture, parametersOfShouldMatchBy);
            var result2 = this.GetResultOfMethod<bool>(MethodShouldMatchBy, parametersOfShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfShouldMatchBy.ShouldNotBeNull();
            parametersOfShouldMatchBy.Length.ShouldBe(1);
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var criteria = this.CreateType<Matching>();
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };
            object[] parametersOfShouldMatchBy = { criteria };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodShouldMatchBy, methodShouldMatchByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_frozenAttributeInstanceFixture, out exception1, parametersOfShouldMatchBy);
            var result2 = this.GetResultOfMethod<bool>(MethodShouldMatchBy, parametersOfShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfShouldMatchBy.ShouldNotBeNull();
            parametersOfShouldMatchBy.Length.ShouldBe(1);
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var criteria = this.CreateType<Matching>();
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };
            object[] parametersOfShouldMatchBy = { criteria };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodShouldMatchBy, methodShouldMatchByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfShouldMatchBy);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfShouldMatchBy.ShouldNotBeNull();
            parametersOfShouldMatchBy.Length.ShouldBe(1);
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var criteria = this.CreateType<Matching>();
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };
            object[] parametersOfShouldMatchBy = { criteria };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodShouldMatchBy, parametersOfShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            parametersOfShouldMatchBy.ShouldNotBeNull();
            parametersOfShouldMatchBy.Length.ShouldBe(1);
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodShouldMatchByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var methodShouldMatchByParametersTypes = new Type[] { typeof(Matching) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodShouldMatchBy, methodShouldMatchByParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodShouldMatchByParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var methodInfo = this.GetMethodInfo(MethodShouldMatchBy, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ShouldMatchBy) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_ShouldMatchBy_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldMatchBy);
            var methodInfo = this.GetMethodInfo(MethodShouldMatchBy, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_NoMatch_Static_Method_Call_Internally(Type[] types)
        {
            var methodNoMatchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNoMatch, methodNoMatchParametersTypes);
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            Type [] methodNoMatchParametersTypes = null;
            object[] parametersOfNoMatch = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodNoMatch, methodNoMatchParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodNoMatch, methodNoMatchParametersTypes);
            var result2 = this.GetResultOfMethod<IRequestSpecification>(MethodNoMatch, parametersOfNoMatch, methodNoMatchParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNoMatch.ShouldBeNull();
            methodNoMatchParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<IRequestSpecification>(MethodNoMatch, parametersOfNoMatch, methodNoMatchParametersTypes));
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            Type [] methodNoMatchParametersTypes = null;
            object[] parametersOfNoMatch = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodNoMatch, methodNoMatchParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfNoMatch);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfNoMatch.ShouldBeNull();
            methodNoMatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            Type [] methodNoMatchParametersTypes = null;
            object[] parametersOfNoMatch = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IRequestSpecification>(MethodNoMatch, parametersOfNoMatch, methodNoMatchParametersTypes);

            // Assert
            parametersOfNoMatch.ShouldBeNull();
            methodNoMatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            Type [] methodNoMatchParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodNoMatch, methodNoMatchParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodNoMatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            Type [] methodNoMatchParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodNoMatch, methodNoMatchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodNoMatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (NoMatch) (Return Type : IRequestSpecification) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_NoMatch_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNoMatch);
            var methodInfo = this.GetMethodInfo(MethodNoMatch, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_Internally(Type[] types)
        {
            var methodDerivesFromParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDerivesFrom, methodDerivesFromParametersTypes);
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var type = this.CreateType<Type>();
            var methodDerivesFromParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfDerivesFrom = { type };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodDerivesFrom, methodDerivesFromParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDerivesFrom, methodDerivesFromParametersTypes);
            var result2 = this.GetResultOfMethod<Criterion<Type>>(MethodDerivesFrom, parametersOfDerivesFrom, methodDerivesFromParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDerivesFrom.ShouldNotBeNull();
            parametersOfDerivesFrom.Length.ShouldBe(1);
            methodDerivesFromParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Criterion<Type>>(MethodDerivesFrom, parametersOfDerivesFrom, methodDerivesFromParametersTypes));
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var type = this.CreateType<Type>();
            var methodDerivesFromParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfDerivesFrom = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodDerivesFrom, methodDerivesFromParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfDerivesFrom);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDerivesFrom.ShouldNotBeNull();
            parametersOfDerivesFrom.Length.ShouldBe(1);
            methodDerivesFromParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var type = this.CreateType<Type>();
            var methodDerivesFromParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfDerivesFrom = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Criterion<Type>>(MethodDerivesFrom, parametersOfDerivesFrom, methodDerivesFromParametersTypes);

            // Assert
            parametersOfDerivesFrom.ShouldNotBeNull();
            parametersOfDerivesFrom.Length.ShouldBe(1);
            methodDerivesFromParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var methodDerivesFromParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDerivesFrom, methodDerivesFromParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDerivesFromParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var methodDerivesFromParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDerivesFrom, methodDerivesFromParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDerivesFromParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var methodInfo = this.GetMethodInfo(MethodDerivesFrom, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DerivesFrom) (Return Type : Criterion<Type>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_DerivesFrom_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDerivesFrom);
            var methodInfo = this.GetMethodInfo(MethodDerivesFrom, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FrozenAttribute_IsNamed_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsNamedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsNamed, methodIsNamedParametersTypes);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var name = this.CreateType<string>();
            var methodIsNamedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsNamed = { name };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsNamed, methodIsNamedParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsNamed, methodIsNamedParametersTypes);
            var result2 = this.GetResultOfMethod<Criterion<string>>(MethodIsNamed, parametersOfIsNamed, methodIsNamedParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsNamed.ShouldNotBeNull();
            parametersOfIsNamed.Length.ShouldBe(1);
            methodIsNamedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Criterion<string>>(MethodIsNamed, parametersOfIsNamed, methodIsNamedParametersTypes));
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var name = this.CreateType<string>();
            var methodIsNamedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsNamed = { name };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsNamed, methodIsNamedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_frozenAttributeInstanceFixture, parametersOfIsNamed);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsNamed.ShouldNotBeNull();
            parametersOfIsNamed.Length.ShouldBe(1);
            methodIsNamedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var name = this.CreateType<string>();
            var methodIsNamedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsNamed = { name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Criterion<string>>(MethodIsNamed, parametersOfIsNamed, methodIsNamedParametersTypes);

            // Assert
            parametersOfIsNamed.ShouldNotBeNull();
            parametersOfIsNamed.Length.ShouldBe(1);
            methodIsNamedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var methodIsNamedParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsNamed, methodIsNamedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsNamedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var methodIsNamedParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsNamed, methodIsNamedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsNamedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var methodInfo = this.GetMethodInfo(MethodIsNamed, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsNamed) (Return Type : Criterion<string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FrozenAttribute_IsNamed_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsNamed);
            var methodInfo = this.GetMethodInfo(MethodIsNamed, 0);
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
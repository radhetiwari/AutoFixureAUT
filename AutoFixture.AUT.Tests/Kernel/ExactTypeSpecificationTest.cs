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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.ExactTypeSpecification" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExactTypeSpecificationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExactTypeSpecification" />)
        /// </summary>
        public ExactTypeSpecificationTest() : base(typeof(ExactTypeSpecification))
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

        #region General Initializer : Class (ExactTypeSpecification) Initializer

        #region General Initializer : Class (ExactTypeSpecification) One time setup

        private Type _exactTypeSpecificationInstanceType;
        private ExactTypeSpecification _exactTypeSpecificationInstance;
        private ExactTypeSpecification _exactTypeSpecificationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ExactTypeSpecification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _exactTypeSpecificationInstanceType = typeof(ExactTypeSpecification);
            _exactTypeSpecificationInstanceFixture = this.Create<ExactTypeSpecification>(true);
            _exactTypeSpecificationInstance = _exactTypeSpecificationInstanceFixture ?? this.Create<ExactTypeSpecification>(false);
            CurrentInstance = _exactTypeSpecificationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTargetType = "TargetType";

        #endregion

        #region Methods

        private const string MethodIsSatisfiedBy = "IsSatisfiedBy";
        private const string MethodIsOpenGenericDefinitionEqual = "IsOpenGenericDefinitionEqual";

        #endregion

        #endregion

        #region General Initializer : Class (ExactTypeSpecification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ExactTypeSpecification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ExactTypeSpecification) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ExactTypeSpecification_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ExactTypeSpecification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ExactTypeSpecification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExactTypeSpecification)

        #region General Initializer : Class (ExactTypeSpecification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIsSatisfiedBy, 0)]
        [TestCase(MethodIsOpenGenericDefinitionEqual, 0)]
        public void AUT_ExactTypeSpecification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ExactTypeSpecification) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTargetType)]
        public void AUT_ExactTypeSpecification_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ExactTypeSpecification) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExactTypeSpecification_Is_Instance_Present_Test()
        {
            // Assert
            _exactTypeSpecificationInstanceType.ShouldNotBeNull();
            _exactTypeSpecificationInstance.ShouldNotBeNull();
            _exactTypeSpecificationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExactTypeSpecification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExactTypeSpecification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExactTypeSpecification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _exactTypeSpecificationInstance.ShouldBeAssignableTo<ExactTypeSpecification>();
            _exactTypeSpecificationInstanceFixture.ShouldBeAssignableTo<ExactTypeSpecification>();
            CurrentInstance.ShouldBeAssignableTo<ExactTypeSpecification>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExactTypeSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExactTypeSpecification_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var type = this.CreateType<Type>();
            ExactTypeSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ExactTypeSpecification(type);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _exactTypeSpecificationInstance.ShouldNotBeNull();
            _exactTypeSpecificationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ExactTypeSpecification>();
        }

        #endregion

        #region General Constructor : Class (ExactTypeSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExactTypeSpecification_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var type = this.CreateType<Type>();
            ExactTypeSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ExactTypeSpecification(type);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _exactTypeSpecificationInstance.ShouldNotBeNull();
            _exactTypeSpecificationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ExactTypeSpecification) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTargetType)]
        public void AUT_ExactTypeSpecification_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ExactTypeSpecification) => Property (TargetType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExactTypeSpecification_TargetType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);
            Action currentAction = () => propertyInfo.SetValue(_exactTypeSpecificationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ExactTypeSpecification) => Property (TargetType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExactTypeSpecification_Public_Class_TargetType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);

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

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_Internally(Type[] types)
        {
            var methodIsSatisfiedByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _exactTypeSpecificationInstance.IsSatisfiedBy(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_exactTypeSpecificationInstanceFixture, parametersOfIsSatisfiedBy);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_exactTypeSpecificationInstanceFixture, out exception1, parametersOfIsSatisfiedBy);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_exactTypeSpecificationInstanceFixture, parametersOfIsSatisfiedBy);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsSatisfiedBy_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Internally(Type[] types)
        {
            var methodIsOpenGenericDefinitionEqualParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var request = this.CreateType<Type>();
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsOpenGenericDefinitionEqual = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_exactTypeSpecificationInstanceFixture, parametersOfIsOpenGenericDefinitionEqual);
            var result2 = this.GetResultOfMethod<bool>(MethodIsOpenGenericDefinitionEqual, parametersOfIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.Length.ShouldBe(1);
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var request = this.CreateType<Type>();
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsOpenGenericDefinitionEqual = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_exactTypeSpecificationInstanceFixture, out exception1, parametersOfIsOpenGenericDefinitionEqual);
            var result2 = this.GetResultOfMethod<bool>(MethodIsOpenGenericDefinitionEqual, parametersOfIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.Length.ShouldBe(1);
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var request = this.CreateType<Type>();
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsOpenGenericDefinitionEqual = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_exactTypeSpecificationInstanceFixture, parametersOfIsOpenGenericDefinitionEqual);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsOpenGenericDefinitionEqual.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.Length.ShouldBe(1);
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var request = this.CreateType<Type>();
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsOpenGenericDefinitionEqual = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsOpenGenericDefinitionEqual, parametersOfIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            parametersOfIsOpenGenericDefinitionEqual.ShouldNotBeNull();
            parametersOfIsOpenGenericDefinitionEqual.Length.ShouldBe(1);
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var methodIsOpenGenericDefinitionEqualParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsOpenGenericDefinitionEqual, methodIsOpenGenericDefinitionEqualParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsOpenGenericDefinitionEqualParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var methodInfo = this.GetMethodInfo(MethodIsOpenGenericDefinitionEqual, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsOpenGenericDefinitionEqual) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExactTypeSpecification_IsOpenGenericDefinitionEqual_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOpenGenericDefinitionEqual);
            var methodInfo = this.GetMethodInfo(MethodIsOpenGenericDefinitionEqual, 0);
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
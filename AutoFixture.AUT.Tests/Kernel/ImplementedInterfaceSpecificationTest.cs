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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.ImplementedInterfaceSpecification" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ImplementedInterfaceSpecificationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ImplementedInterfaceSpecification" />)
        /// </summary>
        public ImplementedInterfaceSpecificationTest() : base(typeof(ImplementedInterfaceSpecification))
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

        #region General Initializer : Class (ImplementedInterfaceSpecification) Initializer

        #region General Initializer : Class (ImplementedInterfaceSpecification) One time setup

        private Type _implementedInterfaceSpecificationInstanceType;
        private ImplementedInterfaceSpecification _implementedInterfaceSpecificationInstance;
        private ImplementedInterfaceSpecification _implementedInterfaceSpecificationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ImplementedInterfaceSpecification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _implementedInterfaceSpecificationInstanceType = typeof(ImplementedInterfaceSpecification);
            _implementedInterfaceSpecificationInstanceFixture = this.Create<ImplementedInterfaceSpecification>(true);
            _implementedInterfaceSpecificationInstance = _implementedInterfaceSpecificationInstanceFixture ?? this.Create<ImplementedInterfaceSpecification>(false);
            CurrentInstance = _implementedInterfaceSpecificationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTargetType = "TargetType";

        #endregion

        #region Methods

        private const string MethodIsSatisfiedBy = "IsSatisfiedBy";
        private const string MethodIsRequestForType = "IsRequestForType";
        private const string MethodIsTargetTypeOrImplementedInterface = "IsTargetTypeOrImplementedInterface";
        private const string MethodIsSameAsTargetType = "IsSameAsTargetType";
        private const string MethodIsInterfaceImplementedByTargetType = "IsInterfaceImplementedByTargetType";

        #endregion

        #endregion

        #region General Initializer : Class (ImplementedInterfaceSpecification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ImplementedInterfaceSpecification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ImplementedInterfaceSpecification) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ImplementedInterfaceSpecification_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ImplementedInterfaceSpecification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ImplementedInterfaceSpecification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ImplementedInterfaceSpecification)

        #region General Initializer : Class (ImplementedInterfaceSpecification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIsSatisfiedBy, 0)]
        [TestCase(MethodIsRequestForType, 0)]
        [TestCase(MethodIsTargetTypeOrImplementedInterface, 0)]
        [TestCase(MethodIsSameAsTargetType, 0)]
        [TestCase(MethodIsInterfaceImplementedByTargetType, 0)]
        public void AUT_ImplementedInterfaceSpecification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ImplementedInterfaceSpecification) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTargetType)]
        public void AUT_ImplementedInterfaceSpecification_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ImplementedInterfaceSpecification) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ImplementedInterfaceSpecification_Is_Instance_Present_Test()
        {
            // Assert
            _implementedInterfaceSpecificationInstanceType.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstance.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ImplementedInterfaceSpecification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ImplementedInterfaceSpecification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ImplementedInterfaceSpecification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _implementedInterfaceSpecificationInstance.ShouldBeAssignableTo<ImplementedInterfaceSpecification>();
            _implementedInterfaceSpecificationInstanceFixture.ShouldBeAssignableTo<ImplementedInterfaceSpecification>();
            CurrentInstance.ShouldBeAssignableTo<ImplementedInterfaceSpecification>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ImplementedInterfaceSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ImplementedInterfaceSpecification_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            ImplementedInterfaceSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ImplementedInterfaceSpecification(targetType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstance.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ImplementedInterfaceSpecification>();
        }

        #endregion

        #region General Constructor : Class (ImplementedInterfaceSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ImplementedInterfaceSpecification_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            ImplementedInterfaceSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ImplementedInterfaceSpecification(targetType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstance.ShouldNotBeNull();
            _implementedInterfaceSpecificationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ImplementedInterfaceSpecification) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTargetType)]
        public void AUT_ImplementedInterfaceSpecification_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ImplementedInterfaceSpecification) => Property (TargetType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ImplementedInterfaceSpecification_TargetType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);
            Action currentAction = () => propertyInfo.SetValue(_implementedInterfaceSpecificationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ImplementedInterfaceSpecification) => Property (TargetType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ImplementedInterfaceSpecification_Public_Class_TargetType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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
        private void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_Internally(Type[] types)
        {
            var methodIsSatisfiedByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _implementedInterfaceSpecificationInstance.IsSatisfiedBy(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsSatisfiedBy);
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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, out exception1, parametersOfIsSatisfiedBy);
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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsSatisfiedBy);

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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_ImplementedInterfaceSpecification_IsSatisfiedBy_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (IsRequestForType) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsRequestForTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsRequestForType, methodIsRequestForTypeParametersTypes);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var request = this.CreateType<object>();
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsRequestForType = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsRequestForType, methodIsRequestForTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsRequestForType, methodIsRequestForTypeParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsRequestForType, parametersOfIsRequestForType, methodIsRequestForTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsRequestForType.ShouldNotBeNull();
            parametersOfIsRequestForType.Length.ShouldBe(1);
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsRequestForType, parametersOfIsRequestForType, methodIsRequestForTypeParametersTypes));
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var request = this.CreateType<object>();
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsRequestForType = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsRequestForType, methodIsRequestForTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsRequestForType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsRequestForType.ShouldNotBeNull();
            parametersOfIsRequestForType.Length.ShouldBe(1);
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var request = this.CreateType<object>();
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsRequestForType = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsRequestForType, parametersOfIsRequestForType, methodIsRequestForTypeParametersTypes);

            // Assert
            parametersOfIsRequestForType.ShouldNotBeNull();
            parametersOfIsRequestForType.Length.ShouldBe(1);
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsRequestForType, methodIsRequestForTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsRequestForType, methodIsRequestForTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var methodIsRequestForTypeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsRequestForType, methodIsRequestForTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsRequestForTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var methodInfo = this.GetMethodInfo(MethodIsRequestForType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsRequestForType) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsRequestForType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRequestForType);
            var methodInfo = this.GetMethodInfo(MethodIsRequestForType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Internally(Type[] types)
        {
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var request = this.CreateType<object>();
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsTargetTypeOrImplementedInterface = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsTargetTypeOrImplementedInterface);
            var result2 = this.GetResultOfMethod<bool>(MethodIsTargetTypeOrImplementedInterface, parametersOfIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsTargetTypeOrImplementedInterface.ShouldNotBeNull();
            parametersOfIsTargetTypeOrImplementedInterface.Length.ShouldBe(1);
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var request = this.CreateType<object>();
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsTargetTypeOrImplementedInterface = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, out exception1, parametersOfIsTargetTypeOrImplementedInterface);
            var result2 = this.GetResultOfMethod<bool>(MethodIsTargetTypeOrImplementedInterface, parametersOfIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsTargetTypeOrImplementedInterface.ShouldNotBeNull();
            parametersOfIsTargetTypeOrImplementedInterface.Length.ShouldBe(1);
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var request = this.CreateType<object>();
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsTargetTypeOrImplementedInterface = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsTargetTypeOrImplementedInterface, parametersOfIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            parametersOfIsTargetTypeOrImplementedInterface.ShouldNotBeNull();
            parametersOfIsTargetTypeOrImplementedInterface.Length.ShouldBe(1);
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var methodIsTargetTypeOrImplementedInterfaceParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsTargetTypeOrImplementedInterface, methodIsTargetTypeOrImplementedInterfaceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsTargetTypeOrImplementedInterfaceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var methodInfo = this.GetMethodInfo(MethodIsTargetTypeOrImplementedInterface, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsTargetTypeOrImplementedInterface) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsTargetTypeOrImplementedInterface_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTargetTypeOrImplementedInterface);
            var methodInfo = this.GetMethodInfo(MethodIsTargetTypeOrImplementedInterface, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Internally(Type[] types)
        {
            var methodIsSameAsTargetTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var request = this.CreateType<object>();
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSameAsTargetType = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsSameAsTargetType);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSameAsTargetType, parametersOfIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSameAsTargetType.ShouldNotBeNull();
            parametersOfIsSameAsTargetType.Length.ShouldBe(1);
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var request = this.CreateType<object>();
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSameAsTargetType = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, out exception1, parametersOfIsSameAsTargetType);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSameAsTargetType, parametersOfIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSameAsTargetType.ShouldNotBeNull();
            parametersOfIsSameAsTargetType.Length.ShouldBe(1);
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var request = this.CreateType<object>();
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSameAsTargetType = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsSameAsTargetType, parametersOfIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            parametersOfIsSameAsTargetType.ShouldNotBeNull();
            parametersOfIsSameAsTargetType.Length.ShouldBe(1);
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var methodIsSameAsTargetTypeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsSameAsTargetType, methodIsSameAsTargetTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsSameAsTargetTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var methodInfo = this.GetMethodInfo(MethodIsSameAsTargetType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsSameAsTargetType) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsSameAsTargetType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSameAsTargetType);
            var methodInfo = this.GetMethodInfo(MethodIsSameAsTargetType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Internally(Type[] types)
        {
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var request = this.CreateType<object>();
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsInterfaceImplementedByTargetType = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, parametersOfIsInterfaceImplementedByTargetType);
            var result2 = this.GetResultOfMethod<bool>(MethodIsInterfaceImplementedByTargetType, parametersOfIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsInterfaceImplementedByTargetType.ShouldNotBeNull();
            parametersOfIsInterfaceImplementedByTargetType.Length.ShouldBe(1);
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var request = this.CreateType<object>();
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsInterfaceImplementedByTargetType = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_implementedInterfaceSpecificationInstanceFixture, out exception1, parametersOfIsInterfaceImplementedByTargetType);
            var result2 = this.GetResultOfMethod<bool>(MethodIsInterfaceImplementedByTargetType, parametersOfIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsInterfaceImplementedByTargetType.ShouldNotBeNull();
            parametersOfIsInterfaceImplementedByTargetType.Length.ShouldBe(1);
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var request = this.CreateType<object>();
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsInterfaceImplementedByTargetType = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsInterfaceImplementedByTargetType, parametersOfIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            parametersOfIsInterfaceImplementedByTargetType.ShouldNotBeNull();
            parametersOfIsInterfaceImplementedByTargetType.Length.ShouldBe(1);
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var methodIsInterfaceImplementedByTargetTypeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsInterfaceImplementedByTargetType, methodIsInterfaceImplementedByTargetTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsInterfaceImplementedByTargetTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var methodInfo = this.GetMethodInfo(MethodIsInterfaceImplementedByTargetType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsInterfaceImplementedByTargetType) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImplementedInterfaceSpecification_IsInterfaceImplementedByTargetType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsInterfaceImplementedByTargetType);
            var methodInfo = this.GetMethodInfo(MethodIsInterfaceImplementedByTargetType, 0);
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
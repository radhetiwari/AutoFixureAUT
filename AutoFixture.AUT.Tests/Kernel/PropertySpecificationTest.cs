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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.PropertySpecification" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PropertySpecificationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PropertySpecification" />)
        /// </summary>
        public PropertySpecificationTest() : base(typeof(PropertySpecification))
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

        #region General Initializer : Class (PropertySpecification) Initializer

        #region General Initializer : Class (PropertySpecification) One time setup

        private Type _propertySpecificationInstanceType;
        private PropertySpecification _propertySpecificationInstance;
        private PropertySpecification _propertySpecificationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="PropertySpecification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _propertySpecificationInstanceType = typeof(PropertySpecification);
            _propertySpecificationInstanceFixture = this.Create<PropertySpecification>(true);
            _propertySpecificationInstance = _propertySpecificationInstanceFixture ?? this.Create<PropertySpecification>(false);
            CurrentInstance = _propertySpecificationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTargetType = "TargetType";
        private const string PropertyTargetName = "TargetName";

        #endregion

        #region Methods

        private const string MethodCreateDefaultTarget = "CreateDefaultTarget";
        private const string MethodIsSatisfiedBy = "IsSatisfiedBy";

        #endregion

        #region Fields

        private const string FieldtargetType = "targetType";
        private const string FieldtargetName = "targetName";
        private const string Fieldtarget = "target";

        #endregion

        #endregion

        #region General Initializer : Class (PropertySpecification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_PropertySpecification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PropertySpecification) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_PropertySpecification_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PropertySpecification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_PropertySpecification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PropertySpecification)

        #region General Initializer : Class (PropertySpecification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateDefaultTarget, 0)]
        [TestCase(MethodIsSatisfiedBy, 0)]
        public void AUT_PropertySpecification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PropertySpecification) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyTargetName)]
        public void AUT_PropertySpecification_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (PropertySpecification) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldtargetType)]
        [TestCase(FieldtargetName)]
        [TestCase(Fieldtarget)]
        public void AUT_PropertySpecification_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PropertySpecification) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PropertySpecification_Is_Instance_Present_Test()
        {
            // Assert
            _propertySpecificationInstanceType.ShouldNotBeNull();
            _propertySpecificationInstance.ShouldNotBeNull();
            _propertySpecificationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PropertySpecification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PropertySpecification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _propertySpecificationInstance.ShouldBeAssignableTo<PropertySpecification>();
            _propertySpecificationInstanceFixture.ShouldBeAssignableTo<PropertySpecification>();
            CurrentInstance.ShouldBeAssignableTo<PropertySpecification>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PropertySpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            var targetName = this.CreateType<string>();
            PropertySpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new PropertySpecification(targetType, targetName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _propertySpecificationInstance.ShouldNotBeNull();
            _propertySpecificationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<PropertySpecification>();
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var targetType = this.CreateType<Type>();
            var targetName = this.CreateType<string>();
            PropertySpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new PropertySpecification(targetType, targetName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _propertySpecificationInstance.ShouldNotBeNull();
            _propertySpecificationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) instance created

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_Is_Created_Test()
        {
            // Assert
            _propertySpecificationInstance.ShouldNotBeNull();
            _propertySpecificationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="PropertySpecification" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_PropertySpecification_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="PropertySpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PropertySpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPropertySpecificationParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPropertySpecificationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PropertySpecification) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PropertySpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PropertySpecification_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPropertySpecificationParametersTypes = new Type[] { typeof(IEquatable<PropertyInfo>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPropertySpecificationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PropertySpecification) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTargetType)]
        [TestCase(PropertyTargetName)]
        public void AUT_PropertySpecification_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (PropertySpecification) => Property (TargetName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PropertySpecification_Public_Class_TargetName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetName);
            var propertyInfo = this.GetPropertyInfo(PropertyTargetName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PropertySpecification) => Property (TargetType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PropertySpecification_TargetType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTargetType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTargetType);
            Action currentAction = () => propertyInfo.SetValue(_propertySpecificationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (PropertySpecification) => Property (TargetType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PropertySpecification_Public_Class_TargetType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateDefaultTargetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateDefaultTarget, methodCreateDefaultTargetParametersTypes);
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var targetType = this.CreateType<Type>();
            var targetName = this.CreateType<string>();
            var methodCreateDefaultTargetParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfCreateDefaultTarget = { targetType, targetName };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateDefaultTarget, methodCreateDefaultTargetParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_propertySpecificationInstanceFixture, parametersOfCreateDefaultTarget);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateDefaultTarget.ShouldNotBeNull();
            parametersOfCreateDefaultTarget.Length.ShouldBe(2);
            methodCreateDefaultTargetParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var targetType = this.CreateType<Type>();
            var targetName = this.CreateType<string>();
            var methodCreateDefaultTargetParametersTypes = new Type[] { typeof(Type), typeof(string) };
            object[] parametersOfCreateDefaultTarget = { targetType, targetName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEquatable<PropertyInfo>>(MethodCreateDefaultTarget, parametersOfCreateDefaultTarget, methodCreateDefaultTargetParametersTypes);

            // Assert
            parametersOfCreateDefaultTarget.ShouldNotBeNull();
            parametersOfCreateDefaultTarget.Length.ShouldBe(2);
            methodCreateDefaultTargetParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var methodCreateDefaultTargetParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateDefaultTarget, methodCreateDefaultTargetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateDefaultTargetParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var methodCreateDefaultTargetParametersTypes = new Type[] { typeof(Type), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateDefaultTarget, methodCreateDefaultTargetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateDefaultTargetParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var methodInfo = this.GetMethodInfo(MethodCreateDefaultTarget, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateDefaultTarget) (Return Type : IEquatable<PropertyInfo>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_CreateDefaultTarget_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultTarget);
            var methodInfo = this.GetMethodInfo(MethodCreateDefaultTarget, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_Internally(Type[] types)
        {
            var methodIsSatisfiedByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _propertySpecificationInstance.IsSatisfiedBy(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_propertySpecificationInstanceFixture, parametersOfIsSatisfiedBy);
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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_propertySpecificationInstanceFixture, out exception1, parametersOfIsSatisfiedBy);
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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_propertySpecificationInstanceFixture, parametersOfIsSatisfiedBy);

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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_PropertySpecification_IsSatisfiedBy_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}
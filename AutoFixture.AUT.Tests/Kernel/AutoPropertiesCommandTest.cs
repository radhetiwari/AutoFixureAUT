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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.AutoPropertiesCommand<dynamic>" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AutoPropertiesCommandTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AutoPropertiesCommand<dynamic>" />)
        /// </summary>
        public AutoPropertiesCommandTest() : base(typeof(AutoPropertiesCommand<dynamic>))
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

        #region General Initializer : Class (AutoPropertiesCommand) Initializer

        #region General Initializer : Class (AutoPropertiesCommand) One time setup

        private Type _autoPropertiesCommandInstanceType;
        private AutoPropertiesCommand<dynamic> _autoPropertiesCommandInstance;
        private AutoPropertiesCommand<dynamic> _autoPropertiesCommandInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="AutoPropertiesCommand<dynamic>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _autoPropertiesCommandInstanceType = typeof(AutoPropertiesCommand<dynamic>);
            _autoPropertiesCommandInstanceFixture = this.Create<AutoPropertiesCommand<dynamic>>(true);
            _autoPropertiesCommandInstance = _autoPropertiesCommandInstanceFixture ?? this.Create<AutoPropertiesCommand<dynamic>>(false);
            CurrentInstance = _autoPropertiesCommandInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertySpecification = "Specification";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodIsSatisfiedBy = "IsSatisfiedBy";
        private const string MethodGetSpecimenType = "GetSpecimenType";
        private const string MethodGetFields = "GetFields";
        private const string MethodGetProperties = "GetProperties";

        #endregion

        #endregion

        #region General Initializer : Class (AutoPropertiesCommand) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_AutoPropertiesCommand_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (AutoPropertiesCommand) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_AutoPropertiesCommand_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (AutoPropertiesCommand) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_AutoPropertiesCommand_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AutoPropertiesCommand)

        #region General Initializer : Class (AutoPropertiesCommand) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodIsSatisfiedBy, 0)]
        [TestCase(MethodGetSpecimenType, 0)]
        [TestCase(MethodGetFields, 0)]
        [TestCase(MethodGetProperties, 0)]
        [TestCase(MethodExecute, 1)]
        public void AUT_AutoPropertiesCommand_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AutoPropertiesCommand) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySpecification)]
        public void AUT_AutoPropertiesCommand_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AutoPropertiesCommand) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AutoPropertiesCommand_Is_Instance_Present_Test()
        {
            // Assert
            _autoPropertiesCommandInstanceType.ShouldNotBeNull();
            _autoPropertiesCommandInstance.ShouldNotBeNull();
            _autoPropertiesCommandInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AutoPropertiesCommand) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AutoPropertiesCommand_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _autoPropertiesCommandInstance.ShouldBeAssignableTo<AutoPropertiesCommand<dynamic>>();
            _autoPropertiesCommandInstanceFixture.ShouldBeAssignableTo<AutoPropertiesCommand<dynamic>>();
            CurrentInstance.ShouldBeAssignableTo<AutoPropertiesCommand<dynamic>>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AutoPropertiesCommand) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AutoPropertiesCommand_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AutoPropertiesCommand<dynamic> instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (AutoPropertiesCommand) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="AutoPropertiesCommand" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_AutoPropertiesCommand_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (AutoPropertiesCommand) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="AutoPropertiesCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AutoPropertiesCommand_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (AutoPropertiesCommand) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="AutoPropertiesCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AutoPropertiesCommand_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodAutoPropertiesCommandParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodAutoPropertiesCommandParametersTypes);
        }

        #endregion

        #region General Constructor : Class (AutoPropertiesCommand) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="AutoPropertiesCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AutoPropertiesCommand_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodAutoPropertiesCommandParametersTypes = new Type[] { typeof(IRequestSpecification) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodAutoPropertiesCommandParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AutoPropertiesCommand) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySpecification)]
        public void AUT_AutoPropertiesCommand_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AutoPropertiesCommand) => Property (Specification) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AutoPropertiesCommand_Specification_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);
            Action currentAction = () => propertyInfo.SetValue(_autoPropertiesCommandInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (AutoPropertiesCommand) => Property (Specification) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AutoPropertiesCommand_Public_Class_Specification_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecification);
            var propertyInfo = this.GetPropertyInfo(PropertySpecification);

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

        #region Method Call : (Execute) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_Execute_Method_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_Internally(Type[] types)
        {
            var methodIsSatisfiedByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _autoPropertiesCommandInstance.IsSatisfiedBy(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_autoPropertiesCommandInstanceFixture, parametersOfIsSatisfiedBy);
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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_autoPropertiesCommandInstanceFixture, out exception1, parametersOfIsSatisfiedBy);
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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_autoPropertiesCommandInstanceFixture, parametersOfIsSatisfiedBy);

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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_AutoPropertiesCommand_IsSatisfiedBy_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetSpecimenType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_Internally(Type[] types)
        {
            var methodGetSpecimenTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSpecimenType, methodGetSpecimenTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var specimen = this.CreateType<object>();
            var methodGetSpecimenTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetSpecimenType = { specimen };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetSpecimenType, methodGetSpecimenTypeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<Type>(_autoPropertiesCommandInstanceFixture, out exception1, parametersOfGetSpecimenType);
            var result2 = this.GetResultOfMethod<Type>(MethodGetSpecimenType, parametersOfGetSpecimenType, methodGetSpecimenTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetSpecimenType.ShouldNotBeNull();
            parametersOfGetSpecimenType.Length.ShouldBe(1);
            methodGetSpecimenTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var specimen = this.CreateType<object>();
            var methodGetSpecimenTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetSpecimenType = { specimen };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetSpecimenType, methodGetSpecimenTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_autoPropertiesCommandInstanceFixture, parametersOfGetSpecimenType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSpecimenType.ShouldNotBeNull();
            parametersOfGetSpecimenType.Length.ShouldBe(1);
            methodGetSpecimenTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var specimen = this.CreateType<object>();
            var methodGetSpecimenTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetSpecimenType = { specimen };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodGetSpecimenType, parametersOfGetSpecimenType, methodGetSpecimenTypeParametersTypes);

            // Assert
            parametersOfGetSpecimenType.ShouldNotBeNull();
            parametersOfGetSpecimenType.Length.ShouldBe(1);
            methodGetSpecimenTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var methodGetSpecimenTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSpecimenType, methodGetSpecimenTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetSpecimenTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var methodGetSpecimenTypeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSpecimenType, methodGetSpecimenTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSpecimenTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var methodInfo = this.GetMethodInfo(MethodGetSpecimenType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSpecimenType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetSpecimenType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSpecimenType);
            var methodInfo = this.GetMethodInfo(MethodGetSpecimenType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_GetFields_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFields, methodGetFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var specimen = this.CreateType<object>();
            var methodGetFieldsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetFields = { specimen };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetFields, methodGetFieldsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<FieldInfo>>(_autoPropertiesCommandInstanceFixture, out exception1, parametersOfGetFields);
            var result2 = this.GetResultOfMethod<IEnumerable<FieldInfo>>(MethodGetFields, parametersOfGetFields, methodGetFieldsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFields.ShouldNotBeNull();
            parametersOfGetFields.Length.ShouldBe(1);
            methodGetFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var specimen = this.CreateType<object>();
            var methodGetFieldsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetFields = { specimen };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetFields, methodGetFieldsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_autoPropertiesCommandInstanceFixture, parametersOfGetFields);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFields.ShouldNotBeNull();
            parametersOfGetFields.Length.ShouldBe(1);
            methodGetFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var specimen = this.CreateType<object>();
            var methodGetFieldsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetFields = { specimen };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<FieldInfo>>(MethodGetFields, parametersOfGetFields, methodGetFieldsParametersTypes);

            // Assert
            parametersOfGetFields.ShouldNotBeNull();
            parametersOfGetFields.Length.ShouldBe(1);
            methodGetFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var methodGetFieldsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFields, methodGetFieldsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var methodGetFieldsParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFields, methodGetFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var methodInfo = this.GetMethodInfo(MethodGetFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFields) (Return Type : IEnumerable<FieldInfo>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFields);
            var methodInfo = this.GetMethodInfo(MethodGetFields, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_GetProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var specimen = this.CreateType<object>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetProperties = { specimen };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetProperties, methodGetPropertiesParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<PropertyInfo>>(_autoPropertiesCommandInstanceFixture, out exception1, parametersOfGetProperties);
            var result2 = this.GetResultOfMethod<IEnumerable<PropertyInfo>>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(1);
            methodGetPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var specimen = this.CreateType<object>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetProperties = { specimen };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetProperties, methodGetPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_autoPropertiesCommandInstanceFixture, parametersOfGetProperties);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(1);
            methodGetPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var specimen = this.CreateType<object>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetProperties = { specimen };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<PropertyInfo>>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(1);
            methodGetPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodInfo = this.GetMethodInfo(MethodGetProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : IEnumerable<PropertyInfo>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_GetProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodInfo = this.GetMethodInfo(MethodGetProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AutoPropertiesCommand_Execute_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _autoPropertiesCommandInstance.Execute(specimen, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfExecute = { specimen, context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_autoPropertiesCommandInstanceFixture, parametersOfExecute);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfExecute = { specimen, context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 1);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AutoPropertiesCommand_Execute_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}
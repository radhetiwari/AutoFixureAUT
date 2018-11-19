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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.TemplateMethodQuery" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TemplateMethodQueryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TemplateMethodQuery" />)
        /// </summary>
        public TemplateMethodQueryTest() : base(typeof(TemplateMethodQuery))
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

        #region General Initializer : Class (TemplateMethodQuery) Initializer

        #region General Initializer : Class (TemplateMethodQuery) One time setup

        private Type _templateMethodQueryInstanceType;
        private TemplateMethodQuery _templateMethodQueryInstance;
        private TemplateMethodQuery _templateMethodQueryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="TemplateMethodQuery" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _templateMethodQueryInstanceType = typeof(TemplateMethodQuery);
            _templateMethodQueryInstanceFixture = this.Create<TemplateMethodQuery>(true);
            _templateMethodQueryInstance = _templateMethodQueryInstanceFixture ?? this.Create<TemplateMethodQuery>(false);
            CurrentInstance = _templateMethodQueryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyTemplate = "Template";
        private const string PropertyOwner = "Owner";

        #endregion

        #region Methods

        private const string MethodSelectMethods = "SelectMethods";
        private const string MethodGetMethodFactory = "GetMethodFactory";
        private const string MethodCompare = "Compare";
        private const string MethodGetTypeArguments = "GetTypeArguments";

        #endregion

        #endregion

        #region General Initializer : Class (TemplateMethodQuery) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TemplateMethodQuery_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TemplateMethodQuery) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TemplateMethodQuery_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TemplateMethodQuery) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_TemplateMethodQuery_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TemplateMethodQuery)

        #region General Initializer : Class (TemplateMethodQuery) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSelectMethods, 0)]
        [TestCase(MethodGetMethodFactory, 0)]
        [TestCase(MethodCompare, 0)]
        [TestCase(MethodGetTypeArguments, 0)]
        public void AUT_TemplateMethodQuery_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TemplateMethodQuery) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTemplate)]
        [TestCase(PropertyOwner)]
        public void AUT_TemplateMethodQuery_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TemplateMethodQuery) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TemplateMethodQuery_Is_Instance_Present_Test()
        {
            // Assert
            _templateMethodQueryInstanceType.ShouldNotBeNull();
            _templateMethodQueryInstance.ShouldNotBeNull();
            _templateMethodQueryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TemplateMethodQuery) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TemplateMethodQuery_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _templateMethodQueryInstance.ShouldBeAssignableTo<TemplateMethodQuery>();
            _templateMethodQueryInstanceFixture.ShouldBeAssignableTo<TemplateMethodQuery>();
            CurrentInstance.ShouldBeAssignableTo<TemplateMethodQuery>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TemplateMethodQuery) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var template = this.CreateType<MethodInfo>();
            TemplateMethodQuery instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TemplateMethodQuery(template);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _templateMethodQueryInstance.ShouldNotBeNull();
            _templateMethodQueryInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TemplateMethodQuery>();
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var template = this.CreateType<MethodInfo>();
            TemplateMethodQuery instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TemplateMethodQuery(template);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _templateMethodQueryInstance.ShouldNotBeNull();
            _templateMethodQueryInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) instance created

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_Is_Created_Test()
        {
            // Assert
            _templateMethodQueryInstance.ShouldNotBeNull();
            _templateMethodQueryInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TemplateMethodQuery" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_TemplateMethodQuery_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TemplateMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TemplateMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTemplateMethodQueryParametersTypes = new Type[] { typeof(MethodInfo) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTemplateMethodQueryParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TemplateMethodQuery) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TemplateMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TemplateMethodQuery_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTemplateMethodQueryParametersTypes = new Type[] { typeof(MethodInfo), typeof(object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTemplateMethodQueryParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TemplateMethodQuery) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTemplate)]
        [TestCase(PropertyOwner)]
        public void AUT_TemplateMethodQuery_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TemplateMethodQuery) => Property (Owner) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateMethodQuery_Owner_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwner);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOwner);
            Action currentAction = () => propertyInfo.SetValue(_templateMethodQueryInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TemplateMethodQuery) => Property (Owner) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateMethodQuery_Public_Class_Owner_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwner);
            var propertyInfo = this.GetPropertyInfo(PropertyOwner);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TemplateMethodQuery) => Property (Template) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateMethodQuery_Template_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTemplate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTemplate);
            Action currentAction = () => propertyInfo.SetValue(_templateMethodQueryInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TemplateMethodQuery) => Property (Template) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateMethodQuery_Public_Class_Template_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTemplate);
            var propertyInfo = this.GetPropertyInfo(PropertyTemplate);

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

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TemplateMethodQuery_SelectMethods_Method_Call_Internally(Type[] types)
        {
            var methodSelectMethodsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _templateMethodQueryInstance.SelectMethods(type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var returnedValue = default(IEnumerable<IMethod>);

            // Act
            Action executeAction = () => returnedValue = _templateMethodQueryInstance.SelectMethods(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<IMethod>>(_templateMethodQueryInstanceFixture, out exception1, parametersOfSelectMethods);
            var result2 = this.GetResultOfMethod<IEnumerable<IMethod>>(MethodSelectMethods, parametersOfSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_templateMethodQueryInstanceFixture, parametersOfSelectMethods);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<IMethod>>(MethodSelectMethods, parametersOfSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            parametersOfSelectMethods.ShouldNotBeNull();
            parametersOfSelectMethods.Length.ShouldBe(1);
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSelectMethodsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_SelectMethods_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_Internally(Type[] types)
        {
            var methodGetMethodFactoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMethodFactory, methodGetMethodFactoryParametersTypes);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var method = this.CreateType<MethodInfo>();
            var methodGetMethodFactoryParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfGetMethodFactory = { method };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetMethodFactory, methodGetMethodFactoryParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IMethodFactory>(_templateMethodQueryInstanceFixture, parametersOfGetMethodFactory);
            var result2 = this.GetResultOfMethod<IMethodFactory>(MethodGetMethodFactory, parametersOfGetMethodFactory, methodGetMethodFactoryParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMethodFactory.ShouldNotBeNull();
            parametersOfGetMethodFactory.Length.ShouldBe(1);
            methodGetMethodFactoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var method = this.CreateType<MethodInfo>();
            var methodGetMethodFactoryParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfGetMethodFactory = { method };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IMethodFactory>(MethodGetMethodFactory, parametersOfGetMethodFactory, methodGetMethodFactoryParametersTypes);

            // Assert
            parametersOfGetMethodFactory.ShouldNotBeNull();
            parametersOfGetMethodFactory.Length.ShouldBe(1);
            methodGetMethodFactoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var methodGetMethodFactoryParametersTypes = new Type[] { typeof(MethodInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMethodFactory, methodGetMethodFactoryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMethodFactoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var methodGetMethodFactoryParametersTypes = new Type[] { typeof(MethodInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMethodFactory, methodGetMethodFactoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMethodFactoryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var methodInfo = this.GetMethodInfo(MethodGetMethodFactory, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMethodFactory) (Return Type : IMethodFactory) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetMethodFactory_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodFactory);
            var methodInfo = this.GetMethodInfo(MethodGetMethodFactory, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TemplateMethodQuery_Compare_Method_Call_Internally(Type[] types)
        {
            var methodCompareParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompare, methodCompareParametersTypes);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var parameterType = this.CreateType<Type>();
            var templateParameterType = this.CreateType<Type>();
            var methodCompareParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfCompare = { parameterType, templateParameterType };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCompare, methodCompareParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_templateMethodQueryInstanceFixture, parametersOfCompare);
            var result2 = this.GetResultOfMethod<bool>(MethodCompare, parametersOfCompare, methodCompareParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompare.ShouldNotBeNull();
            parametersOfCompare.Length.ShouldBe(2);
            methodCompareParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var parameterType = this.CreateType<Type>();
            var templateParameterType = this.CreateType<Type>();
            var methodCompareParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfCompare = { parameterType, templateParameterType };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodCompare, methodCompareParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_templateMethodQueryInstanceFixture, out exception1, parametersOfCompare);
            var result2 = this.GetResultOfMethod<bool>(MethodCompare, parametersOfCompare, methodCompareParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompare.ShouldNotBeNull();
            parametersOfCompare.Length.ShouldBe(2);
            methodCompareParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var parameterType = this.CreateType<Type>();
            var templateParameterType = this.CreateType<Type>();
            var methodCompareParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfCompare = { parameterType, templateParameterType };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCompare, methodCompareParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_templateMethodQueryInstanceFixture, parametersOfCompare);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompare.ShouldNotBeNull();
            parametersOfCompare.Length.ShouldBe(2);
            methodCompareParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var parameterType = this.CreateType<Type>();
            var templateParameterType = this.CreateType<Type>();
            var methodCompareParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfCompare = { parameterType, templateParameterType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCompare, parametersOfCompare, methodCompareParametersTypes);

            // Assert
            parametersOfCompare.ShouldNotBeNull();
            parametersOfCompare.Length.ShouldBe(2);
            methodCompareParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var methodCompareParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompare, methodCompareParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompareParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var methodInfo = this.GetMethodInfo(MethodCompare, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compare) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_Compare_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompare);
            var methodInfo = this.GetMethodInfo(MethodCompare, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTypeArgumentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var type = this.CreateType<Type>();
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeArguments = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_templateMethodQueryInstanceFixture, parametersOfGetTypeArguments);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTypeArguments.ShouldNotBeNull();
            parametersOfGetTypeArguments.Length.ShouldBe(1);
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var type = this.CreateType<Type>();
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeArguments = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type[]>(MethodGetTypeArguments, parametersOfGetTypeArguments, methodGetTypeArgumentsParametersTypes);

            // Assert
            parametersOfGetTypeArguments.ShouldNotBeNull();
            parametersOfGetTypeArguments.Length.ShouldBe(1);
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var methodInfo = this.GetMethodInfo(MethodGetTypeArguments, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : Type[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TemplateMethodQuery_GetTypeArguments_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var methodInfo = this.GetMethodInfo(MethodGetTypeArguments, 0);
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
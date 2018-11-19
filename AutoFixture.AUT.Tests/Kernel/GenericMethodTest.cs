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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.GenericMethod" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GenericMethodTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GenericMethod" />)
        /// </summary>
        public GenericMethodTest() : base(typeof(GenericMethod))
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

        #region General Initializer : Class (GenericMethod) Initializer

        #region General Initializer : Class (GenericMethod) One time setup

        private Type _genericMethodInstanceType;
        private GenericMethod _genericMethodInstance;
        private GenericMethod _genericMethodInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="GenericMethod" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _genericMethodInstanceType = typeof(GenericMethod);
            _genericMethodInstanceFixture = this.Create<GenericMethod>(true);
            _genericMethodInstance = _genericMethodInstanceFixture ?? this.Create<GenericMethod>(false);
            CurrentInstance = _genericMethodInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyParameters = "Parameters";
        private const string PropertyMethod = "Method";
        private const string PropertyFactory = "Factory";

        #endregion

        #region Methods

        private const string MethodResolveGenericType = "ResolveGenericType";
        private const string MethodGetTypeArguments = "GetTypeArguments";
        private const string MethodInferMethodInfo = "InferMethodInfo";
        private const string MethodGetArgumentTypeOrObjectType = "GetArgumentTypeOrObjectType";
        private const string MethodInvoke = "Invoke";

        #endregion

        #region Fields

        private const string FieldparametersInfo = "parametersInfo";

        #endregion

        #endregion

        #region General Initializer : Class (GenericMethod) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_GenericMethod_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (GenericMethod) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_GenericMethod_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (GenericMethod) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_GenericMethod_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GenericMethod)

        #region General Initializer : Class (GenericMethod) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodResolveGenericType, 0)]
        [TestCase(MethodGetTypeArguments, 0)]
        [TestCase(MethodInferMethodInfo, 0)]
        [TestCase(MethodGetArgumentTypeOrObjectType, 0)]
        public void AUT_GenericMethod_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GenericMethod) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyParameters)]
        [TestCase(PropertyMethod)]
        [TestCase(PropertyFactory)]
        public void AUT_GenericMethod_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GenericMethod) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldparametersInfo)]
        public void AUT_GenericMethod_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GenericMethod) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GenericMethod_Is_Instance_Present_Test()
        {
            // Assert
            _genericMethodInstanceType.ShouldNotBeNull();
            _genericMethodInstance.ShouldNotBeNull();
            _genericMethodInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GenericMethod) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GenericMethod" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GenericMethod_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _genericMethodInstance.ShouldBeAssignableTo<GenericMethod>();
            _genericMethodInstanceFixture.ShouldBeAssignableTo<GenericMethod>();
            CurrentInstance.ShouldBeAssignableTo<GenericMethod>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GenericMethod) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GenericMethod_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var method = this.CreateType<MethodInfo>();
            var factory = this.CreateType<IMethodFactory>();
            GenericMethod instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GenericMethod(method, factory);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _genericMethodInstance.ShouldNotBeNull();
            _genericMethodInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<GenericMethod>();
        }

        #endregion

        #region General Constructor : Class (GenericMethod) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GenericMethod_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var method = this.CreateType<MethodInfo>();
            var factory = this.CreateType<IMethodFactory>();
            GenericMethod instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GenericMethod(method, factory);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _genericMethodInstance.ShouldNotBeNull();
            _genericMethodInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GenericMethod) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyParameters)]
        [TestCase(PropertyMethod)]
        [TestCase(PropertyFactory)]
        public void AUT_GenericMethod_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GenericMethod) => Property (Factory) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericMethod_Factory_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFactory);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFactory);
            Action currentAction = () => propertyInfo.SetValue(_genericMethodInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GenericMethod) => Property (Factory) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericMethod_Public_Class_Factory_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFactory);
            var propertyInfo = this.GetPropertyInfo(PropertyFactory);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GenericMethod) => Property (Method) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericMethod_Method_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethod);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMethod);
            Action currentAction = () => propertyInfo.SetValue(_genericMethodInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GenericMethod) => Property (Method) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericMethod_Public_Class_Method_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethod);
            var propertyInfo = this.GetPropertyInfo(PropertyMethod);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GenericMethod) => Property (Parameters) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericMethod_Public_Class_Parameters_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameters);
            var propertyInfo = this.GetPropertyInfo(PropertyParameters);

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

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_Internally(Type[] types)
        {
            var methodResolveGenericTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveGenericType, methodResolveGenericTypeParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var argument = this.CreateType<Type>();
            var parameter = this.CreateType<Type>();
            var methodResolveGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfResolveGenericType = { argument, parameter };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodResolveGenericType, methodResolveGenericTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodResolveGenericType, methodResolveGenericTypeParametersTypes);
            var result2 = this.GetResultOfMethod<IEnumerable<Tuple<Type, Type>>>(MethodResolveGenericType, parametersOfResolveGenericType, methodResolveGenericTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfResolveGenericType.ShouldNotBeNull();
            parametersOfResolveGenericType.Length.ShouldBe(2);
            methodResolveGenericTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<IEnumerable<Tuple<Type, Type>>>(MethodResolveGenericType, parametersOfResolveGenericType, methodResolveGenericTypeParametersTypes));
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var argument = this.CreateType<Type>();
            var parameter = this.CreateType<Type>();
            var methodResolveGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfResolveGenericType = { argument, parameter };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodResolveGenericType, methodResolveGenericTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_genericMethodInstanceFixture, parametersOfResolveGenericType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResolveGenericType.ShouldNotBeNull();
            parametersOfResolveGenericType.Length.ShouldBe(2);
            methodResolveGenericTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var argument = this.CreateType<Type>();
            var parameter = this.CreateType<Type>();
            var methodResolveGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfResolveGenericType = { argument, parameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<Tuple<Type, Type>>>(MethodResolveGenericType, parametersOfResolveGenericType, methodResolveGenericTypeParametersTypes);

            // Assert
            parametersOfResolveGenericType.ShouldNotBeNull();
            parametersOfResolveGenericType.Length.ShouldBe(2);
            methodResolveGenericTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var methodResolveGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveGenericType, methodResolveGenericTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodResolveGenericTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var methodResolveGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveGenericType, methodResolveGenericTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveGenericTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var methodInfo = this.GetMethodInfo(MethodResolveGenericType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ResolveGenericType) (Return Type : IEnumerable<Tuple<Type, Type>>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_ResolveGenericType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveGenericType);
            var methodInfo = this.GetMethodInfo(MethodResolveGenericType, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTypeArgumentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var type = this.CreateType<Type>();
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeArguments = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetTypeArguments, methodGetTypeArgumentsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_genericMethodInstanceFixture, parametersOfGetTypeArguments);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTypeArguments.ShouldNotBeNull();
            parametersOfGetTypeArguments.Length.ShouldBe(1);
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeArguments);
            var type = this.CreateType<Type>();
            var methodGetTypeArgumentsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeArguments = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<Type>>(MethodGetTypeArguments, parametersOfGetTypeArguments, methodGetTypeArgumentsParametersTypes);

            // Assert
            parametersOfGetTypeArguments.ShouldNotBeNull();
            parametersOfGetTypeArguments.Length.ShouldBe(1);
            methodGetTypeArgumentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetTypeArguments) (Return Type : IEnumerable<Type>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetTypeArguments_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetArgumentTypeOrObjectTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var argument = this.CreateType<object>();
            var methodGetArgumentTypeOrObjectTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetArgumentTypeOrObjectType = { argument };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);
            var result2 = this.GetResultOfMethod<Type>(MethodGetArgumentTypeOrObjectType, parametersOfGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetArgumentTypeOrObjectType.ShouldNotBeNull();
            parametersOfGetArgumentTypeOrObjectType.Length.ShouldBe(1);
            methodGetArgumentTypeOrObjectTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Type>(MethodGetArgumentTypeOrObjectType, parametersOfGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes));
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var argument = this.CreateType<object>();
            var methodGetArgumentTypeOrObjectTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetArgumentTypeOrObjectType = { argument };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_genericMethodInstanceFixture, parametersOfGetArgumentTypeOrObjectType);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetArgumentTypeOrObjectType.ShouldNotBeNull();
            parametersOfGetArgumentTypeOrObjectType.Length.ShouldBe(1);
            methodGetArgumentTypeOrObjectTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var argument = this.CreateType<object>();
            var methodGetArgumentTypeOrObjectTypeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetArgumentTypeOrObjectType = { argument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodGetArgumentTypeOrObjectType, parametersOfGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);

            // Assert
            parametersOfGetArgumentTypeOrObjectType.ShouldNotBeNull();
            parametersOfGetArgumentTypeOrObjectType.Length.ShouldBe(1);
            methodGetArgumentTypeOrObjectTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var methodGetArgumentTypeOrObjectTypeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetArgumentTypeOrObjectTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var methodGetArgumentTypeOrObjectTypeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetArgumentTypeOrObjectType, methodGetArgumentTypeOrObjectTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetArgumentTypeOrObjectTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var methodInfo = this.GetMethodInfo(MethodGetArgumentTypeOrObjectType, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetArgumentTypeOrObjectType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericMethod_GetArgumentTypeOrObjectType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgumentTypeOrObjectType);
            var methodInfo = this.GetMethodInfo(MethodGetArgumentTypeOrObjectType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Invoke) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericMethod_Invoke_Method_Call_Internally(Type[] types)
        {
            var methodInvokeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvoke, methodInvokeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}
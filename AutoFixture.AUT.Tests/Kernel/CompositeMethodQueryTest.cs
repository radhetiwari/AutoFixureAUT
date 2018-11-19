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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.CompositeMethodQuery" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CompositeMethodQueryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CompositeMethodQuery" />)
        /// </summary>
        public CompositeMethodQueryTest() : base(typeof(CompositeMethodQuery))
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

        #region General Initializer : Class (CompositeMethodQuery) Initializer

        #region General Initializer : Class (CompositeMethodQuery) One time setup

        private Type _compositeMethodQueryInstanceType;
        private CompositeMethodQuery _compositeMethodQueryInstance;
        private CompositeMethodQuery _compositeMethodQueryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="CompositeMethodQuery" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _compositeMethodQueryInstanceType = typeof(CompositeMethodQuery);
            _compositeMethodQueryInstanceFixture = this.Create<CompositeMethodQuery>(true);
            _compositeMethodQueryInstance = _compositeMethodQueryInstanceFixture ?? this.Create<CompositeMethodQuery>(false);
            CurrentInstance = _compositeMethodQueryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyQueries = "Queries";

        #endregion

        #region Methods

        private const string MethodSelectMethods = "SelectMethods";

        #endregion

        #endregion

        #region General Initializer : Class (CompositeMethodQuery) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeMethodQuery_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CompositeMethodQuery) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeMethodQuery_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CompositeMethodQuery) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeMethodQuery_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CompositeMethodQuery)

        #region General Initializer : Class (CompositeMethodQuery) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSelectMethods, 0)]
        public void AUT_CompositeMethodQuery_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CompositeMethodQuery) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyQueries)]
        public void AUT_CompositeMethodQuery_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CompositeMethodQuery) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompositeMethodQuery_Is_Instance_Present_Test()
        {
            // Assert
            _compositeMethodQueryInstanceType.ShouldNotBeNull();
            _compositeMethodQueryInstance.ShouldNotBeNull();
            _compositeMethodQueryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CompositeMethodQuery) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompositeMethodQuery_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _compositeMethodQueryInstance.ShouldBeAssignableTo<CompositeMethodQuery>();
            _compositeMethodQueryInstanceFixture.ShouldBeAssignableTo<CompositeMethodQuery>();
            CurrentInstance.ShouldBeAssignableTo<CompositeMethodQuery>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CompositeMethodQuery) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var queries = this.CreateType<IEnumerable<IMethodQuery>>();
            CompositeMethodQuery instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompositeMethodQuery(queries);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _compositeMethodQueryInstance.ShouldNotBeNull();
            _compositeMethodQueryInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<CompositeMethodQuery>();
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var queries = this.CreateType<IEnumerable<IMethodQuery>>();
            CompositeMethodQuery instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompositeMethodQuery(queries);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _compositeMethodQueryInstance.ShouldNotBeNull();
            _compositeMethodQueryInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) instance created

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_Is_Created_Test()
        {
            // Assert
            _compositeMethodQueryInstance.ShouldNotBeNull();
            _compositeMethodQueryInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="CompositeMethodQuery" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_CompositeMethodQuery_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="CompositeMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CompositeMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCompositeMethodQueryParametersTypes = new Type[] { typeof(IEnumerable<IMethodQuery>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCompositeMethodQueryParametersTypes);
        }

        #endregion

        #region General Constructor : Class (CompositeMethodQuery) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CompositeMethodQuery" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeMethodQuery_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCompositeMethodQueryParametersTypes = new Type[] { typeof(IMethodQuery[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCompositeMethodQueryParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CompositeMethodQuery) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyQueries)]
        public void AUT_CompositeMethodQuery_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CompositeMethodQuery) => Property (Queries) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CompositeMethodQuery_Public_Class_Queries_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueries);
            var propertyInfo = this.GetPropertyInfo(PropertyQueries);

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
        private void AUT_CompositeMethodQuery_SelectMethods_Method_Call_Internally(Type[] types)
        {
            var methodSelectMethodsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _compositeMethodQueryInstance.SelectMethods(type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var returnedValue = default(IEnumerable<IMethod>);

            // Act
            Action executeAction = () => returnedValue = _compositeMethodQueryInstance.SelectMethods(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerable<IMethod>>(_compositeMethodQueryInstanceFixture, out exception1, parametersOfSelectMethods);
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
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var type = this.CreateType<Type>();
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfSelectMethods = { type };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, methodSelectMethodsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_compositeMethodQueryInstanceFixture, parametersOfSelectMethods);

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
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodSelectMethodsParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSelectMethods, methodSelectMethodsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSelectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectMethods);
            var methodInfo = this.GetMethodInfo(MethodSelectMethods, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectMethods) (Return Type : IEnumerable<IMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeMethodQuery_SelectMethods_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}
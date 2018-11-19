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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.ElementsBuilder<dynamic>" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ElementsBuilderTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ElementsBuilder<dynamic>" />)
        /// </summary>
        public ElementsBuilderTest() : base(typeof(ElementsBuilder<dynamic>))
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

        #region General Initializer : Class (ElementsBuilder) Initializer

        #region General Initializer : Class (ElementsBuilder) One time setup

        private Type _elementsBuilderInstanceType;
        private ElementsBuilder<dynamic> _elementsBuilderInstance;
        private ElementsBuilder<dynamic> _elementsBuilderInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ElementsBuilder<dynamic>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _elementsBuilderInstanceType = typeof(ElementsBuilder<dynamic>);
            _elementsBuilderInstanceFixture = this.Create<ElementsBuilder<dynamic>>(true);
            _elementsBuilderInstance = _elementsBuilderInstanceFixture ?? this.Create<ElementsBuilder<dynamic>>(false);
            CurrentInstance = _elementsBuilderInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodGetNextIndex = "GetNextIndex";

        #endregion

        #region Fields

        private const string Fieldelements = "elements";
        private const string Fieldsequence = "sequence";

        #endregion

        #endregion

        #region General Initializer : Class (ElementsBuilder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ElementsBuilder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ElementsBuilder) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_ElementsBuilder_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ElementsBuilder)

        #region General Initializer : Class (ElementsBuilder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodGetNextIndex, 0)]
        public void AUT_ElementsBuilder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ElementsBuilder) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldelements)]
        [TestCase(Fieldsequence)]
        public void AUT_ElementsBuilder_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ElementsBuilder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ElementsBuilder_Is_Instance_Present_Test()
        {
            // Assert
            _elementsBuilderInstanceType.ShouldNotBeNull();
            _elementsBuilderInstance.ShouldNotBeNull();
            _elementsBuilderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ElementsBuilder) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ElementsBuilder_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _elementsBuilderInstance.ShouldBeAssignableTo<ElementsBuilder<dynamic>>();
            _elementsBuilderInstanceFixture.ShouldBeAssignableTo<ElementsBuilder<dynamic>>();
            CurrentInstance.ShouldBeAssignableTo<ElementsBuilder<dynamic>>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ElementsBuilder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ElementsBuilder_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var elements = this.CreateType<dynamic[]>();
            ElementsBuilder<dynamic> instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ElementsBuilder<dynamic>(elements);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _elementsBuilderInstance.ShouldNotBeNull();
            _elementsBuilderInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ElementsBuilder<dynamic>>();
        }

        #endregion

        #region General Constructor : Class (ElementsBuilder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ElementsBuilder_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var elements = this.CreateType<dynamic[]>();
            ElementsBuilder<dynamic> instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ElementsBuilder<dynamic>(elements);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _elementsBuilderInstance.ShouldNotBeNull();
            _elementsBuilderInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ElementsBuilder) instance created

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ElementsBuilder_Is_Created_Test()
        {
            // Assert
            _elementsBuilderInstance.ShouldNotBeNull();
            _elementsBuilderInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ElementsBuilder) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ElementsBuilder" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ElementsBuilder_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ElementsBuilder) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ElementsBuilder" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ElementsBuilder_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ElementsBuilder) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ElementsBuilder" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ElementsBuilder_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodElementsBuilderParametersTypes = new Type[] { typeof(dynamic[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodElementsBuilderParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ElementsBuilder_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _elementsBuilderInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _elementsBuilderInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_elementsBuilderInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_ElementsBuilder_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_elementsBuilderInstanceFixture, parametersOfCreate);

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
        public void AUT_ElementsBuilder_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_ElementsBuilder_Create_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_ElementsBuilder_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_ElementsBuilder_Create_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_ElementsBuilder_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetNextIndex) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ElementsBuilder_GetNextIndex_Method_Call_Internally(Type[] types)
        {
            var methodGetNextIndexParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNextIndex, methodGetNextIndexParametersTypes);
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;
            object[] parametersOfGetNextIndex = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetNextIndex, methodGetNextIndexParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_elementsBuilderInstanceFixture, parametersOfGetNextIndex);
            var result2 = this.GetResultOfMethod<int>(MethodGetNextIndex, parametersOfGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextIndex.ShouldBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;
            object[] parametersOfGetNextIndex = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetNextIndex, methodGetNextIndexParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_elementsBuilderInstanceFixture, out exception1, parametersOfGetNextIndex);
            var result2 = this.GetResultOfMethod<int>(MethodGetNextIndex, parametersOfGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNextIndex.ShouldBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;
            object[] parametersOfGetNextIndex = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetNextIndex, methodGetNextIndexParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_elementsBuilderInstanceFixture, parametersOfGetNextIndex);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNextIndex.ShouldBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;
            object[] parametersOfGetNextIndex = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetNextIndex, parametersOfGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            parametersOfGetNextIndex.ShouldBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNextIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            Type [] methodGetNextIndexParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNextIndex, methodGetNextIndexParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNextIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNextIndex) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ElementsBuilder_GetNextIndex_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNextIndex);
            var methodInfo = this.GetMethodInfo(MethodGetNextIndex, 0);

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
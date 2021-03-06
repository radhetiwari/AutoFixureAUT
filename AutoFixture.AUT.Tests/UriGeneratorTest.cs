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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.UriGenerator" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UriGeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UriGenerator" />)
        /// </summary>
        public UriGeneratorTest() : base(typeof(UriGenerator))
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

        #region General Initializer : Class (UriGenerator) Initializer

        #region General Initializer : Class (UriGenerator) One time setup

        private Type _uriGeneratorInstanceType;
        private UriGenerator _uriGeneratorInstance;
        private UriGenerator _uriGeneratorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="UriGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _uriGeneratorInstanceType = typeof(UriGenerator);
            _uriGeneratorInstanceFixture = this.Create<UriGenerator>(true);
            _uriGeneratorInstance = _uriGeneratorInstanceFixture ?? this.Create<UriGenerator>(false);
            CurrentInstance = _uriGeneratorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";
        private const string MethodMakeUri = "MakeUri";

        #endregion

        #endregion

        #region General Initializer : Class (UriGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UriGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_UriGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UriGenerator)

        #region General Initializer : Class (UriGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UriGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodMakeUri, 0)]
        public void AUT_UriGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (UriGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UriGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UriGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _uriGeneratorInstanceType.ShouldNotBeNull();
            _uriGeneratorInstance.ShouldNotBeNull();
            _uriGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UriGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UriGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UriGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _uriGeneratorInstance.ShouldBeAssignableTo<UriGenerator>();
            _uriGeneratorInstanceFixture.ShouldBeAssignableTo<UriGenerator>();
            CurrentInstance.ShouldBeAssignableTo<UriGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UriGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UriGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UriGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UriGenerator_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _uriGeneratorInstance.Create(request, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _uriGeneratorInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var result1 = methodInfo.GetResultMethodInfo<object>(_uriGeneratorInstanceFixture, out exception1, parametersOfCreate);
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
        public void AUT_UriGenerator_Create_Method_Call_With_No_Exception_Thrown_Test()
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
            Action currentAction = () => methodInfo.Invoke(_uriGeneratorInstanceFixture, parametersOfCreate);

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
        public void AUT_UriGenerator_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (Create) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (MakeUri) (Return Type : Uri) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UriGenerator_MakeUri_Static_Method_Call_Internally(Type[] types)
        {
            var methodMakeUriParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMakeUri, methodMakeUriParametersTypes);
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var scheme = this.CreateType<UriScheme>();
            var authority = this.CreateType<string>();
            var methodMakeUriParametersTypes = new Type[] { typeof(UriScheme), typeof(string) };
            object[] parametersOfMakeUri = { scheme, authority };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodMakeUri, methodMakeUriParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMakeUri, methodMakeUriParametersTypes);
            var result2 = this.GetResultOfMethod<Uri>(MethodMakeUri, parametersOfMakeUri, methodMakeUriParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_uriGeneratorInstanceFixture, parametersOfMakeUri);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMakeUri.ShouldNotBeNull();
            parametersOfMakeUri.Length.ShouldBe(2);
            methodMakeUriParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var scheme = this.CreateType<UriScheme>();
            var authority = this.CreateType<string>();
            var methodMakeUriParametersTypes = new Type[] { typeof(UriScheme), typeof(string) };
            object[] parametersOfMakeUri = { scheme, authority };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Uri>(MethodMakeUri, parametersOfMakeUri, methodMakeUriParametersTypes);

            // Assert
            parametersOfMakeUri.ShouldNotBeNull();
            parametersOfMakeUri.Length.ShouldBe(2);
            methodMakeUriParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var methodMakeUriParametersTypes = new Type[] { typeof(UriScheme), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMakeUri, methodMakeUriParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMakeUriParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var methodMakeUriParametersTypes = new Type[] { typeof(UriScheme), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMakeUri, methodMakeUriParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMakeUriParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var methodInfo = this.GetMethodInfo(MethodMakeUri, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MakeUri) (Return Type : Uri) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UriGenerator_MakeUri_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMakeUri);
            var methodInfo = this.GetMethodInfo(MethodMakeUri, 0);
            const int parametersCount = 2;

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
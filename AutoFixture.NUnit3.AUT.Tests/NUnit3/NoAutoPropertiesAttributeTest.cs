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
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.NUnit3;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.NUnit3.NoAutoPropertiesAttribute" />)
    ///     and namespace <see cref="AutoFixture.NUnit3"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NoAutoPropertiesAttributeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NoAutoPropertiesAttribute" />)
        /// </summary>
        public NoAutoPropertiesAttributeTest() : base(typeof(NoAutoPropertiesAttribute))
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

        #region General Initializer : Class (NoAutoPropertiesAttribute) Initializer

        #region General Initializer : Class (NoAutoPropertiesAttribute) One time setup

        private Type _noAutoPropertiesAttributeInstanceType;
        private NoAutoPropertiesAttribute _noAutoPropertiesAttributeInstance;
        private NoAutoPropertiesAttribute _noAutoPropertiesAttributeInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="NoAutoPropertiesAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _noAutoPropertiesAttributeInstanceType = typeof(NoAutoPropertiesAttribute);
            _noAutoPropertiesAttributeInstanceFixture = this.Create<NoAutoPropertiesAttribute>(true);
            _noAutoPropertiesAttributeInstance = _noAutoPropertiesAttributeInstanceFixture ?? this.Create<NoAutoPropertiesAttribute>(false);
            CurrentInstance = _noAutoPropertiesAttributeInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodGetCustomization = "GetCustomization";

        #endregion

        #endregion

        #region General Initializer : Class (NoAutoPropertiesAttribute) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NoAutoPropertiesAttribute" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_NoAutoPropertiesAttribute_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NoAutoPropertiesAttribute)

        #region General Initializer : Class (NoAutoPropertiesAttribute) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NoAutoPropertiesAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCustomization, 0)]
        public void AUT_NoAutoPropertiesAttribute_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NoAutoPropertiesAttribute) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NoAutoPropertiesAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NoAutoPropertiesAttribute_Is_Instance_Present_Test()
        {
            // Assert
            _noAutoPropertiesAttributeInstanceType.ShouldNotBeNull();
            _noAutoPropertiesAttributeInstance.ShouldNotBeNull();
            _noAutoPropertiesAttributeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NoAutoPropertiesAttribute) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NoAutoPropertiesAttribute" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NoAutoPropertiesAttribute_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _noAutoPropertiesAttributeInstance.ShouldBeAssignableTo<NoAutoPropertiesAttribute>();
            _noAutoPropertiesAttributeInstanceFixture.ShouldBeAssignableTo<NoAutoPropertiesAttribute>();
            CurrentInstance.ShouldBeAssignableTo<NoAutoPropertiesAttribute>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NoAutoPropertiesAttribute) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NoAutoPropertiesAttribute_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NoAutoPropertiesAttribute instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCustomization) (Return Type : ICustomization) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomizationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomization, methodGetCustomizationParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();

            // Act
            Action executeAction = () => _noAutoPropertiesAttributeInstance.GetCustomization(parameter);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();
            var returnedValue = default(ICustomization);

            // Act
            Action executeAction = () => returnedValue = _noAutoPropertiesAttributeInstance.GetCustomization(parameter);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomization) (Return Type : ICustomization) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomization);
            var parameter = this.CreateType<ParameterInfo>();
            var methodGetCustomizationParametersTypes = new Type[] { typeof(ParameterInfo) };
            object[] parametersOfGetCustomization = { parameter };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetCustomization, methodGetCustomizationParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ICustomization>(_noAutoPropertiesAttributeInstanceFixture, parametersOfGetCustomization);
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
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NoAutoPropertiesAttribute_GetCustomization_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.SpecimenContext" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenContextTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenContext" />)
        /// </summary>
        public SpecimenContextTest() : base(typeof(SpecimenContext))
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

        #region General Initializer : Class (SpecimenContext) Initializer

        #region General Initializer : Class (SpecimenContext) One time setup

        private Type _specimenContextInstanceType;
        private SpecimenContext _specimenContextInstance;
        private SpecimenContext _specimenContextInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenContextInstanceType = typeof(SpecimenContext);
            _specimenContextInstanceFixture = this.Create<SpecimenContext>(true);
            _specimenContextInstance = _specimenContextInstanceFixture ?? this.Create<SpecimenContext>(false);
            CurrentInstance = _specimenContextInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBuilder = "Builder";

        #endregion

        #region Methods

        private const string MethodResolve = "Resolve";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenContext)

        #region General Initializer : Class (SpecimenContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodResolve, 0)]
        public void AUT_SpecimenContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SpecimenContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBuilder)]
        public void AUT_SpecimenContext_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SpecimenContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenContext_Is_Instance_Present_Test()
        {
            // Assert
            _specimenContextInstanceType.ShouldNotBeNull();
            _specimenContextInstance.ShouldNotBeNull();
            _specimenContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SpecimenContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SpecimenContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _specimenContextInstance.ShouldBeAssignableTo<SpecimenContext>();
            _specimenContextInstanceFixture.ShouldBeAssignableTo<SpecimenContext>();
            CurrentInstance.ShouldBeAssignableTo<SpecimenContext>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SpecimenContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenContext_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            SpecimenContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenContext(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenContextInstance.ShouldNotBeNull();
            _specimenContextInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SpecimenContext>();
        }

        #endregion

        #region General Constructor : Class (SpecimenContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenContext_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            SpecimenContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenContext(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenContextInstance.ShouldNotBeNull();
            _specimenContextInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SpecimenContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBuilder)]
        public void AUT_SpecimenContext_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SpecimenContext) => Property (Builder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenContext_Builder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);
            Action currentAction = () => propertyInfo.SetValue(_specimenContextInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenContext) => Property (Builder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenContext_Public_Class_Builder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);

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

        #region Method Call : (Resolve) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenContext_Resolve_Method_Call_Internally(Type[] types)
        {
            var methodResolveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolve, methodResolveParametersTypes);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _specimenContextInstance.Resolve(request);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var request = this.CreateType<object>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _specimenContextInstance.Resolve(request);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var request = this.CreateType<object>();
            var methodResolveParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfResolve = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodResolve, methodResolveParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_specimenContextInstanceFixture, parametersOfResolve);
            var result2 = this.GetResultOfMethod<object>(MethodResolve, parametersOfResolve, methodResolveParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolve.ShouldNotBeNull();
            parametersOfResolve.Length.ShouldBe(1);
            methodResolveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var request = this.CreateType<object>();
            var methodResolveParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfResolve = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodResolve, parametersOfResolve, methodResolveParametersTypes);

            // Assert
            parametersOfResolve.ShouldNotBeNull();
            parametersOfResolve.Length.ShouldBe(1);
            methodResolveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var methodResolveParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolve, methodResolveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var methodResolveParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolve, methodResolveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var methodInfo = this.GetMethodInfo(MethodResolve, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenContext_Resolve_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var methodInfo = this.GetMethodInfo(MethodResolve, 0);
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
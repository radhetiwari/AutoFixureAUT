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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.DisposableTrackingCustomization" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DisposableTrackingCustomizationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DisposableTrackingCustomization" />)
        /// </summary>
        public DisposableTrackingCustomizationTest() : base(typeof(DisposableTrackingCustomization))
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

        #region General Initializer : Class (DisposableTrackingCustomization) Initializer

        #region General Initializer : Class (DisposableTrackingCustomization) One time setup

        private Type _disposableTrackingCustomizationInstanceType;
        private DisposableTrackingCustomization _disposableTrackingCustomizationInstance;
        private DisposableTrackingCustomization _disposableTrackingCustomizationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="DisposableTrackingCustomization" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _disposableTrackingCustomizationInstanceType = typeof(DisposableTrackingCustomization);
            _disposableTrackingCustomizationInstanceFixture = this.Create<DisposableTrackingCustomization>(true);
            _disposableTrackingCustomizationInstance = _disposableTrackingCustomizationInstanceFixture ?? this.Create<DisposableTrackingCustomization>(false);
            CurrentInstance = _disposableTrackingCustomizationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBehavior = "Behavior";

        #endregion

        #region Methods

        private const string MethodCustomize = "Customize";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Fieldbehavior = "behavior";

        #endregion

        #endregion

        #region General Initializer : Class (DisposableTrackingCustomization) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingCustomization_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DisposableTrackingCustomization) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingCustomization_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DisposableTrackingCustomization) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_DisposableTrackingCustomization_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DisposableTrackingCustomization)

        #region General Initializer : Class (DisposableTrackingCustomization) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCustomize, 0)]
        [TestCase(MethodDispose, 0)]
        public void AUT_DisposableTrackingCustomization_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DisposableTrackingCustomization) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBehavior)]
        public void AUT_DisposableTrackingCustomization_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DisposableTrackingCustomization) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldbehavior)]
        public void AUT_DisposableTrackingCustomization_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DisposableTrackingCustomization) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DisposableTrackingCustomization_Is_Instance_Present_Test()
        {
            // Assert
            _disposableTrackingCustomizationInstanceType.ShouldNotBeNull();
            _disposableTrackingCustomizationInstance.ShouldNotBeNull();
            _disposableTrackingCustomizationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DisposableTrackingCustomization) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DisposableTrackingCustomization" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DisposableTrackingCustomization_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _disposableTrackingCustomizationInstance.ShouldBeAssignableTo<DisposableTrackingCustomization>();
            _disposableTrackingCustomizationInstanceFixture.ShouldBeAssignableTo<DisposableTrackingCustomization>();
            CurrentInstance.ShouldBeAssignableTo<DisposableTrackingCustomization>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DisposableTrackingCustomization) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DisposableTrackingCustomization_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DisposableTrackingCustomization instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DisposableTrackingCustomization) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBehavior)]
        public void AUT_DisposableTrackingCustomization_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DisposableTrackingCustomization) => Property (Behavior) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DisposableTrackingCustomization_Behavior_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBehavior);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBehavior);
            Action currentAction = () => propertyInfo.SetValue(_disposableTrackingCustomizationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DisposableTrackingCustomization) => Property (Behavior) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DisposableTrackingCustomization_Public_Class_Behavior_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBehavior);
            var propertyInfo = this.GetPropertyInfo(PropertyBehavior);

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

        #region Method Call : (Customize) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingCustomization_Customize_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();

            // Act
            Action executeAction = () => _disposableTrackingCustomizationInstance.Customize(fixture);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCustomize, methodCustomizeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_disposableTrackingCustomizationInstanceFixture, parametersOfCustomize);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCustomize, parametersOfCustomize, methodCustomizeParametersTypes);

            // Assert
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);

            // Assert
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DisposableTrackingCustomization_Customize_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingCustomization_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DisposableTrackingCustomization_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}
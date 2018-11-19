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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MissingParametersSupplyingMethodFactory" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MissingParametersSupplyingMethodFactoryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MissingParametersSupplyingMethodFactory" />)
        /// </summary>
        public MissingParametersSupplyingMethodFactoryTest() : base(typeof(MissingParametersSupplyingMethodFactory))
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

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) Initializer

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) One time setup

        private Type _missingParametersSupplyingMethodFactoryInstanceType;
        private MissingParametersSupplyingMethodFactory _missingParametersSupplyingMethodFactoryInstance;
        private MissingParametersSupplyingMethodFactory _missingParametersSupplyingMethodFactoryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MissingParametersSupplyingMethodFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _missingParametersSupplyingMethodFactoryInstanceType = typeof(MissingParametersSupplyingMethodFactory);
            _missingParametersSupplyingMethodFactoryInstanceFixture = this.Create<MissingParametersSupplyingMethodFactory>(true);
            _missingParametersSupplyingMethodFactoryInstance = _missingParametersSupplyingMethodFactoryInstanceFixture ?? this.Create<MissingParametersSupplyingMethodFactory>(false);
            CurrentInstance = _missingParametersSupplyingMethodFactoryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyOwner = "Owner";

        #endregion

        #region Methods

        private const string MethodCreate = "Create";

        #endregion

        #endregion

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MissingParametersSupplyingMethodFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MissingParametersSupplyingMethodFactory_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MissingParametersSupplyingMethodFactory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MissingParametersSupplyingMethodFactory)

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        public void AUT_MissingParametersSupplyingMethodFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MissingParametersSupplyingMethodFactory) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOwner)]
        public void AUT_MissingParametersSupplyingMethodFactory_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MissingParametersSupplyingMethodFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MissingParametersSupplyingMethodFactory_Is_Instance_Present_Test()
        {
            // Assert
            _missingParametersSupplyingMethodFactoryInstanceType.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstance.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MissingParametersSupplyingMethodFactory) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingMethodFactory" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MissingParametersSupplyingMethodFactory_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _missingParametersSupplyingMethodFactoryInstance.ShouldBeAssignableTo<MissingParametersSupplyingMethodFactory>();
            _missingParametersSupplyingMethodFactoryInstanceFixture.ShouldBeAssignableTo<MissingParametersSupplyingMethodFactory>();
            CurrentInstance.ShouldBeAssignableTo<MissingParametersSupplyingMethodFactory>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MissingParametersSupplyingMethodFactory) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MissingParametersSupplyingMethodFactory_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var owner = this.CreateType<object>();
            MissingParametersSupplyingMethodFactory instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new MissingParametersSupplyingMethodFactory(owner);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstance.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<MissingParametersSupplyingMethodFactory>();
        }

        #endregion

        #region General Constructor : Class (MissingParametersSupplyingMethodFactory) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MissingParametersSupplyingMethodFactory_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var owner = this.CreateType<object>();
            MissingParametersSupplyingMethodFactory instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new MissingParametersSupplyingMethodFactory(owner);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstance.ShouldNotBeNull();
            _missingParametersSupplyingMethodFactoryInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MissingParametersSupplyingMethodFactory) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOwner)]
        public void AUT_MissingParametersSupplyingMethodFactory_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MissingParametersSupplyingMethodFactory) => Property (Owner) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MissingParametersSupplyingMethodFactory_Owner_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwner);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOwner);
            Action currentAction = () => propertyInfo.SetValue(_missingParametersSupplyingMethodFactoryInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (MissingParametersSupplyingMethodFactory) => Property (Owner) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MissingParametersSupplyingMethodFactory_Public_Class_Owner_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : IMethod) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.CreateType<MethodInfo>();

            // Act
            Action executeAction = () => _missingParametersSupplyingMethodFactoryInstance.Create(methodInfo);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.CreateType<MethodInfo>();
            var returnedValue = default(IMethod);

            // Act
            Action executeAction = () => returnedValue = _missingParametersSupplyingMethodFactoryInstance.Create(methodInfo);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.CreateType<MethodInfo>();
            var methodCreateParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfCreate = { methodInfo };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IMethod>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(1);
            methodCreateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(MethodInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(MethodInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (Create) (Return Type : IMethod) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingMethodFactory_Create_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.GetMethodInfo(MethodCreate, 0);
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
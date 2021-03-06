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
    using System.Threading;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.RecursionGuard" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RecursionGuardTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RecursionGuard" />)
        /// </summary>
        public RecursionGuardTest() : base(typeof(RecursionGuard))
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

        #region General Initializer : Class (RecursionGuard) Initializer

        #region General Initializer : Class (RecursionGuard) One time setup

        private Type _recursionGuardInstanceType;
        private RecursionGuard _recursionGuardInstance;
        private RecursionGuard _recursionGuardInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RecursionGuard" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _recursionGuardInstanceType = typeof(RecursionGuard);
            _recursionGuardInstanceFixture = this.Create<RecursionGuard>(true);
            _recursionGuardInstance = _recursionGuardInstanceFixture ?? this.Create<RecursionGuard>(false);
            CurrentInstance = _recursionGuardInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyBuilder = "Builder";
        private const string PropertyRecursionHandler = "RecursionHandler";
        private const string PropertyRecursionDepth = "RecursionDepth";
        private const string PropertyComparer = "Comparer";
        private const string PropertyRecordedRequests = "RecordedRequests";

        #endregion

        #region Methods

        private const string MethodGetMonitoredRequestsForCurrentThread = "GetMonitoredRequestsForCurrentThread";
        private const string MethodHandleRecursiveRequest = "HandleRecursiveRequest";
        private const string MethodCreate = "Create";
        private const string MethodCompose = "Compose";
        private const string MethodGetEnumerator = "GetEnumerator";

        #endregion

        #region Fields

        private const string FieldrequestsByThread = "requestsByThread";

        #endregion

        #endregion

        #region General Initializer : Class (RecursionGuard) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RecursionGuard_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RecursionGuard) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RecursionGuard_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RecursionGuard) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_RecursionGuard_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RecursionGuard)

        #region General Initializer : Class (RecursionGuard) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        [TestCase(MethodCompose, 0)]
        [TestCase(MethodGetEnumerator, 0)]
        public void AUT_RecursionGuard_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RecursionGuard) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertyRecursionHandler)]
        [TestCase(PropertyRecursionDepth)]
        [TestCase(PropertyComparer)]
        [TestCase(PropertyRecordedRequests)]
        public void AUT_RecursionGuard_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RecursionGuard) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RecursionGuard_Is_Instance_Present_Test()
        {
            // Assert
            _recursionGuardInstanceType.ShouldNotBeNull();
            _recursionGuardInstance.ShouldNotBeNull();
            _recursionGuardInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RecursionGuard) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RecursionGuard_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _recursionGuardInstance.ShouldBeAssignableTo<RecursionGuard>();
            _recursionGuardInstanceFixture.ShouldBeAssignableTo<RecursionGuard>();
            CurrentInstance.ShouldBeAssignableTo<RecursionGuard>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RecursionGuard) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="RecursionGuard" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void AUT_RecursionGuard_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IRecursionHandler) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IRecursionHandler), typeof(int) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IEqualityComparer) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IRecursionHandler), typeof(IEqualityComparer) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #region General Constructor : Class (RecursionGuard) constructors with dynamic parameters (Overloading_Of_5_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="RecursionGuard" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RecursionGuard_Constructors_Overloading_Of_5_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRecursionGuardParametersTypes = new Type[] { typeof(ISpecimenBuilder), typeof(IRecursionHandler), typeof(IEqualityComparer), typeof(int) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRecursionGuardParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RecursionGuard) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBuilder)]
        [TestCase(PropertyRecursionHandler)]
        [TestCase(PropertyRecursionDepth)]
        [TestCase(PropertyComparer)]
        [TestCase(PropertyRecordedRequests)]
        public void AUT_RecursionGuard_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RecursionGuard) => Property (Builder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Builder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBuilder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBuilder);
            Action currentAction = () => propertyInfo.SetValue(_recursionGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (Builder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Public_Class_Builder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (RecursionGuard) => Property (Comparer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Comparer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyComparer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyComparer);
            Action currentAction = () => propertyInfo.SetValue(_recursionGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (Comparer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Public_Class_Comparer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyComparer);
            var propertyInfo = this.GetPropertyInfo(PropertyComparer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (RecordedRequests) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_RecordedRequests_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordedRequests);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRecordedRequests);
            Action currentAction = () => propertyInfo.SetValue(_recursionGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (RecordedRequests) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Public_Class_RecordedRequests_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordedRequests);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordedRequests);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (RecursionDepth) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Public_Class_RecursionDepth_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecursionDepth);
            var propertyInfo = this.GetPropertyInfo(PropertyRecursionDepth);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (RecursionHandler) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_RecursionHandler_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecursionHandler);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRecursionHandler);
            Action currentAction = () => propertyInfo.SetValue(_recursionGuardInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RecursionGuard) => Property (RecursionHandler) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RecursionGuard_Public_Class_RecursionHandler_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecursionHandler);
            var propertyInfo = this.GetPropertyInfo(PropertyRecursionHandler);

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

        #region Method Call : (Create) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RecursionGuard_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _recursionGuardInstance.Create(request, context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _recursionGuardInstance.Create(request, context);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var request = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodCreateParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfCreate = { request, context };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_recursionGuardInstanceFixture, parametersOfCreate);
            var result2 = this.GetResultOfMethod<object>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(2);
            methodCreateParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Create) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_RecursionGuard_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_RecursionGuard_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_RecursionGuard_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_RecursionGuard_Create_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RecursionGuard_Compose_Method_Call_Internally(Type[] types)
        {
            var methodComposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => _recursionGuardInstance.Compose(builders);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var returnedValue = default(ISpecimenBuilderNode);

            // Act
            Action executeAction = () => returnedValue = _recursionGuardInstance.Compose(builders);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodCompose, methodComposeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_recursionGuardInstanceFixture, parametersOfCompose);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfCompose = { builders };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodCompose, parametersOfCompose, methodComposeParametersTypes);

            // Assert
            parametersOfCompose.ShouldNotBeNull();
            parametersOfCompose.Length.ShouldBe(1);
            methodComposeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodComposeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodComposeParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompose, methodComposeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodComposeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Compose) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_Compose_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompose);
            var methodInfo = this.GetMethodInfo(MethodCompose, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RecursionGuard_GetEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);

            // Act
            Action executeAction = () => _recursionGuardInstance.GetEnumerator();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var returnedValue = default(IEnumerator<ISpecimenBuilder>);

            // Act
            Action executeAction = () => returnedValue = _recursionGuardInstance.GetEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator<ISpecimenBuilder>>(_recursionGuardInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_recursionGuardInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RecursionGuard_GetEnumerator_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator>(_recursionGuardInstanceFixture, out exception1, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_recursionGuardInstanceFixture, parametersOfGetEnumerator);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RecursionGuard_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}
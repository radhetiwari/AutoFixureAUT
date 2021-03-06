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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.OrRequestSpecification" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OrRequestSpecificationTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OrRequestSpecification" />)
        /// </summary>
        public OrRequestSpecificationTest() : base(typeof(OrRequestSpecification))
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

        #region General Initializer : Class (OrRequestSpecification) Initializer

        #region General Initializer : Class (OrRequestSpecification) One time setup

        private Type _orRequestSpecificationInstanceType;
        private OrRequestSpecification _orRequestSpecificationInstance;
        private OrRequestSpecification _orRequestSpecificationInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="OrRequestSpecification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _orRequestSpecificationInstanceType = typeof(OrRequestSpecification);
            _orRequestSpecificationInstanceFixture = this.Create<OrRequestSpecification>(true);
            _orRequestSpecificationInstance = _orRequestSpecificationInstanceFixture ?? this.Create<OrRequestSpecification>(false);
            CurrentInstance = _orRequestSpecificationInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertySpecifications = "Specifications";

        #endregion

        #region Methods

        private const string MethodIsSatisfiedBy = "IsSatisfiedBy";

        #endregion

        #region Fields

        private const string Fieldspecifications = "specifications";

        #endregion

        #endregion

        #region General Initializer : Class (OrRequestSpecification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OrRequestSpecification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OrRequestSpecification) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OrRequestSpecification_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OrRequestSpecification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_OrRequestSpecification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OrRequestSpecification)

        #region General Initializer : Class (OrRequestSpecification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIsSatisfiedBy, 0)]
        public void AUT_OrRequestSpecification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OrRequestSpecification) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySpecifications)]
        public void AUT_OrRequestSpecification_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OrRequestSpecification) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldspecifications)]
        public void AUT_OrRequestSpecification_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OrRequestSpecification) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OrRequestSpecification_Is_Instance_Present_Test()
        {
            // Assert
            _orRequestSpecificationInstanceType.ShouldNotBeNull();
            _orRequestSpecificationInstance.ShouldNotBeNull();
            _orRequestSpecificationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OrRequestSpecification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OrRequestSpecification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _orRequestSpecificationInstance.ShouldBeAssignableTo<OrRequestSpecification>();
            _orRequestSpecificationInstanceFixture.ShouldBeAssignableTo<OrRequestSpecification>();
            CurrentInstance.ShouldBeAssignableTo<OrRequestSpecification>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OrRequestSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var specifications = this.CreateType<IRequestSpecification[]>();
            OrRequestSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OrRequestSpecification(specifications);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _orRequestSpecificationInstance.ShouldNotBeNull();
            _orRequestSpecificationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OrRequestSpecification>();
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var specifications = this.CreateType<IRequestSpecification[]>();
            OrRequestSpecification instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OrRequestSpecification(specifications);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _orRequestSpecificationInstance.ShouldNotBeNull();
            _orRequestSpecificationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) instance created

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_Is_Created_Test()
        {
            // Assert
            _orRequestSpecificationInstance.ShouldNotBeNull();
            _orRequestSpecificationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OrRequestSpecification" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OrRequestSpecification_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OrRequestSpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OrRequestSpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOrRequestSpecificationParametersTypes = new Type[] { typeof(IRequestSpecification[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOrRequestSpecificationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OrRequestSpecification) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OrRequestSpecification" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OrRequestSpecification_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOrRequestSpecificationParametersTypes = new Type[] { typeof(IEnumerable<IRequestSpecification>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOrRequestSpecificationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OrRequestSpecification) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySpecifications)]
        public void AUT_OrRequestSpecification_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OrRequestSpecification) => Property (Specifications) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OrRequestSpecification_Public_Class_Specifications_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySpecifications);
            var propertyInfo = this.GetPropertyInfo(PropertySpecifications);

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

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Internally(Type[] types)
        {
            var methodIsSatisfiedByParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();

            // Act
            Action executeAction = () => _orRequestSpecificationInstance.IsSatisfiedBy(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_orRequestSpecificationInstanceFixture, parametersOfIsSatisfiedBy);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_orRequestSpecificationInstanceFixture, out exception1, parametersOfIsSatisfiedBy);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_orRequestSpecificationInstanceFixture, parametersOfIsSatisfiedBy);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var request = this.CreateType<object>();
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfIsSatisfiedBy = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsSatisfiedBy, parametersOfIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            parametersOfIsSatisfiedBy.ShouldNotBeNull();
            parametersOfIsSatisfiedBy.Length.ShouldBe(1);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodIsSatisfiedByParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsSatisfiedBy, methodIsSatisfiedByParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsSatisfiedByParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsSatisfiedBy) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OrRequestSpecification_IsSatisfiedBy_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSatisfiedBy);
            var methodInfo = this.GetMethodInfo(MethodIsSatisfiedBy, 0);
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
namespace AutoFixture.DataAnnotations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
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
    using AutoFixture.DataAnnotations;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.DataAnnotations.RangedRequest" />)
    ///     and namespace <see cref="AutoFixture.DataAnnotations"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RangedRequestTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RangedRequest" />)
        /// </summary>
        public RangedRequestTest() : base(typeof(RangedRequest))
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

        #region General Initializer : Class (RangedRequest) Initializer

        #region General Initializer : Class (RangedRequest) One time setup

        private Type _rangedRequestInstanceType;
        private RangedRequest _rangedRequestInstance;
        private RangedRequest _rangedRequestInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="RangedRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _rangedRequestInstanceType = typeof(RangedRequest);
            _rangedRequestInstanceFixture = this.Create<RangedRequest>(true);
            _rangedRequestInstance = _rangedRequestInstanceFixture ?? this.Create<RangedRequest>(false);
            CurrentInstance = _rangedRequestInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyMemberType = "MemberType";
        private const string PropertyOperandType = "OperandType";
        private const string PropertyMinimum = "Minimum";
        private const string PropertyMaximum = "Maximum";

        #endregion

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";
        private const string MethodGetConvertedMinimum = "GetConvertedMinimum";
        private const string MethodGetConvertedMaximum = "GetConvertedMaximum";
        private const string MethodToString = "ToString";
        private const string MethodGetConvertedRangeBoundary = "GetConvertedRangeBoundary";

        #endregion

        #endregion

        #region General Initializer : Class (RangedRequest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        public void AUT_RangedRequest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RangedRequest) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        public void AUT_RangedRequest_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (RangedRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        public void AUT_RangedRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RangedRequest)

        #region General Initializer : Class (RangedRequest) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodEquals, 1)]
        [TestCase(MethodGetHashCode, 0)]
        [TestCase(MethodGetConvertedMinimum, 0)]
        [TestCase(MethodGetConvertedMaximum, 0)]
        [TestCase(MethodToString, 0)]
        [TestCase(MethodGetConvertedRangeBoundary, 0)]
        public void AUT_RangedRequest_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RangedRequest) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyMemberType)]
        [TestCase(PropertyOperandType)]
        [TestCase(PropertyMinimum)]
        [TestCase(PropertyMaximum)]
        public void AUT_RangedRequest_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RangedRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RangedRequest_Is_Instance_Present_Test()
        {
            // Assert
            _rangedRequestInstanceType.ShouldNotBeNull();
            _rangedRequestInstance.ShouldNotBeNull();
            _rangedRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RangedRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RangedRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RangedRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _rangedRequestInstance.ShouldBeAssignableTo<RangedRequest>();
            _rangedRequestInstanceFixture.ShouldBeAssignableTo<RangedRequest>();
            CurrentInstance.ShouldBeAssignableTo<RangedRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RangedRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_RangedRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var memberType = this.CreateType<Type>();
            var operandType = this.CreateType<Type>();
            var minimum = this.CreateType<object>();
            var maximum = this.CreateType<object>();
            RangedRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new RangedRequest(memberType, operandType, minimum, maximum);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _rangedRequestInstance.ShouldNotBeNull();
            _rangedRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<RangedRequest>();
        }

        #endregion

        #region General Constructor : Class (RangedRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_RangedRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var memberType = this.CreateType<Type>();
            var operandType = this.CreateType<Type>();
            var minimum = this.CreateType<object>();
            var maximum = this.CreateType<object>();
            RangedRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new RangedRequest(memberType, operandType, minimum, maximum);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _rangedRequestInstance.ShouldNotBeNull();
            _rangedRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RangedRequest) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyMemberType)]
        [TestCase(PropertyOperandType)]
        [TestCase(PropertyMinimum)]
        [TestCase(PropertyMaximum)]
        public void AUT_RangedRequest_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RangedRequest) => Property (Maximum) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Maximum_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaximum);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMaximum);
            Action currentAction = () => propertyInfo.SetValue(_rangedRequestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (Maximum) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Public_Class_Maximum_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaximum);
            var propertyInfo = this.GetPropertyInfo(PropertyMaximum);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (MemberType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_MemberType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMemberType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMemberType);
            Action currentAction = () => propertyInfo.SetValue(_rangedRequestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (MemberType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Public_Class_MemberType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMemberType);
            var propertyInfo = this.GetPropertyInfo(PropertyMemberType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (Minimum) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Minimum_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMinimum);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMinimum);
            Action currentAction = () => propertyInfo.SetValue(_rangedRequestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (Minimum) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Public_Class_Minimum_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMinimum);
            var propertyInfo = this.GetPropertyInfo(PropertyMinimum);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (OperandType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_OperandType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOperandType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOperandType);
            Action currentAction = () => propertyInfo.SetValue(_rangedRequestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RangedRequest) => Property (OperandType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RangedRequest_Public_Class_OperandType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOperandType);
            var propertyInfo = this.GetPropertyInfo(PropertyOperandType);

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

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_Equals_Method_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();

            // Act
            Action executeAction = () => _rangedRequestInstance.Equals(obj);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_rangedRequestInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_rangedRequestInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_Equals_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<RangedRequest>();

            // Act
            Action executeAction = () => _rangedRequestInstance.Equals(other);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<RangedRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };
            object[] parametersOfEquals = { other };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_rangedRequestInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<RangedRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };
            object[] parametersOfEquals = { other };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_rangedRequestInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<RangedRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };
            object[] parametersOfEquals = { other };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var other = this.CreateType<RangedRequest>();
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };
            object[] parametersOfEquals = { other };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(RangedRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_Equals_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);

            // Act
            Action executeAction = () => _rangedRequestInstance.GetHashCode();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_rangedRequestInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_rangedRequestInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfGetHashCode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_GetConvertedMinimum_Method_Call_Internally(Type[] types)
        {
            var methodGetConvertedMinimumParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConvertedMinimum, methodGetConvertedMinimumParametersTypes);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var targetType = this.CreateType<Type>();

            // Act
            Action executeAction = () => _rangedRequestInstance.GetConvertedMinimum(targetType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var targetType = this.CreateType<Type>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _rangedRequestInstance.GetConvertedMinimum(targetType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMinimumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMinimum = { targetType };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMinimum, methodGetConvertedMinimumParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_rangedRequestInstanceFixture, out exception1, parametersOfGetConvertedMinimum);
            var result2 = this.GetResultOfMethod<object>(MethodGetConvertedMinimum, parametersOfGetConvertedMinimum, methodGetConvertedMinimumParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConvertedMinimum.ShouldNotBeNull();
            parametersOfGetConvertedMinimum.Length.ShouldBe(1);
            methodGetConvertedMinimumParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMinimumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMinimum = { targetType };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMinimum, methodGetConvertedMinimumParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfGetConvertedMinimum);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConvertedMinimum.ShouldNotBeNull();
            parametersOfGetConvertedMinimum.Length.ShouldBe(1);
            methodGetConvertedMinimumParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMinimumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMinimum = { targetType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetConvertedMinimum, parametersOfGetConvertedMinimum, methodGetConvertedMinimumParametersTypes);

            // Assert
            parametersOfGetConvertedMinimum.ShouldNotBeNull();
            parametersOfGetConvertedMinimum.Length.ShouldBe(1);
            methodGetConvertedMinimumParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var methodGetConvertedMinimumParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConvertedMinimum, methodGetConvertedMinimumParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConvertedMinimumParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var methodGetConvertedMinimumParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConvertedMinimum, methodGetConvertedMinimumParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConvertedMinimumParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMinimum, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedMinimum) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMinimum_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMinimum);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMinimum, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_GetConvertedMaximum_Method_Call_Internally(Type[] types)
        {
            var methodGetConvertedMaximumParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConvertedMaximum, methodGetConvertedMaximumParametersTypes);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var targetType = this.CreateType<Type>();

            // Act
            Action executeAction = () => _rangedRequestInstance.GetConvertedMaximum(targetType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var targetType = this.CreateType<Type>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _rangedRequestInstance.GetConvertedMaximum(targetType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMaximumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMaximum = { targetType };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMaximum, methodGetConvertedMaximumParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<object>(_rangedRequestInstanceFixture, out exception1, parametersOfGetConvertedMaximum);
            var result2 = this.GetResultOfMethod<object>(MethodGetConvertedMaximum, parametersOfGetConvertedMaximum, methodGetConvertedMaximumParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConvertedMaximum.ShouldNotBeNull();
            parametersOfGetConvertedMaximum.Length.ShouldBe(1);
            methodGetConvertedMaximumParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMaximumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMaximum = { targetType };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMaximum, methodGetConvertedMaximumParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfGetConvertedMaximum);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConvertedMaximum.ShouldNotBeNull();
            parametersOfGetConvertedMaximum.Length.ShouldBe(1);
            methodGetConvertedMaximumParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var targetType = this.CreateType<Type>();
            var methodGetConvertedMaximumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetConvertedMaximum = { targetType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetConvertedMaximum, parametersOfGetConvertedMaximum, methodGetConvertedMaximumParametersTypes);

            // Assert
            parametersOfGetConvertedMaximum.ShouldNotBeNull();
            parametersOfGetConvertedMaximum.Length.ShouldBe(1);
            methodGetConvertedMaximumParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var methodGetConvertedMaximumParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConvertedMaximum, methodGetConvertedMaximumParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConvertedMaximumParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var methodGetConvertedMaximumParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConvertedMaximum, methodGetConvertedMaximumParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConvertedMaximumParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMaximum, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedMaximum) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedMaximum_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedMaximum);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedMaximum, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_ToString_Method_Call_Internally(Type[] types)
        {
            var methodToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _rangedRequestInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _rangedRequestInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<string>(_rangedRequestInstanceFixture, out exception1, parametersOfToString);
            var result2 = this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfToString);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_ToString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var methodInfo = this.GetMethodInfo(MethodToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetConvertedRangeBoundaryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConvertedRangeBoundary, methodGetConvertedRangeBoundaryParametersTypes);
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var attributeValue = this.CreateType<object>();
            var conversionType = this.CreateType<Type>();
            var methodGetConvertedRangeBoundaryParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfGetConvertedRangeBoundary = { attributeValue, conversionType };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetConvertedRangeBoundary, methodGetConvertedRangeBoundaryParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_rangedRequestInstanceFixture, parametersOfGetConvertedRangeBoundary);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConvertedRangeBoundary.ShouldNotBeNull();
            parametersOfGetConvertedRangeBoundary.Length.ShouldBe(2);
            methodGetConvertedRangeBoundaryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var attributeValue = this.CreateType<object>();
            var conversionType = this.CreateType<Type>();
            var methodGetConvertedRangeBoundaryParametersTypes = new Type[] { typeof(object), typeof(Type) };
            object[] parametersOfGetConvertedRangeBoundary = { attributeValue, conversionType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetConvertedRangeBoundary, parametersOfGetConvertedRangeBoundary, methodGetConvertedRangeBoundaryParametersTypes);

            // Assert
            parametersOfGetConvertedRangeBoundary.ShouldNotBeNull();
            parametersOfGetConvertedRangeBoundary.Length.ShouldBe(2);
            methodGetConvertedRangeBoundaryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var methodGetConvertedRangeBoundaryParametersTypes = new Type[] { typeof(object), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConvertedRangeBoundary, methodGetConvertedRangeBoundaryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConvertedRangeBoundaryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var methodGetConvertedRangeBoundaryParametersTypes = new Type[] { typeof(object), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConvertedRangeBoundary, methodGetConvertedRangeBoundaryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConvertedRangeBoundaryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedRangeBoundary, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConvertedRangeBoundary) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_RangedRequest_GetConvertedRangeBoundary_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConvertedRangeBoundary);
            var methodInfo = this.GetMethodInfo(MethodGetConvertedRangeBoundary, 0);
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
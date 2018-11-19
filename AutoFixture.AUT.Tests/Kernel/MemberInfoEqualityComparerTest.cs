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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MemberInfoEqualityComparer" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    ///     Hangs
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MemberInfoEqualityComparerTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MemberInfoEqualityComparer" />)
        /// </summary>
        public MemberInfoEqualityComparerTest() : base(typeof(MemberInfoEqualityComparer))
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

        #region General Initializer : Class (MemberInfoEqualityComparer) Initializer

        #region General Initializer : Class (MemberInfoEqualityComparer) One time setup

        private Type _memberInfoEqualityComparerInstanceType;
        private MemberInfoEqualityComparer _memberInfoEqualityComparerInstance;
        private MemberInfoEqualityComparer _memberInfoEqualityComparerInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MemberInfoEqualityComparer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _memberInfoEqualityComparerInstanceType = typeof(MemberInfoEqualityComparer);
            _memberInfoEqualityComparerInstanceFixture = this.Create<MemberInfoEqualityComparer>(true);
            _memberInfoEqualityComparerInstance = _memberInfoEqualityComparerInstanceFixture ?? this.Create<MemberInfoEqualityComparer>(false);
            CurrentInstance = _memberInfoEqualityComparerInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";
        private const string MethodAreTypesRelated = "AreTypesRelated";

        #endregion

        #endregion

        #region General Initializer : Class (MemberInfoEqualityComparer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MemberInfoEqualityComparer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MemberInfoEqualityComparer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MemberInfoEqualityComparer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (MemberInfoEqualityComparer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MemberInfoEqualityComparer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MemberInfoEqualityComparer)

        #region General Initializer : Class (MemberInfoEqualityComparer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        [TestCase(MethodEquals, 1)]
        [TestCase(MethodGetHashCode, 1)]
        [TestCase(MethodAreTypesRelated, 0)]
        public void AUT_MemberInfoEqualityComparer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MemberInfoEqualityComparer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MemberInfoEqualityComparer_Is_Instance_Present_Test()
        {
            // Assert
            _memberInfoEqualityComparerInstanceType.ShouldNotBeNull();
            _memberInfoEqualityComparerInstance.ShouldNotBeNull();
            _memberInfoEqualityComparerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MemberInfoEqualityComparer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MemberInfoEqualityComparer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MemberInfoEqualityComparer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _memberInfoEqualityComparerInstance.ShouldBeAssignableTo<MemberInfoEqualityComparer>();
            _memberInfoEqualityComparerInstanceFixture.ShouldBeAssignableTo<MemberInfoEqualityComparer>();
            CurrentInstance.ShouldBeAssignableTo<MemberInfoEqualityComparer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MemberInfoEqualityComparer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberInfoEqualityComparer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MemberInfoEqualityComparer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();

            // Act
            Action executeAction = () => _memberInfoEqualityComparerInstance.Equals(x, y);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();

            // Act
            Action executeAction = () => _memberInfoEqualityComparerInstance.Equals(x, y);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };
            object[] parametersOfEquals = { x, y };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_memberInfoEqualityComparerInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };
            object[] parametersOfEquals = { x, y };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_memberInfoEqualityComparerInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };
            object[] parametersOfEquals = { x, y };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<MemberInfo>();
            var y = this.CreateType<MemberInfo>();
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };
            object[] parametersOfEquals = { x, y };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(MemberInfo), typeof(MemberInfo) };
            const int parametersCount = 2;

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
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();

            // Act
            Action executeAction = () => _memberInfoEqualityComparerInstance.GetHashCode(obj);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();

            // Act
            Action executeAction = () => _memberInfoEqualityComparerInstance.GetHashCode(obj);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_memberInfoEqualityComparerInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_memberInfoEqualityComparerInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfGetHashCode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<MemberInfo>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetHashCode = { obj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(MemberInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberInfoEqualityComparer_Equals_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<object>();
            var y = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfEquals = { x, y };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_memberInfoEqualityComparerInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<object>();
            var y = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfEquals = { x, y };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_memberInfoEqualityComparerInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<object>();
            var y = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfEquals = { x, y };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var x = this.CreateType<object>();
            var y = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfEquals = { x, y };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object), typeof(object) };
            const int parametersCount = 2;

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
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_Equals_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodInfo = this.GetMethodInfo(MethodEquals, 1);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<object>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_memberInfoEqualityComparerInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<object>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_memberInfoEqualityComparerInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<object>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetHashCode = { obj };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfGetHashCode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var obj = this.CreateType<object>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetHashCode = { obj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_GetHashCode_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodInfo = this.GetMethodInfo(MethodGetHashCode, 1);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Internally(Type[] types)
        {
            var methodAreTypesRelatedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var x = this.CreateType<Type>();
            var y = this.CreateType<Type>();
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfAreTypesRelated = { x, y };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodAreTypesRelated, parametersOfAreTypesRelated, methodAreTypesRelatedParametersTypes);
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfAreTypesRelated);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAreTypesRelated.ShouldNotBeNull();
            parametersOfAreTypesRelated.Length.ShouldBe(2);
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var x = this.CreateType<Type>();
            var y = this.CreateType<Type>();
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfAreTypesRelated = { x, y };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodAreTypesRelated, parametersOfAreTypesRelated, methodAreTypesRelatedParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAreTypesRelated.ShouldNotBeNull();
            parametersOfAreTypesRelated.Length.ShouldBe(2);
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodAreTypesRelated, parametersOfAreTypesRelated, methodAreTypesRelatedParametersTypes));
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var x = this.CreateType<Type>();
            var y = this.CreateType<Type>();
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfAreTypesRelated = { x, y };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_memberInfoEqualityComparerInstanceFixture, parametersOfAreTypesRelated);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAreTypesRelated.ShouldNotBeNull();
            parametersOfAreTypesRelated.Length.ShouldBe(2);
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var x = this.CreateType<Type>();
            var y = this.CreateType<Type>();
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfAreTypesRelated = { x, y };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAreTypesRelated, parametersOfAreTypesRelated, methodAreTypesRelatedParametersTypes);

            // Assert
            parametersOfAreTypesRelated.ShouldNotBeNull();
            parametersOfAreTypesRelated.Length.ShouldBe(2);
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodAreTypesRelatedParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAreTypesRelated, methodAreTypesRelatedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAreTypesRelatedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AreTypesRelated) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberInfoEqualityComparer_AreTypesRelated_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAreTypesRelated);
            var methodInfo = this.GetMethodInfo(MethodAreTypesRelated, 0);
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
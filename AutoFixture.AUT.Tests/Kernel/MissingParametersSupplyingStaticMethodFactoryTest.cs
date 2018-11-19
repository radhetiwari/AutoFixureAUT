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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.MissingParametersSupplyingStaticMethodFactory" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MissingParametersSupplyingStaticMethodFactoryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MissingParametersSupplyingStaticMethodFactory" />)
        /// </summary>
        public MissingParametersSupplyingStaticMethodFactoryTest() : base(typeof(MissingParametersSupplyingStaticMethodFactory))
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

        #region General Initializer : Class (MissingParametersSupplyingStaticMethodFactory) Initializer

        #region General Initializer : Class (MissingParametersSupplyingStaticMethodFactory) One time setup

        private Type _missingParametersSupplyingStaticMethodFactoryInstanceType;
        private MissingParametersSupplyingStaticMethodFactory _missingParametersSupplyingStaticMethodFactoryInstance;
        private MissingParametersSupplyingStaticMethodFactory _missingParametersSupplyingStaticMethodFactoryInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MissingParametersSupplyingStaticMethodFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _missingParametersSupplyingStaticMethodFactoryInstanceType = typeof(MissingParametersSupplyingStaticMethodFactory);
            _missingParametersSupplyingStaticMethodFactoryInstanceFixture = this.Create<MissingParametersSupplyingStaticMethodFactory>(true);
            _missingParametersSupplyingStaticMethodFactoryInstance = _missingParametersSupplyingStaticMethodFactoryInstanceFixture ?? this.Create<MissingParametersSupplyingStaticMethodFactory>(false);
            CurrentInstance = _missingParametersSupplyingStaticMethodFactoryInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreate = "Create";

        #endregion

        #endregion

        #region General Initializer : Class (MissingParametersSupplyingStaticMethodFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingStaticMethodFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MissingParametersSupplyingStaticMethodFactory)

        #region General Initializer : Class (MissingParametersSupplyingStaticMethodFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingStaticMethodFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreate, 0)]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MissingParametersSupplyingStaticMethodFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingStaticMethodFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Is_Instance_Present_Test()
        {
            // Assert
            _missingParametersSupplyingStaticMethodFactoryInstanceType.ShouldNotBeNull();
            _missingParametersSupplyingStaticMethodFactoryInstance.ShouldNotBeNull();
            _missingParametersSupplyingStaticMethodFactoryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MissingParametersSupplyingStaticMethodFactory) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MissingParametersSupplyingStaticMethodFactory" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _missingParametersSupplyingStaticMethodFactoryInstance.ShouldBeAssignableTo<MissingParametersSupplyingStaticMethodFactory>();
            _missingParametersSupplyingStaticMethodFactoryInstanceFixture.ShouldBeAssignableTo<MissingParametersSupplyingStaticMethodFactory>();
            CurrentInstance.ShouldBeAssignableTo<MissingParametersSupplyingStaticMethodFactory>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MissingParametersSupplyingStaticMethodFactory) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MissingParametersSupplyingStaticMethodFactory instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Create) (Return Type : IMethod) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.CreateType<MethodInfo>();

            // Act
            Action executeAction = () => _missingParametersSupplyingStaticMethodFactoryInstance.Create(methodInfo);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodInfo = this.CreateType<MethodInfo>();
            var returnedValue = default(IMethod);

            // Act
            Action executeAction = () => returnedValue = _missingParametersSupplyingStaticMethodFactoryInstance.Create(methodInfo);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : IMethod) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_MissingParametersSupplyingStaticMethodFactory_Create_Method_Call_Parameters_Count_Verification_Test()
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
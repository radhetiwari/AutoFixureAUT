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
    using AutoFixture.Dsl;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture.Kernel;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.SpecimenBuilderNodeFactory" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenBuilderNodeFactoryTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenBuilderNodeFactory" />)
        /// </summary>
        public SpecimenBuilderNodeFactoryTest() : base(typeof(SpecimenBuilderNodeFactory))
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

        #region General Initializer : Class (SpecimenBuilderNodeFactory) Initializer

        #region General Initializer : Class (SpecimenBuilderNodeFactory) One time setup

        private Type _specimenBuilderNodeFactoryInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenBuilderNodeFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenBuilderNodeFactoryInstanceType = typeof(SpecimenBuilderNodeFactory);
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCreateComposer = "CreateComposer";
        private const string MethodCreateTypedNode = "CreateTypedNode";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenBuilderNodeFactory)

        #region General Initializer : Class (SpecimenBuilderNodeFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateTypedNode, 0)]
        public void AUT_SpecimenBuilderNodeFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SpecimenBuilderNodeFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNodeFactory_Is_Static_Type_Present_Test()
        {
            // Assert
            _specimenBuilderNodeFactoryInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateTypedNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateTypedNode, methodCreateTypedNodeParametersTypes);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var targetType = this.CreateType<Type>();
            var factory = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => SpecimenBuilderNodeFactory.CreateTypedNode(targetType, factory);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var targetType = this.CreateType<Type>();
            var factory = this.CreateType<ISpecimenBuilder>();
            var returnedValue = default(FilteringSpecimenBuilder);

            // Act
            Action executeAction = () => returnedValue = SpecimenBuilderNodeFactory.CreateTypedNode(targetType, factory);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var targetType = this.CreateType<Type>();
            var factory = this.CreateType<ISpecimenBuilder>();
            var methodCreateTypedNodeParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenBuilder) };
            object[] parametersOfCreateTypedNode = { targetType, factory };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCreateTypedNode, methodCreateTypedNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfCreateTypedNode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateTypedNode.ShouldNotBeNull();
            parametersOfCreateTypedNode.Length.ShouldBe(2);
            methodCreateTypedNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var targetType = this.CreateType<Type>();
            var factory = this.CreateType<ISpecimenBuilder>();
            var methodCreateTypedNodeParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenBuilder) };
            object[] parametersOfCreateTypedNode = { targetType, factory };

            // Act
            Action currentAction = () => this.GetResultOfMethod<FilteringSpecimenBuilder>(MethodCreateTypedNode, parametersOfCreateTypedNode, methodCreateTypedNodeParametersTypes);

            // Assert
            parametersOfCreateTypedNode.ShouldNotBeNull();
            parametersOfCreateTypedNode.Length.ShouldBe(2);
            methodCreateTypedNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var methodCreateTypedNodeParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenBuilder) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateTypedNode, methodCreateTypedNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateTypedNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var methodCreateTypedNodeParametersTypes = new Type[] { typeof(Type), typeof(ISpecimenBuilder) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateTypedNode, methodCreateTypedNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateTypedNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var methodInfo = this.GetMethodInfo(MethodCreateTypedNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateTypedNode) (Return Type : FilteringSpecimenBuilder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeFactory_CreateTypedNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateTypedNode);
            var methodInfo = this.GetMethodInfo(MethodCreateTypedNode, 0);
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
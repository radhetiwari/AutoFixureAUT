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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.SpecimenBuilderNode" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenBuilderNodeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenBuilderNode" />)
        /// </summary>
        public SpecimenBuilderNodeTest() : base(typeof(SpecimenBuilderNode))
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

        #region General Initializer : Class (SpecimenBuilderNode) Initializer

        #region General Initializer : Class (SpecimenBuilderNode) One time setup

        private Type _specimenBuilderNodeInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenBuilderNode" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenBuilderNodeInstanceType = typeof(SpecimenBuilderNode);
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodGraphEquals = "GraphEquals";
        private const string MethodReplaceNodes = "ReplaceNodes";
        private const string MethodFindFirstNodeOrDefault = "FindFirstNodeOrDefault";
        private const string MethodFindFirstNode = "FindFirstNode";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenBuilderNode) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNode" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNode_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenBuilderNode)

        #region General Initializer : Class (SpecimenBuilderNode) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNode" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGraphEquals, 0)]
        [TestCase(MethodGraphEquals, 1)]
        [TestCase(MethodReplaceNodes, 0)]
        [TestCase(MethodReplaceNodes, 1)]
        [TestCase(MethodReplaceNodes, 2)]
        [TestCase(MethodFindFirstNodeOrDefault, 0)]
        [TestCase(MethodFindFirstNode, 0)]
        public void AUT_SpecimenBuilderNode_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SpecimenBuilderNode) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNode" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNode_Is_Static_Type_Present_Test()
        {
            // Assert
            _specimenBuilderNodeInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GraphEquals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Internally(Type[] types)
        {
            var methodGraphEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGraphEquals, methodGraphEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();

            // Act
            Action executeAction = () => SpecimenBuilderNode.GraphEquals(first, second);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode) };
            object[] parametersOfGraphEquals = { first, second };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, methodGraphEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfGraphEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGraphEquals.ShouldNotBeNull();
            parametersOfGraphEquals.Length.ShouldBe(2);
            methodGraphEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode) };
            object[] parametersOfGraphEquals = { first, second };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGraphEquals, parametersOfGraphEquals, methodGraphEqualsParametersTypes);

            // Assert
            parametersOfGraphEquals.ShouldNotBeNull();
            parametersOfGraphEquals.Length.ShouldBe(2);
            methodGraphEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGraphEquals, methodGraphEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGraphEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGraphEqualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGraphEquals, methodGraphEqualsParametersTypes);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();
            var comparer = this.CreateType<IEqualityComparer<ISpecimenBuilder>>();

            // Act
            Action executeAction = () => SpecimenBuilderNode.GraphEquals(first, second, comparer);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();
            var comparer = this.CreateType<IEqualityComparer<ISpecimenBuilder>>();
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(IEqualityComparer<ISpecimenBuilder>) };
            object[] parametersOfGraphEquals = { first, second, comparer };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, methodGraphEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfGraphEquals);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGraphEquals.ShouldNotBeNull();
            parametersOfGraphEquals.Length.ShouldBe(3);
            methodGraphEqualsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var first = this.CreateType<ISpecimenBuilderNode>();
            var second = this.CreateType<ISpecimenBuilderNode>();
            var comparer = this.CreateType<IEqualityComparer<ISpecimenBuilder>>();
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(IEqualityComparer<ISpecimenBuilder>) };
            object[] parametersOfGraphEquals = { first, second, comparer };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGraphEquals, parametersOfGraphEquals, methodGraphEqualsParametersTypes);

            // Assert
            parametersOfGraphEquals.ShouldNotBeNull();
            parametersOfGraphEquals.Length.ShouldBe(3);
            methodGraphEqualsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodGraphEqualsParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(IEqualityComparer<ISpecimenBuilder>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGraphEquals, methodGraphEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGraphEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GraphEquals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_GraphEquals_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGraphEquals);
            var methodInfo = this.GetMethodInfo(MethodGraphEquals, 1);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Internally(Type[] types)
        {
            var methodReplaceNodesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilder>), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, methodReplaceNodesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfReplaceNodes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilder>), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodReplaceNodes, parametersOfReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilder>), typeof(Func<ISpecimenBuilderNode, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(IEnumerable<ISpecimenBuilder>), typeof(Func<ISpecimenBuilderNode, bool>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReplaceNodesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 0);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodReplaceNodesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<ISpecimenBuilderNode>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, methodReplaceNodesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfReplaceNodes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<ISpecimenBuilderNode>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodReplaceNodes, parametersOfReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReplaceNodesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 1);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 1);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodReplaceNodesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<Func<ISpecimenBuilderNode, ISpecimenBuilderNode>>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, ISpecimenBuilderNode>), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, methodReplaceNodesParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfReplaceNodes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var with = this.CreateType<Func<ISpecimenBuilderNode, ISpecimenBuilderNode>>();
            var when = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, ISpecimenBuilderNode>), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfReplaceNodes = { graph, with, when };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodReplaceNodes, parametersOfReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            parametersOfReplaceNodes.ShouldNotBeNull();
            parametersOfReplaceNodes.Length.ShouldBe(3);
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, ISpecimenBuilderNode>), typeof(Func<ISpecimenBuilderNode, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReplaceNodesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodReplaceNodesParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, ISpecimenBuilderNode>), typeof(Func<ISpecimenBuilderNode, bool>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReplaceNodes, methodReplaceNodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReplaceNodesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 2);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ReplaceNodes) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_ReplaceNodes_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceNodes);
            var methodInfo = this.GetMethodInfo(MethodReplaceNodes, 2);
            const int parametersCount = 3;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_Internally(Type[] types)
        {
            var methodFindFirstNodeOrDefaultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindFirstNodeOrDefault, methodFindFirstNodeOrDefaultParametersTypes);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var predicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodFindFirstNodeOrDefaultParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfFindFirstNodeOrDefault = { graph, predicate };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodFindFirstNodeOrDefault, methodFindFirstNodeOrDefaultParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfFindFirstNodeOrDefault);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFindFirstNodeOrDefault.ShouldNotBeNull();
            parametersOfFindFirstNodeOrDefault.Length.ShouldBe(2);
            methodFindFirstNodeOrDefaultParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var predicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodFindFirstNodeOrDefaultParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfFindFirstNodeOrDefault = { graph, predicate };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindFirstNodeOrDefault, parametersOfFindFirstNodeOrDefault, methodFindFirstNodeOrDefaultParametersTypes);

            // Assert
            parametersOfFindFirstNodeOrDefault.ShouldNotBeNull();
            parametersOfFindFirstNodeOrDefault.Length.ShouldBe(2);
            methodFindFirstNodeOrDefaultParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var methodFindFirstNodeOrDefaultParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindFirstNodeOrDefault, methodFindFirstNodeOrDefaultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindFirstNodeOrDefaultParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var methodFindFirstNodeOrDefaultParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindFirstNodeOrDefault, methodFindFirstNodeOrDefaultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindFirstNodeOrDefaultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var methodInfo = this.GetMethodInfo(MethodFindFirstNodeOrDefault, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindFirstNodeOrDefault) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNodeOrDefault_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNodeOrDefault);
            var methodInfo = this.GetMethodInfo(MethodFindFirstNodeOrDefault, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodFindFirstNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindFirstNode, methodFindFirstNodeParametersTypes);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var predicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodFindFirstNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfFindFirstNode = { graph, predicate };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodFindFirstNode, methodFindFirstNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(null, parametersOfFindFirstNode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFindFirstNode.ShouldNotBeNull();
            parametersOfFindFirstNode.Length.ShouldBe(2);
            methodFindFirstNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var predicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var methodFindFirstNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            object[] parametersOfFindFirstNode = { graph, predicate };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindFirstNode, parametersOfFindFirstNode, methodFindFirstNodeParametersTypes);

            // Assert
            parametersOfFindFirstNode.ShouldNotBeNull();
            parametersOfFindFirstNode.Length.ShouldBe(2);
            methodFindFirstNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var methodFindFirstNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindFirstNode, methodFindFirstNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindFirstNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var methodFindFirstNodeParametersTypes = new Type[] { typeof(ISpecimenBuilderNode), typeof(Func<ISpecimenBuilderNode, bool>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindFirstNode, methodFindFirstNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindFirstNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var methodInfo = this.GetMethodInfo(MethodFindFirstNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindFirstNode) (Return Type : ISpecimenBuilderNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNode_FindFirstNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindFirstNode);
            var methodInfo = this.GetMethodInfo(MethodFindFirstNode, 0);
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
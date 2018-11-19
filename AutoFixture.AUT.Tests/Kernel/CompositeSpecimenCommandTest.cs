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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.CompositeSpecimenCommand" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CompositeSpecimenCommandTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CompositeSpecimenCommand" />)
        /// </summary>
        public CompositeSpecimenCommandTest() : base(typeof(CompositeSpecimenCommand))
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

        #region General Initializer : Class (CompositeSpecimenCommand) Initializer

        #region General Initializer : Class (CompositeSpecimenCommand) One time setup

        private Type _compositeSpecimenCommandInstanceType;
        private CompositeSpecimenCommand _compositeSpecimenCommandInstance;
        private CompositeSpecimenCommand _compositeSpecimenCommandInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="CompositeSpecimenCommand" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _compositeSpecimenCommandInstanceType = typeof(CompositeSpecimenCommand);
            _compositeSpecimenCommandInstanceFixture = this.Create<CompositeSpecimenCommand>(true);
            _compositeSpecimenCommandInstance = _compositeSpecimenCommandInstanceFixture ?? this.Create<CompositeSpecimenCommand>(false);
            CurrentInstance = _compositeSpecimenCommandInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyCommands = "Commands";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";

        #endregion

        #region Fields

        private const string Fieldcommands = "commands";

        #endregion

        #endregion

        #region General Initializer : Class (CompositeSpecimenCommand) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeSpecimenCommand_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CompositeSpecimenCommand) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeSpecimenCommand_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CompositeSpecimenCommand) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_CompositeSpecimenCommand_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CompositeSpecimenCommand)

        #region General Initializer : Class (CompositeSpecimenCommand) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        public void AUT_CompositeSpecimenCommand_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CompositeSpecimenCommand) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCommands)]
        public void AUT_CompositeSpecimenCommand_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CompositeSpecimenCommand) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcommands)]
        public void AUT_CompositeSpecimenCommand_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CompositeSpecimenCommand) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompositeSpecimenCommand_Is_Instance_Present_Test()
        {
            // Assert
            _compositeSpecimenCommandInstanceType.ShouldNotBeNull();
            _compositeSpecimenCommandInstance.ShouldNotBeNull();
            _compositeSpecimenCommandInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CompositeSpecimenCommand) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompositeSpecimenCommand_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _compositeSpecimenCommandInstance.ShouldBeAssignableTo<CompositeSpecimenCommand>();
            _compositeSpecimenCommandInstanceFixture.ShouldBeAssignableTo<CompositeSpecimenCommand>();
            CurrentInstance.ShouldBeAssignableTo<CompositeSpecimenCommand>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CompositeSpecimenCommand) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var commands = this.CreateType<IEnumerable<ISpecimenCommand>>();
            CompositeSpecimenCommand instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompositeSpecimenCommand(commands);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _compositeSpecimenCommandInstance.ShouldNotBeNull();
            _compositeSpecimenCommandInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<CompositeSpecimenCommand>();
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var commands = this.CreateType<IEnumerable<ISpecimenCommand>>();
            CompositeSpecimenCommand instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompositeSpecimenCommand(commands);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _compositeSpecimenCommandInstance.ShouldNotBeNull();
            _compositeSpecimenCommandInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) instance created

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_Is_Created_Test()
        {
            // Assert
            _compositeSpecimenCommandInstance.ShouldNotBeNull();
            _compositeSpecimenCommandInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="CompositeSpecimenCommand" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_CompositeSpecimenCommand_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="CompositeSpecimenCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CompositeSpecimenCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCompositeSpecimenCommandParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenCommand>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCompositeSpecimenCommandParametersTypes);
        }

        #endregion

        #region General Constructor : Class (CompositeSpecimenCommand) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CompositeSpecimenCommand" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompositeSpecimenCommand_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCompositeSpecimenCommandParametersTypes = new Type[] { typeof(ISpecimenCommand[]) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCompositeSpecimenCommandParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CompositeSpecimenCommand) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCommands)]
        public void AUT_CompositeSpecimenCommand_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CompositeSpecimenCommand) => Property (Commands) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CompositeSpecimenCommand_Public_Class_Commands_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCommands);
            var propertyInfo = this.GetPropertyInfo(PropertyCommands);

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

        #region Method Call : (Execute) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompositeSpecimenCommand_Execute_Method_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();

            // Act
            Action executeAction = () => _compositeSpecimenCommandInstance.Execute(specimen, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfExecute = { specimen, context };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_compositeSpecimenCommandInstanceFixture, parametersOfExecute);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var specimen = this.CreateType<object>();
            var context = this.CreateType<ISpecimenContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };
            object[] parametersOfExecute = { specimen, context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(object), typeof(ISpecimenContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompositeSpecimenCommand_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}
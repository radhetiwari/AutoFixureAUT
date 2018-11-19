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
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.ObjectCreationException" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ObjectCreationExceptionTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ObjectCreationException" />)
        /// </summary>
        public ObjectCreationExceptionTest() : base(typeof(ObjectCreationException))
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

        #region General Initializer : Class (ObjectCreationException) Initializer

        #region General Initializer : Class (ObjectCreationException) One time setup

        private Type _objectCreationExceptionInstanceType;
        private ObjectCreationException _objectCreationExceptionInstance;
        private ObjectCreationException _objectCreationExceptionInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="ObjectCreationException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _objectCreationExceptionInstanceType = typeof(ObjectCreationException);
            _objectCreationExceptionInstanceFixture = this.Create<ObjectCreationException>(true);
            _objectCreationExceptionInstance = _objectCreationExceptionInstanceFixture ?? this.Create<ObjectCreationException>(false);
            CurrentInstance = _objectCreationExceptionInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ObjectCreationException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ObjectCreationException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectCreationException_Is_Instance_Present_Test()
        {
            // Assert
            _objectCreationExceptionInstanceType.ShouldNotBeNull();
            _objectCreationExceptionInstance.ShouldNotBeNull();
            _objectCreationExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ObjectCreationException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ObjectCreationException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectCreationException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _objectCreationExceptionInstance.ShouldBeAssignableTo<ObjectCreationException>();
            _objectCreationExceptionInstanceFixture.ShouldBeAssignableTo<ObjectCreationException>();
            CurrentInstance.ShouldBeAssignableTo<ObjectCreationException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ObjectCreationException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ObjectCreationException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            ObjectCreationException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ObjectCreationException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _objectCreationExceptionInstance.ShouldNotBeNull();
            _objectCreationExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ObjectCreationException>();
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            ObjectCreationException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ObjectCreationException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _objectCreationExceptionInstance.ShouldNotBeNull();
            _objectCreationExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) instance created

        /// <summary>
        ///     Class (<see cref="ObjectCreationException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Is_Created_Test()
        {
            // Assert
            _objectCreationExceptionInstance.ShouldNotBeNull();
            _objectCreationExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ObjectCreationException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_ObjectCreationException_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ObjectCreationException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ObjectCreationException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodObjectCreationExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodObjectCreationExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ObjectCreationException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodObjectCreationExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodObjectCreationExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ObjectCreationException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ObjectCreationException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectCreationException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodObjectCreationExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodObjectCreationExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}
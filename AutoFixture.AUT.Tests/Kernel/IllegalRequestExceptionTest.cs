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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.IllegalRequestException" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IllegalRequestExceptionTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IllegalRequestException" />)
        /// </summary>
        public IllegalRequestExceptionTest() : base(typeof(IllegalRequestException))
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

        #region General Initializer : Class (IllegalRequestException) Initializer

        #region General Initializer : Class (IllegalRequestException) One time setup

        private Type _illegalRequestExceptionInstanceType;
        private IllegalRequestException _illegalRequestExceptionInstance;
        private IllegalRequestException _illegalRequestExceptionInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="IllegalRequestException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _illegalRequestExceptionInstanceType = typeof(IllegalRequestException);
            _illegalRequestExceptionInstanceFixture = this.Create<IllegalRequestException>(true);
            _illegalRequestExceptionInstance = _illegalRequestExceptionInstanceFixture ?? this.Create<IllegalRequestException>(false);
            CurrentInstance = _illegalRequestExceptionInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (IllegalRequestException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IllegalRequestException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IllegalRequestException_Is_Instance_Present_Test()
        {
            // Assert
            _illegalRequestExceptionInstanceType.ShouldNotBeNull();
            _illegalRequestExceptionInstance.ShouldNotBeNull();
            _illegalRequestExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IllegalRequestException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IllegalRequestException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IllegalRequestException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _illegalRequestExceptionInstance.ShouldBeAssignableTo<IllegalRequestException>();
            _illegalRequestExceptionInstanceFixture.ShouldBeAssignableTo<IllegalRequestException>();
            CurrentInstance.ShouldBeAssignableTo<IllegalRequestException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IllegalRequestException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IllegalRequestException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            IllegalRequestException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new IllegalRequestException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _illegalRequestExceptionInstance.ShouldNotBeNull();
            _illegalRequestExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<IllegalRequestException>();
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            IllegalRequestException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new IllegalRequestException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _illegalRequestExceptionInstance.ShouldNotBeNull();
            _illegalRequestExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) instance created

        /// <summary>
        ///     Class (<see cref="IllegalRequestException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Is_Created_Test()
        {
            // Assert
            _illegalRequestExceptionInstance.ShouldNotBeNull();
            _illegalRequestExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="IllegalRequestException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_IllegalRequestException_Constructor_Explore_Verify_By_Index_Test(int constructorIndex)
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructor(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="IllegalRequestException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = () => this.ExploreVerifyConstructors();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IllegalRequestException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodIllegalRequestExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIllegalRequestExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IllegalRequestException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodIllegalRequestExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIllegalRequestExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (IllegalRequestException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IllegalRequestException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IllegalRequestException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodIllegalRequestExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIllegalRequestExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}
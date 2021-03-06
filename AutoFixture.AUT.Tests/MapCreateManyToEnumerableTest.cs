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
    using AutoFixture.Kernel;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using AutoFixture;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.MapCreateManyToEnumerable" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MapCreateManyToEnumerableTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MapCreateManyToEnumerable" />)
        /// </summary>
        public MapCreateManyToEnumerableTest() : base(typeof(MapCreateManyToEnumerable))
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

        #region General Initializer : Class (MapCreateManyToEnumerable) Initializer

        #region General Initializer : Class (MapCreateManyToEnumerable) One time setup

        private Type _mapCreateManyToEnumerableInstanceType;
        private MapCreateManyToEnumerable _mapCreateManyToEnumerableInstance;
        private MapCreateManyToEnumerable _mapCreateManyToEnumerableInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="MapCreateManyToEnumerable" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mapCreateManyToEnumerableInstanceType = typeof(MapCreateManyToEnumerable);
            _mapCreateManyToEnumerableInstanceFixture = this.Create<MapCreateManyToEnumerable>(true);
            _mapCreateManyToEnumerableInstance = _mapCreateManyToEnumerableInstanceFixture ?? this.Create<MapCreateManyToEnumerable>(false);
            CurrentInstance = _mapCreateManyToEnumerableInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodCustomize = "Customize";

        #endregion

        #endregion

        #region General Initializer : Class (MapCreateManyToEnumerable) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MapCreateManyToEnumerable" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_MapCreateManyToEnumerable_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MapCreateManyToEnumerable)

        #region General Initializer : Class (MapCreateManyToEnumerable) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MapCreateManyToEnumerable" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCustomize, 0)]
        public void AUT_MapCreateManyToEnumerable_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MapCreateManyToEnumerable) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MapCreateManyToEnumerable" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MapCreateManyToEnumerable_Is_Instance_Present_Test()
        {
            // Assert
            _mapCreateManyToEnumerableInstanceType.ShouldNotBeNull();
            _mapCreateManyToEnumerableInstance.ShouldNotBeNull();
            _mapCreateManyToEnumerableInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MapCreateManyToEnumerable) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MapCreateManyToEnumerable" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MapCreateManyToEnumerable_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _mapCreateManyToEnumerableInstance.ShouldBeAssignableTo<MapCreateManyToEnumerable>();
            _mapCreateManyToEnumerableInstanceFixture.ShouldBeAssignableTo<MapCreateManyToEnumerable>();
            CurrentInstance.ShouldBeAssignableTo<MapCreateManyToEnumerable>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MapCreateManyToEnumerable) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MapCreateManyToEnumerable_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MapCreateManyToEnumerable instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Customize) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MapCreateManyToEnumerable_Customize_Method_Call_Internally(Type[] types)
        {
            var methodCustomizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();

            // Act
            Action executeAction = () => _mapCreateManyToEnumerableInstance.Customize(fixture);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCustomize, methodCustomizeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_mapCreateManyToEnumerableInstanceFixture, parametersOfCustomize);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var fixture = this.CreateType<IFixture>();
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };
            object[] parametersOfCustomize = { fixture };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCustomize, parametersOfCustomize, methodCustomizeParametersTypes);

            // Assert
            parametersOfCustomize.ShouldNotBeNull();
            parametersOfCustomize.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            methodCustomizeParametersTypes.Length.ShouldBe(parametersOfCustomize.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodCustomizeParametersTypes = new Type[] { typeof(IFixture) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCustomize, methodCustomizeParametersTypes);

            // Assert
            methodCustomizeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Customize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MapCreateManyToEnumerable_Customize_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCustomize);
            var methodInfo = this.GetMethodInfo(MethodCustomize, 0);

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
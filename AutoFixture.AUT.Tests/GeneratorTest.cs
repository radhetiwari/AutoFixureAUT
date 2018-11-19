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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Generator<dynamic>" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GeneratorTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Generator<dynamic>" />)
        /// </summary>
        public GeneratorTest() : base(typeof(Generator<dynamic>))
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

        #region General Initializer : Class (Generator) Initializer

        #region General Initializer : Class (Generator) One time setup

        private Type _generatorInstanceType;
        private Generator<dynamic> _generatorInstance;
        private Generator<dynamic> _generatorInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="Generator<dynamic>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _generatorInstanceType = typeof(Generator<dynamic>);
            _generatorInstanceFixture = this.Create<Generator<dynamic>>(true);
            _generatorInstance = _generatorInstanceFixture ?? this.Create<Generator<dynamic>>(false);
            CurrentInstance = _generatorInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Methods

        private const string MethodGetEnumerator = "GetEnumerator";

        #endregion

        #region Fields

        private const string Fieldbuilder = "builder";

        #endregion

        #endregion

        #region General Initializer : Class (Generator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Generator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_Generator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Generator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Generator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_Generator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Generator)

        #region General Initializer : Class (Generator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Generator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEnumerator, 0)]
        public void AUT_Generator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Generator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Generator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldbuilder)]
        public void AUT_Generator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Generator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Generator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Generator_Is_Instance_Present_Test()
        {
            // Assert
            _generatorInstanceType.ShouldNotBeNull();
            _generatorInstance.ShouldNotBeNull();
            _generatorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Generator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Generator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Generator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _generatorInstance.ShouldBeAssignableTo<Generator<dynamic>>();
            _generatorInstanceFixture.ShouldBeAssignableTo<Generator<dynamic>>();
            CurrentInstance.ShouldBeAssignableTo<Generator<dynamic>>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Generator) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Generator_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            Generator<dynamic> instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Generator<dynamic>(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _generatorInstance.ShouldNotBeNull();
            _generatorInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Generator<dynamic>>();
        }

        #endregion

        #region General Constructor : Class (Generator) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Generator_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var builder = this.CreateType<ISpecimenBuilder>();
            Generator<dynamic> instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Generator<dynamic>(builder);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _generatorInstance.ShouldNotBeNull();
            _generatorInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}
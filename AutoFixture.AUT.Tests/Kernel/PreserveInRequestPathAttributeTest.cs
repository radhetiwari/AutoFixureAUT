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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.Kernel.PreserveInRequestPathAttribute" />)
    ///     and namespace <see cref="AutoFixture.Kernel"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PreserveInRequestPathAttributeTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="PreserveInRequestPathAttributeNonPublicTypeName" />) using
        ///     Using a public type <see cref="AbstractTypeSpecification" /> to
        ///     create a non-public type.
        /// </summary>
        public PreserveInRequestPathAttributeTest() : base(publicType: typeof(AbstractTypeSpecification), classNameWithNamespace: PreserveInRequestPathAttributeNonPublicTypeName)
        {}

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PreserveInRequestPathAttribute) Initializer

        private Type _preserveInRequestPathAttributeInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _preserveInRequestPathAttributeInstance;
        private object _preserveInRequestPathAttributeInstanceFixture;
        private const string PreserveInRequestPathAttributeNonPublicTypeName = "AutoFixture.Kernel.PreserveInRequestPathAttribute";

        #region General Initializer : Class (PreserveInRequestPathAttribute) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="PreserveInRequestPathAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _preserveInRequestPathAttributeInstanceFixture = this.CreateNonPublicType(PreserveInRequestPathAttributeNonPublicTypeName);
            _preserveInRequestPathAttributeInstance = _preserveInRequestPathAttributeInstanceFixture;
            CurrentInstance = _preserveInRequestPathAttributeInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
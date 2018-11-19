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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.SpecimenBuilderNodeAdapterCollection" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SpecimenBuilderNodeAdapterCollectionTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SpecimenBuilderNodeAdapterCollection" />)
        /// </summary>
        public SpecimenBuilderNodeAdapterCollectionTest() : base(typeof(SpecimenBuilderNodeAdapterCollection))
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

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) Initializer

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) One time setup

        private Type _specimenBuilderNodeAdapterCollectionInstanceType;
        private SpecimenBuilderNodeAdapterCollection _specimenBuilderNodeAdapterCollectionInstance;
        private SpecimenBuilderNodeAdapterCollection _specimenBuilderNodeAdapterCollectionInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SpecimenBuilderNodeAdapterCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _specimenBuilderNodeAdapterCollectionInstanceType = typeof(SpecimenBuilderNodeAdapterCollection);
            _specimenBuilderNodeAdapterCollectionInstanceFixture = this.Create<SpecimenBuilderNodeAdapterCollection>(true);
            _specimenBuilderNodeAdapterCollectionInstance = _specimenBuilderNodeAdapterCollectionInstanceFixture ?? this.Create<SpecimenBuilderNodeAdapterCollection>(false);
            CurrentInstance = _specimenBuilderNodeAdapterCollectionInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyAdaptedBuilderNode = "AdaptedBuilderNode";
        private const string PropertyAdaptedBuilders = "AdaptedBuilders";
        private const string PropertyCount = "Count";
        private const string PropertyIsReadOnly = "IsReadOnly";
        private const string PropertyGraph = "Graph";

        #endregion

        #region Methods

        private const string MethodInvalidateCachedAdaptedBuilderNode = "InvalidateCachedAdaptedBuilderNode";
        private const string MethodIndexOf = "IndexOf";
        private const string MethodInsert = "Insert";
        private const string MethodRemoveAt = "RemoveAt";
        private const string MethodAdd = "Add";
        private const string MethodClear = "Clear";
        private const string MethodContains = "Contains";
        private const string MethodCopyTo = "CopyTo";
        private const string MethodRemove = "Remove";
        private const string MethodGetEnumerator = "GetEnumerator";
        private const string MethodOnGraphChanged = "OnGraphChanged";
        private const string MethodMutate = "Mutate";
        private const string MethodFindAdaptedSpecimenBuilderNode = "FindAdaptedSpecimenBuilderNode";

        #endregion

        #region Fields

        private const string FieldisAdaptedBuilder = "isAdaptedBuilder";
        private const string FieldadaptedBuilderNode = "adaptedBuilderNode";
        private const string Fieldgraph = "graph";

        #endregion

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SpecimenBuilderNodeAdapterCollection)

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInvalidateCachedAdaptedBuilderNode, 0)]
        [TestCase(MethodIndexOf, 0)]
        [TestCase(MethodInsert, 0)]
        [TestCase(MethodRemoveAt, 0)]
        [TestCase(MethodAdd, 0)]
        [TestCase(MethodClear, 0)]
        [TestCase(MethodContains, 0)]
        [TestCase(MethodCopyTo, 0)]
        [TestCase(MethodRemove, 0)]
        [TestCase(MethodGetEnumerator, 0)]
        [TestCase(MethodOnGraphChanged, 0)]
        [TestCase(MethodMutate, 0)]
        [TestCase(MethodFindAdaptedSpecimenBuilderNode, 0)]
        public void AUT_SpecimenBuilderNodeAdapterCollection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyAdaptedBuilderNode)]
        [TestCase(PropertyAdaptedBuilders)]
        [TestCase(PropertyCount)]
        [TestCase(PropertyIsReadOnly)]
        [TestCase(PropertyGraph)]
        public void AUT_SpecimenBuilderNodeAdapterCollection_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SpecimenBuilderNodeAdapterCollection) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldisAdaptedBuilder)]
        [TestCase(FieldadaptedBuilderNode)]
        [TestCase(Fieldgraph)]
        public void AUT_SpecimenBuilderNodeAdapterCollection_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SpecimenBuilderNodeAdapterCollection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Is_Instance_Present_Test()
        {
            // Assert
            _specimenBuilderNodeAdapterCollectionInstanceType.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstance.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SpecimenBuilderNodeAdapterCollection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SpecimenBuilderNodeAdapterCollection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _specimenBuilderNodeAdapterCollectionInstance.ShouldBeAssignableTo<SpecimenBuilderNodeAdapterCollection>();
            _specimenBuilderNodeAdapterCollectionInstanceFixture.ShouldBeAssignableTo<SpecimenBuilderNodeAdapterCollection>();
            CurrentInstance.ShouldBeAssignableTo<SpecimenBuilderNodeAdapterCollection>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SpecimenBuilderNodeAdapterCollection) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var adaptedBuilderPredicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            SpecimenBuilderNodeAdapterCollection instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenBuilderNodeAdapterCollection(graph, adaptedBuilderPredicate);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstance.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SpecimenBuilderNodeAdapterCollection>();
        }

        #endregion

        #region General Constructor : Class (SpecimenBuilderNodeAdapterCollection) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var adaptedBuilderPredicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            SpecimenBuilderNodeAdapterCollection instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SpecimenBuilderNodeAdapterCollection(graph, adaptedBuilderPredicate);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstance.ShouldNotBeNull();
            _specimenBuilderNodeAdapterCollectionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyAdaptedBuilderNode)]
        [TestCase(PropertyAdaptedBuilders)]
        [TestCase(PropertyCount)]
        [TestCase(PropertyIsReadOnly)]
        [TestCase(PropertyGraph)]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (AdaptedBuilderNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_AdaptedBuilderNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAdaptedBuilderNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAdaptedBuilderNode);
            Action currentAction = () => propertyInfo.SetValue(_specimenBuilderNodeAdapterCollectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (AdaptedBuilderNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Public_Class_AdaptedBuilderNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAdaptedBuilderNode);
            var propertyInfo = this.GetPropertyInfo(PropertyAdaptedBuilderNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (AdaptedBuilders) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Public_Class_AdaptedBuilders_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAdaptedBuilders);
            var propertyInfo = this.GetPropertyInfo(PropertyAdaptedBuilders);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (Count) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Public_Class_Count_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCount);
            var propertyInfo = this.GetPropertyInfo(PropertyCount);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (Graph) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Graph_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGraph);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyGraph);
            Action currentAction = () => propertyInfo.SetValue(_specimenBuilderNodeAdapterCollectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (Graph) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Public_Class_Graph_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGraph);
            var propertyInfo = this.GetPropertyInfo(PropertyGraph);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SpecimenBuilderNodeAdapterCollection) => Property (IsReadOnly) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Public_Class_IsReadOnly_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsReadOnly);
            var propertyInfo = this.GetPropertyInfo(PropertyIsReadOnly);

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

        #region Method Call : (InvalidateCachedAdaptedBuilderNode) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_InvalidateCachedAdaptedBuilderNode_Method_Call_Internally(Type[] types)
        {
            var methodInvalidateCachedAdaptedBuilderNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvalidateCachedAdaptedBuilderNode, methodInvalidateCachedAdaptedBuilderNodeParametersTypes);
        }

        #endregion

        #region Method Call : (InvalidateCachedAdaptedBuilderNode) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_InvalidateCachedAdaptedBuilderNode_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidateCachedAdaptedBuilderNode);
            Type [] methodInvalidateCachedAdaptedBuilderNodeParametersTypes = null;
            object[] parametersOfInvalidateCachedAdaptedBuilderNode = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodInvalidateCachedAdaptedBuilderNode, methodInvalidateCachedAdaptedBuilderNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfInvalidateCachedAdaptedBuilderNode);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInvalidateCachedAdaptedBuilderNode.ShouldBeNull();
            methodInvalidateCachedAdaptedBuilderNodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidateCachedAdaptedBuilderNode) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_InvalidateCachedAdaptedBuilderNode_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidateCachedAdaptedBuilderNode);
            Type [] methodInvalidateCachedAdaptedBuilderNodeParametersTypes = null;
            object[] parametersOfInvalidateCachedAdaptedBuilderNode = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInvalidateCachedAdaptedBuilderNode, parametersOfInvalidateCachedAdaptedBuilderNode, methodInvalidateCachedAdaptedBuilderNodeParametersTypes);

            // Assert
            parametersOfInvalidateCachedAdaptedBuilderNode.ShouldBeNull();
            methodInvalidateCachedAdaptedBuilderNodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidateCachedAdaptedBuilderNode) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_InvalidateCachedAdaptedBuilderNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidateCachedAdaptedBuilderNode);
            Type [] methodInvalidateCachedAdaptedBuilderNodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInvalidateCachedAdaptedBuilderNode, methodInvalidateCachedAdaptedBuilderNodeParametersTypes);

            // Assert
            methodInvalidateCachedAdaptedBuilderNodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidateCachedAdaptedBuilderNode) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_InvalidateCachedAdaptedBuilderNode_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidateCachedAdaptedBuilderNode);
            var methodInfo = this.GetMethodInfo(MethodInvalidateCachedAdaptedBuilderNode, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_Internally(Type[] types)
        {
            var methodIndexOfParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.IndexOf(item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfIndexOf = { item };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodIndexOf, methodIndexOfParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfIndexOf);
            var result2 = this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfIndexOf = { item };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodIndexOf, methodIndexOfParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<int>(_specimenBuilderNodeAdapterCollectionInstanceFixture, out exception1, parametersOfIndexOf);
            var result2 = this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfIndexOf = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodIndexOfParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIndexOfParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodInfo = this.GetMethodInfo(MethodIndexOf, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_IndexOf_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodInfo = this.GetMethodInfo(MethodIndexOf, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_Internally(Type[] types)
        {
            var methodInsertParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsert, methodInsertParametersTypes);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.Insert(index, item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilder>();
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilder) };
            object[] parametersOfInsert = { index, item };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodInsert, methodInsertParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfInsert);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsert.ShouldNotBeNull();
            parametersOfInsert.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(parametersOfInsert.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilder>();
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilder) };
            object[] parametersOfInsert = { index, item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsert, parametersOfInsert, methodInsertParametersTypes);

            // Assert
            parametersOfInsert.ShouldNotBeNull();
            parametersOfInsert.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(parametersOfInsert.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var methodInfo = this.GetMethodInfo(MethodInsert, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsert, methodInsertParametersTypes);

            // Assert
            methodInsertParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Insert_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var methodInfo = this.GetMethodInfo(MethodInsert, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_Internally(Type[] types)
        {
            var methodRemoveAtParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveAt, methodRemoveAtParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var index = this.CreateType<int>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.RemoveAt(index);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var index = this.CreateType<int>();
            var methodRemoveAtParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfRemoveAt = { index };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodRemoveAt, methodRemoveAtParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfRemoveAt);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveAt.ShouldNotBeNull();
            parametersOfRemoveAt.Length.ShouldBe(1);
            methodRemoveAtParametersTypes.Length.ShouldBe(1);
            methodRemoveAtParametersTypes.Length.ShouldBe(parametersOfRemoveAt.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var index = this.CreateType<int>();
            var methodRemoveAtParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfRemoveAt = { index };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveAt, parametersOfRemoveAt, methodRemoveAtParametersTypes);

            // Assert
            parametersOfRemoveAt.ShouldNotBeNull();
            parametersOfRemoveAt.Length.ShouldBe(1);
            methodRemoveAtParametersTypes.Length.ShouldBe(1);
            methodRemoveAtParametersTypes.Length.ShouldBe(parametersOfRemoveAt.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var methodInfo = this.GetMethodInfo(MethodRemoveAt, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var methodRemoveAtParametersTypes = new Type[] { typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveAt, methodRemoveAtParametersTypes);

            // Assert
            methodRemoveAtParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAt) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_RemoveAt_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAt);
            var methodInfo = this.GetMethodInfo(MethodRemoveAt, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_Internally(Type[] types)
        {
            var methodAddParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.Add(item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodAddParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfAdd = { item };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodAdd, methodAddParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfAdd);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(parametersOfAdd.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodAddParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfAdd = { item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAdd, parametersOfAdd, methodAddParametersTypes);

            // Assert
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(parametersOfAdd.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodInfo = this.GetMethodInfo(MethodAdd, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodAddParametersTypes = new Type[] { typeof(ISpecimenBuilder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);

            // Assert
            methodAddParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Add_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodInfo = this.GetMethodInfo(MethodAdd, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_Call_Internally(Type[] types)
        {
            var methodClearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.Clear();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfClear);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Clear_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var methodInfo = this.GetMethodInfo(MethodClear, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_Internally(Type[] types)
        {
            var methodContainsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.Contains(item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodContainsParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfContains = { item };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodContains, methodContainsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfContains);
            var result2 = this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodContainsParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfContains = { item };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodContains, methodContainsParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_specimenBuilderNodeAdapterCollectionInstanceFixture, out exception1, parametersOfContains);
            var result2 = this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodContainsParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfContains = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodContainsParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContainsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodInfo = this.GetMethodInfo(MethodContains, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Contains_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodInfo = this.GetMethodInfo(MethodContains, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_Internally(Type[] types)
        {
            var methodCopyToParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopyTo, methodCopyToParametersTypes);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ISpecimenBuilder[]>();
            var arrayIndex = this.CreateType<int>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.CopyTo(array, arrayIndex);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ISpecimenBuilder[]>();
            var arrayIndex = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(ISpecimenBuilder[]), typeof(int) };
            object[] parametersOfCopyTo = { array, arrayIndex };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodCopyTo, methodCopyToParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfCopyTo);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopyTo.ShouldNotBeNull();
            parametersOfCopyTo.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(parametersOfCopyTo.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ISpecimenBuilder[]>();
            var arrayIndex = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(ISpecimenBuilder[]), typeof(int) };
            object[] parametersOfCopyTo = { array, arrayIndex };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCopyTo, parametersOfCopyTo, methodCopyToParametersTypes);

            // Assert
            parametersOfCopyTo.ShouldNotBeNull();
            parametersOfCopyTo.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(parametersOfCopyTo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var methodInfo = this.GetMethodInfo(MethodCopyTo, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var methodCopyToParametersTypes = new Type[] { typeof(ISpecimenBuilder[]), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCopyTo, methodCopyToParametersTypes);

            // Assert
            methodCopyToParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_CopyTo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var methodInfo = this.GetMethodInfo(MethodCopyTo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_Internally(Type[] types)
        {
            var methodRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ISpecimenBuilder>();

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.Remove(item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodRemoveParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfRemove = { item };
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfRemove);
            var result2 = this.GetResultOfMethod<bool>(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodRemoveParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfRemove = { item };
            Exception exception, exception1;
            var methodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<bool>(_specimenBuilderNodeAdapterCollectionInstanceFixture, out exception1, parametersOfRemove);
            var result2 = this.GetResultOfMethod<bool>(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ISpecimenBuilder>();
            var methodRemoveParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            object[] parametersOfRemove = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodRemoveParametersTypes = new Type[] { typeof(ISpecimenBuilder) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodInfo = this.GetMethodInfo(MethodRemove, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Remove) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Remove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodInfo = this.GetMethodInfo(MethodRemove, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);

            // Act
            Action executeAction = () => _specimenBuilderNodeAdapterCollectionInstance.GetEnumerator();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var returnedValue = default(IEnumerator<ISpecimenBuilder>);

            // Act
            Action executeAction = () => returnedValue = _specimenBuilderNodeAdapterCollectionInstance.GetEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<IEnumerator<ISpecimenBuilder>>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerator<ISpecimenBuilder>>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : IEnumerator<ISpecimenBuilder>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodGetEnumerator, methodGetEnumeratorParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<System.Collections.IEnumerator>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfGetEnumerator);
            var result2 = this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;
            object[] parametersOfGetEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Collections.IEnumerator>(MethodGetEnumerator, parametersOfGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            parametersOfGetEnumerator.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEnumerator) (Return Type : System.Collections.IEnumerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_GetEnumerator_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEnumerator);
            Type [] methodGetEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEnumerator, methodGetEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_Internally(Type[] types)
        {
            var methodOnGraphChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGraphChanged, methodOnGraphChangedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var e = this.CreateType<SpecimenBuilderNodeEventArgs>();
            var methodOnGraphChangedParametersTypes = new Type[] { typeof(SpecimenBuilderNodeEventArgs) };
            object[] parametersOfOnGraphChanged = { e };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodOnGraphChanged, methodOnGraphChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfOnGraphChanged);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGraphChanged.ShouldNotBeNull();
            parametersOfOnGraphChanged.Length.ShouldBe(1);
            methodOnGraphChangedParametersTypes.Length.ShouldBe(1);
            methodOnGraphChangedParametersTypes.Length.ShouldBe(parametersOfOnGraphChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var e = this.CreateType<SpecimenBuilderNodeEventArgs>();
            var methodOnGraphChangedParametersTypes = new Type[] { typeof(SpecimenBuilderNodeEventArgs) };
            object[] parametersOfOnGraphChanged = { e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGraphChanged, parametersOfOnGraphChanged, methodOnGraphChangedParametersTypes);

            // Assert
            parametersOfOnGraphChanged.ShouldNotBeNull();
            parametersOfOnGraphChanged.Length.ShouldBe(1);
            methodOnGraphChangedParametersTypes.Length.ShouldBe(1);
            methodOnGraphChangedParametersTypes.Length.ShouldBe(parametersOfOnGraphChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var methodInfo = this.GetMethodInfo(MethodOnGraphChanged, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var methodOnGraphChangedParametersTypes = new Type[] { typeof(SpecimenBuilderNodeEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGraphChanged, methodOnGraphChangedParametersTypes);

            // Assert
            methodOnGraphChangedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_OnGraphChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var methodInfo = this.GetMethodInfo(MethodOnGraphChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_Internally(Type[] types)
        {
            var methodMutateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMutate, methodMutateParametersTypes);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMutate);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodMutateParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfMutate = { builders };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodMutate, methodMutateParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfMutate);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMutate.ShouldNotBeNull();
            parametersOfMutate.Length.ShouldBe(1);
            methodMutateParametersTypes.Length.ShouldBe(1);
            methodMutateParametersTypes.Length.ShouldBe(parametersOfMutate.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMutate);
            var builders = this.CreateType<IEnumerable<ISpecimenBuilder>>();
            var methodMutateParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };
            object[] parametersOfMutate = { builders };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMutate, parametersOfMutate, methodMutateParametersTypes);

            // Assert
            parametersOfMutate.ShouldNotBeNull();
            parametersOfMutate.Length.ShouldBe(1);
            methodMutateParametersTypes.Length.ShouldBe(1);
            methodMutateParametersTypes.Length.ShouldBe(parametersOfMutate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMutate);
            var methodInfo = this.GetMethodInfo(MethodMutate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMutate);
            var methodMutateParametersTypes = new Type[] { typeof(IEnumerable<ISpecimenBuilder>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMutate, methodMutateParametersTypes);

            // Assert
            methodMutateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mutate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_Mutate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMutate);
            var methodInfo = this.GetMethodInfo(MethodMutate, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_Internally(Type[] types)
        {
            var methodFindAdaptedSpecimenBuilderNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes);
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAdaptedSpecimenBuilderNode);
            Type [] methodFindAdaptedSpecimenBuilderNodeParametersTypes = null;
            object[] parametersOfFindAdaptedSpecimenBuilderNode = null; // no parameter present
            Exception exception;
            var methodInfo = this.GetMethodInfo(MethodFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes, out exception);

            // Act
            var result1 = methodInfo.GetResultMethodInfo<ISpecimenBuilderNode>(_specimenBuilderNodeAdapterCollectionInstanceFixture, parametersOfFindAdaptedSpecimenBuilderNode);
            var result2 = this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindAdaptedSpecimenBuilderNode, parametersOfFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFindAdaptedSpecimenBuilderNode.ShouldBeNull();
            methodFindAdaptedSpecimenBuilderNodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAdaptedSpecimenBuilderNode);
            Type [] methodFindAdaptedSpecimenBuilderNodeParametersTypes = null;
            object[] parametersOfFindAdaptedSpecimenBuilderNode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ISpecimenBuilderNode>(MethodFindAdaptedSpecimenBuilderNode, parametersOfFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes);

            // Assert
            parametersOfFindAdaptedSpecimenBuilderNode.ShouldBeNull();
            methodFindAdaptedSpecimenBuilderNodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAdaptedSpecimenBuilderNode);
            Type [] methodFindAdaptedSpecimenBuilderNodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindAdaptedSpecimenBuilderNodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAdaptedSpecimenBuilderNode);
            Type [] methodFindAdaptedSpecimenBuilderNodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindAdaptedSpecimenBuilderNode, methodFindAdaptedSpecimenBuilderNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindAdaptedSpecimenBuilderNodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindAdaptedSpecimenBuilderNode) (Return Type : ISpecimenBuilderNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SpecimenBuilderNodeAdapterCollection_FindAdaptedSpecimenBuilderNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindAdaptedSpecimenBuilderNode);
            var methodInfo = this.GetMethodInfo(MethodFindAdaptedSpecimenBuilderNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}
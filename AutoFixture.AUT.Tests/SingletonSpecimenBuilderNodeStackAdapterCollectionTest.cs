namespace AutoFixture
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AutoFixture.SingletonSpecimenBuilderNodeStackAdapterCollection" />)
    ///     and namespace <see cref="AutoFixture"/> class using generator(v:0.2.4.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenerationVersion2" /> v1.5.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SingletonSpecimenBuilderNodeStackAdapterCollectionTest : AbstractBaseSetupV2Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />)
        /// </summary>
        public SingletonSpecimenBuilderNodeStackAdapterCollectionTest() : base(typeof(SingletonSpecimenBuilderNodeStackAdapterCollection))
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

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Initializer

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) One time setup

        private Type _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceType;
        private SingletonSpecimenBuilderNodeStackAdapterCollection _singletonSpecimenBuilderNodeStackAdapterCollectionInstance;
        private SingletonSpecimenBuilderNodeStackAdapterCollection _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;

        /// <summary>
        ///    Setting up everything for <see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceType = typeof(SingletonSpecimenBuilderNodeStackAdapterCollection);
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture = this.Create<SingletonSpecimenBuilderNodeStackAdapterCollection>(true);
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstance = _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture ?? this.Create<SingletonSpecimenBuilderNodeStackAdapterCollection>(false);
            CurrentInstance = _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture;
            ConfigureIgnoringTests(); // Configure ignoring tests.
        }

        #endregion

        #region Properties

        private const string PropertyGraph = "Graph";

        #endregion

        #region Methods

        private const string MethodClearItems = "ClearItems";
        private const string MethodInsertItem = "InsertItem";
        private const string MethodRemoveItem = "RemoveItem";
        private const string MethodSetItem = "SetItem";
        private const string MethodOnGraphChanged = "OnGraphChanged";
        private const string MethodUpdateGraph = "UpdateGraph";

        #endregion

        #region Fields

        private const string FieldisWrappedGraph = "isWrappedGraph";

        #endregion

        #endregion

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SingletonSpecimenBuilderNodeStackAdapterCollection)

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodClearItems, 0)]
        [TestCase(MethodInsertItem, 0)]
        [TestCase(MethodRemoveItem, 0)]
        [TestCase(MethodSetItem, 0)]
        [TestCase(MethodOnGraphChanged, 0)]
        [TestCase(MethodUpdateGraph, 0)]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyGraph)]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldisWrappedGraph)]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Is_Instance_Present_Test()
        {
            // Assert
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceType.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstance.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SingletonSpecimenBuilderNodeStackAdapterCollection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstance.ShouldBeAssignableTo<SingletonSpecimenBuilderNodeStackAdapterCollection>();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture.ShouldBeAssignableTo<SingletonSpecimenBuilderNodeStackAdapterCollection>();
            CurrentInstance.ShouldBeAssignableTo<SingletonSpecimenBuilderNodeStackAdapterCollection>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var wrappedGraphPredicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var transformations = this.CreateType<ISpecimenBuilderTransformation[]>();
            SingletonSpecimenBuilderNodeStackAdapterCollection instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SingletonSpecimenBuilderNodeStackAdapterCollection(graph, wrappedGraphPredicate, transformations);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstance.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SingletonSpecimenBuilderNodeStackAdapterCollection>();
        }

        #endregion

        #region General Constructor : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var graph = this.CreateType<ISpecimenBuilderNode>();
            var wrappedGraphPredicate = this.CreateType<Func<ISpecimenBuilderNode, bool>>();
            var transformations = this.CreateType<ISpecimenBuilderTransformation[]>();
            SingletonSpecimenBuilderNodeStackAdapterCollection instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SingletonSpecimenBuilderNodeStackAdapterCollection(graph, wrappedGraphPredicate, transformations);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstance.ShouldNotBeNull();
            _singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyGraph)]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) => Property (Graph) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Graph_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGraph);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyGraph);
            Action currentAction = () => propertyInfo.SetValue(_singletonSpecimenBuilderNodeStackAdapterCollectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SingletonSpecimenBuilderNodeStackAdapterCollection) => Property (Graph) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_Public_Class_Graph_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ClearItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_ClearItems_Method_Call_Internally(Type[] types)
        {
            var methodClearItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearItems, methodClearItemsParametersTypes);
        }

        #endregion

        #region Method Call : (ClearItems) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_ClearItems_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearItems);
            Type [] methodClearItemsParametersTypes = null;
            object[] parametersOfClearItems = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodClearItems, methodClearItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfClearItems);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearItems.ShouldBeNull();
            methodClearItemsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_ClearItems_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearItems);
            Type [] methodClearItemsParametersTypes = null;
            object[] parametersOfClearItems = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearItems, parametersOfClearItems, methodClearItemsParametersTypes);

            // Assert
            parametersOfClearItems.ShouldBeNull();
            methodClearItemsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_ClearItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearItems);
            Type [] methodClearItemsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearItems, methodClearItemsParametersTypes);

            // Assert
            methodClearItemsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_ClearItems_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearItems);
            var methodInfo = this.GetMethodInfo(MethodClearItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_Internally(Type[] types)
        {
            var methodInsertItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertItem, methodInsertItemParametersTypes);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItem);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilderTransformation>();
            var methodInsertItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };
            object[] parametersOfInsertItem = { index, item };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodInsertItem, methodInsertItemParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfInsertItem);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertItem.ShouldNotBeNull();
            parametersOfInsertItem.Length.ShouldBe(2);
            methodInsertItemParametersTypes.Length.ShouldBe(2);
            methodInsertItemParametersTypes.Length.ShouldBe(parametersOfInsertItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItem);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilderTransformation>();
            var methodInsertItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };
            object[] parametersOfInsertItem = { index, item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertItem, parametersOfInsertItem, methodInsertItemParametersTypes);

            // Assert
            parametersOfInsertItem.ShouldNotBeNull();
            parametersOfInsertItem.Length.ShouldBe(2);
            methodInsertItemParametersTypes.Length.ShouldBe(2);
            methodInsertItemParametersTypes.Length.ShouldBe(parametersOfInsertItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItem);
            var methodInfo = this.GetMethodInfo(MethodInsertItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItem);
            var methodInsertItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertItem, methodInsertItemParametersTypes);

            // Assert
            methodInsertItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_InsertItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItem);
            var methodInfo = this.GetMethodInfo(MethodInsertItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_Internally(Type[] types)
        {
            var methodRemoveItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveItem, methodRemoveItemParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveItem);
            var index = this.CreateType<int>();
            var methodRemoveItemParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfRemoveItem = { index };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodRemoveItem, methodRemoveItemParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfRemoveItem);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveItem.ShouldNotBeNull();
            parametersOfRemoveItem.Length.ShouldBe(1);
            methodRemoveItemParametersTypes.Length.ShouldBe(1);
            methodRemoveItemParametersTypes.Length.ShouldBe(parametersOfRemoveItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveItem);
            var index = this.CreateType<int>();
            var methodRemoveItemParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfRemoveItem = { index };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveItem, parametersOfRemoveItem, methodRemoveItemParametersTypes);

            // Assert
            parametersOfRemoveItem.ShouldNotBeNull();
            parametersOfRemoveItem.Length.ShouldBe(1);
            methodRemoveItemParametersTypes.Length.ShouldBe(1);
            methodRemoveItemParametersTypes.Length.ShouldBe(parametersOfRemoveItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveItem);
            var methodInfo = this.GetMethodInfo(MethodRemoveItem, 0);
            const int parametersCount = 1;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveItem);
            var methodRemoveItemParametersTypes = new Type[] { typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveItem, methodRemoveItemParametersTypes);

            // Assert
            methodRemoveItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_RemoveItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveItem);
            var methodInfo = this.GetMethodInfo(MethodRemoveItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_Internally(Type[] types)
        {
            var methodSetItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetItem, methodSetItemParametersTypes);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItem);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilderTransformation>();
            var methodSetItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };
            object[] parametersOfSetItem = { index, item };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodSetItem, methodSetItemParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfSetItem);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetItem.ShouldNotBeNull();
            parametersOfSetItem.Length.ShouldBe(2);
            methodSetItemParametersTypes.Length.ShouldBe(2);
            methodSetItemParametersTypes.Length.ShouldBe(parametersOfSetItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItem);
            var index = this.CreateType<int>();
            var item = this.CreateType<ISpecimenBuilderTransformation>();
            var methodSetItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };
            object[] parametersOfSetItem = { index, item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetItem, parametersOfSetItem, methodSetItemParametersTypes);

            // Assert
            parametersOfSetItem.ShouldNotBeNull();
            parametersOfSetItem.Length.ShouldBe(2);
            methodSetItemParametersTypes.Length.ShouldBe(2);
            methodSetItemParametersTypes.Length.ShouldBe(parametersOfSetItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItem);
            var methodInfo = this.GetMethodInfo(MethodSetItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = methodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItem);
            var methodSetItemParametersTypes = new Type[] { typeof(int), typeof(ISpecimenBuilderTransformation) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetItem, methodSetItemParametersTypes);

            // Assert
            methodSetItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_SetItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItem);
            var methodInfo = this.GetMethodInfo(MethodSetItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(methodInfo);

            // Assert
            methodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_Internally(Type[] types)
        {
            var methodOnGraphChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGraphChanged, methodOnGraphChangedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGraphChanged) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGraphChanged);
            var e = this.CreateType<SpecimenBuilderNodeEventArgs>();
            var methodOnGraphChangedParametersTypes = new Type[] { typeof(SpecimenBuilderNodeEventArgs) };
            object[] parametersOfOnGraphChanged = { e };
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodOnGraphChanged, methodOnGraphChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfOnGraphChanged);

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
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_OnGraphChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (UpdateGraph) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_UpdateGraph_Method_Call_Internally(Type[] types)
        {
            var methodUpdateGraphParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateGraph, methodUpdateGraphParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateGraph) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_UpdateGraph_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraph);
            Type [] methodUpdateGraphParametersTypes = null;
            object[] parametersOfUpdateGraph = null; // no parameter present
            Exception exception = null;
            var methodInfo = this.GetMethodInfo(MethodUpdateGraph, methodUpdateGraphParametersTypes, out exception);

            // Act
            Action currentAction = () => methodInfo.Invoke(_singletonSpecimenBuilderNodeStackAdapterCollectionInstanceFixture, parametersOfUpdateGraph);

            // Assert
            methodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateGraph.ShouldBeNull();
            methodUpdateGraphParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraph) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_UpdateGraph_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraph);
            Type [] methodUpdateGraphParametersTypes = null;
            object[] parametersOfUpdateGraph = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateGraph, parametersOfUpdateGraph, methodUpdateGraphParametersTypes);

            // Assert
            parametersOfUpdateGraph.ShouldBeNull();
            methodUpdateGraphParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraph) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_UpdateGraph_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraph);
            Type [] methodUpdateGraphParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateGraph, methodUpdateGraphParametersTypes);

            // Assert
            methodUpdateGraphParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGraph) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SingletonSpecimenBuilderNodeStackAdapterCollection_UpdateGraph_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGraph);
            var methodInfo = this.GetMethodInfo(MethodUpdateGraph, 0);

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
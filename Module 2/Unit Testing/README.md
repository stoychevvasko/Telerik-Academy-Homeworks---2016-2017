# Unit Testing

Course literature:

![alt text](https://github.com/stoychevvasko/Telerik-Academy-Homeworks---2016-2017/blob/master/.resources/art_of_unit_testing.png "The Art of Unit Testing") 



## 01. Introduction to Software Engineering

_Software Engineering is the application of a systematic, disciplined, quantifiable approach to the development, operation, and maintenance of software._ -- ISO/IEEE, 2010

Dev Ops - a hybrid position - developer + system
administrator/releases/patches - [wiki article](https://en.wikipedia.org/wiki/DevOps)

Software development consists of the following elements:
- requirement analysis
- design
- construction
- testing

***1940s*** - first digital computers - split between hardware and software    

***1950s*** - first programming languages - Fortran, ALGOL, COBOL    

***1968*** - David Parnas introduces the concept of modularity    

***1972*** - David Parnas introduces the concept of information hiding    

***1968*** - first Software Engineering conference, sponsored and hosted by NATO - first conventions and design patterns introduced    

***1979*** - Glenford J. Myers introduces the separation of debugging from testing    

***1988*** - Dave Gelperin and William C. Hetzel classified the phases and goals in software testing    

***1994*** - Kent Beck (author of The Art of Unit Testing)releases the first version of SUnit, the first unit testing framework, designed for the language Smalltalk    


_Software testing can provide objective and independent information about the quality of software, as well as the risks of its failure to users._ - Cem Kaner, 2006

System testing covers a completely integrated system of modules ti verify that the system meets its requirements. It is an end-to-end type of testing.

Integration testing works to expose defects in the interaction between integrated components of a given module. 

Unit testing works to expose defects in a single component of a given module. Unit tests focus on the single smallest unit of code.



## 02. Introduction to Unit Testing

Use mocking in order to ensure that you're doing unit testing. Without mocking many unit tests become integration tests instead, so you end up testing the wrong things even with the best intentions. Use mocking.

- NUnit
- MSTest/Visual Studio Team Test (VSTT) - integrated in Visual Studio - ***Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll***

Test all public classes/interfaces. Private functionality can remain untested as long as public members have sufficient testing code coverage. 

Ideally, all unit tests should pass before check-in into the source control repository.

***No test should depend upon another test - each unit test must be completely independent and isolated from other tests.***

Dependency injection (technique) - inversion of control (principle) - use interfaces to isolate dependencies so we make sure to perform a unit test and not an integration test.




## 03. Unit Testing

OpenCover - free open source code coverage analyzer

***Test code is annotated using custom attributes:***
- [TestClass] - denotes a class holding unit tests
- [TestMethod] - denotes a unit test method
- [ExpectedException] - test causes an exception - MSTest version 1 only - depricated
- [Timeout] - sets a timeout for test execution
- [Ignore] - temporary ignored test case
- [ClassInitialize], [ClassCleanup] - setup / cleanup logic for the testing class
- [TestInitialize], [TestCleanup] - setup / cleanup logic for each test case

In Visual Studio - right-click on solution -> Add -> find Unit Test Project.

Right-click on solution again -> Manage NuGet packages -> Browse check pre-release - install NUnit or MSTest.TestFramework V2

Some versions of Visual Studio may require MSTest.Adapter and/or MSTestExtensions as well.

Conventions - use `public class UnitName_Should` as test class, and then test method names can be like `public void TakeActionOrDescribeWhatOccurs_WhenConditionDescribed()`

MSTest version 2 supports test cases, so avoid using version 1 (XML hell).

Do not use [ExpectedException] in MSTest V2 - instead, use Assert.ThrowsException<ExceptionType>(() => MockedObject.MethodCall(args));

`
[TestInitialize]
public void TestInit()
{
    // logic to be repeated before each test run
}
`

TestInitialize - also discouraged as it does not fit with the triple A pattern (3A), see below.

### The 3A Pattern

- **Arrange** all necessary preconditions and inputs
- **Act** on the object or method under test
- **Assert** that the expected results have occurred

***Make sure to write a comment for each of the A's - best practice***

Sometimes the Act & Assert phases may be conflated within one. That is okay, as long as comments reflect that so there is no doubt.

### Code Coverage

Code coverage of ***70-80%*** is excellent. Do not strive for 100% coverage, coverage is just a guide, not necessary in all cases.

dotCover - JetBrains' free trial - can use, no MSTest V2 support though

OpenCover - try through the NuGet package manager integrated in VS

#### NUnit

***[TextFixture]*** instead of [TestClass]    

***[Test]*** instead of [TestMethod]    

***Assert.Throws<TypeOfException>(() => UnitUnderTest.MethodCall(args));*** - _NUnit syntax_ for an assertion expecting an exception throw - delegate used (lambda expression)

**NUnit3TestAdapter** - may be required for date-related issues - use V3

Use long descriptive names for test methods - expected input or state, expected result or state, name of tested method or class - all part of the test name. They tend to get very
long and it is okay. Separate parts using an underscore \_.


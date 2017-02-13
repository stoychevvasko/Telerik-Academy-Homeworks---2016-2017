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
- MSTest

Test all public classes/interfaces. Private functionality can remain untested as long as public members have sufficient testing code coverage. 

Ideally, all unit tests should pass before check-in into the source control repository.

***No test should depend upon another test - each unit test must be completely independent and isolated from other tests.***

Dependency injection (technique) - inversion of control (principle) - use interfaces to isolate dependencies so we make sure to perform a unit test and not an integration test.



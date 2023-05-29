using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automated_Testing_Tutorial
{
    class Tutorial
    {

        // Automated_Testing
        /*
             Automated testing is the practice of writing codes to test our code, and then run those test
             in an automated fashion

             With automated testing, our cods/program will consist of production codes and test codes

             BENEFITS OF AUTOMATED TESTING
             -----------------------------
             1.  Ability to test your application code frequently and in less time.\
             2.  The main advantage is the ability to catch bugs in the application before deployment. 
                 NOTE: This doesn't mean our programs would be completely bug free, but this can certainly reduce the num
                         of bugs and improve the quality of our software.

             3.  Refactoring with confidence.  Without automated testing, Whenever we refactor our code, we have to manually 
                                               test every part of the application that could be affected by our refactoring

             4.  It helps us focus more on the quality of code / quality of methods that we're writing.




             TYPES OF TESTS
             --------------
             In automated testing there are three 3 types of tests
             1.  Unit Test
             2.  Integration Test
             3.  End-To-End Test


             1.  Unit Test  :    A unit test, tests a unit/ a class of an application WITHOUT ITS EXTERNAL DEPENDENCIES(ie files, databases, queues and so on)
                                 ADVANTAGE
                                 1.  They are cheap to write
                                 2.  They execute fast
                                 3.  With this, you can verify that each building block in the application is working as expected
                                 DISADVANTAGES
                                 1.  Since we're not testing with their external dependencies, we cannot get a lot of confidence
                                     in the reliability of the app, and that's when INTEGRATION Tests comes to the rescue.


             2.  Integration Test:       An integration test, tests a class or a component with its EXTERNAL DEPENDENCIES.
                                         DISADVANTAGES
                                         1.  They take longer to execute (because they're often involved in read/write to database)
                                         ADVANTAGES
                                         1.  They give us more confidence in the health of our app.

             3.  End To End Test:    End To End Tests drives an application through its interface
                                     Tools For End To End Tests ------ 'Selenium' : Selenium allows us to record the interaction
                                                                         of a user with our application, and then plays it back 
                                                                         and check if the app is returning the right results or not

                                     ADVANTAGES
                                     1.  They give the greatest amount of confidence about the health of our app.
                                     Disadvantages
                                     1.  They are very very slow(This is because they require launching the app and testing it through the UI)
                                     2.  They are very brittle(venerable) a small enhancement to the app OR a small change in the UI can easily break
                                         these tests.



             TEST PYRAMIDS
             -------------
             QUESTION:   What types of tests should we write in our application?
             Answer:     All of them.

             This is called or known as test pyramids

                                                         /\
                                                        /  \
                                                       /E2E \
                                                      /      \
                                                     /--------\
                                                    /Integraton\
                                                   /------------\
                                                  /              \
                                                 /      Unit      \
                                                 ------------------

            This pyramid argues that most of our tests should be in the category of UNIT TEST because this type of test 
            are easy to write and they execute quickly.  Also since the unit testing don't give us much confidence about
            the health of our app, we should have a bunch of INTEGRATION TESTS that tests the intgration of our codes
            with external dependencies.  These tests, provides many advantages of end-to-end tests but without the 
            complexities of dealing with the UI.    Finally, we should write wery few end-to-end tests for the KEY-FUNCTIONS
            of our applicaton.      We should not test edge-cases with these end-to-end tests.  You only test the 
            happy-path and leave the edge cases to unit tests.

            NOTE:
            Happy-Path :  This refers to features in an app as in to what the feature/app was intended to do
            Edge-Cases :  This refers to what the user might actually do with the feature/app.


            In summary, the test pyrymids gives us three 3 recommendations.
            1.  Favour Unit-Tests over UI/end-to-end tests
            2.  Cover unit-test gaps with integration tests
            3.  Use end-to-end tests sparingly(ie. only for the key functions of our app).

            
            
         */


    }
}

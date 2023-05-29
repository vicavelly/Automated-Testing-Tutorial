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
        */


    }
}

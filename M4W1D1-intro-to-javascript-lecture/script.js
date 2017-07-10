window.onload = function () {       
    /*
        Example of a multi-line comment
        The window object represents a DOM document. 
        Each tab in a browser gets its own window object
        The load event is triggered at the end of a document loading process. This occurs one time.
        We are attaching to it through the `onload` event handler and assigning a function to be run.        
    */    

    // Single line comment

    /* 
    #####################
    Declaring a Variable
    #####################
     
     - All Javascript variable declarations start with the `var` keyword
     - Javascript variable names normally follow the same naming conventions as identifiers in Java and C#
     - Javascript variables are dynamically typed and can be assigned a value of any data type
    */     
    var numberOfDaysPerWeek = 7; // this line declares a variable named `numberOfDaysPerWeek` and assigns it the numeric value 3
    console.log("Number of Days Per Week " + numberOfDaysPerWeek);

    var nameOfCompany = "Tech Elevator"; // this line declares a variable named `nameOfCompany` and assigns it a String value
    console.log("Name of Company" + nameOfCompany);
        
    var weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"]; // this line declares a variable named `weekdays` and assigns it an array of Strings
    console.log("The days of the week are " + weekdays);

    // undefined
    var undefinedVariable;
    console.log("The value of an undefined variable is " + undefinedVariable);

    // Javascript is a **dynamically typed** language. Because it is dynamically typed, the following code does not cause an error.
    var answer = 42; // this line declares a variable named `answer` and assigns a Number
    answer = "The truth is out there"; // this line assigns a String value to the same variable (freaky, right?!)


    /*
    ########################
    Assignment and Increment
    ########################
    */

    var numberOfQuarterBacks = 24;
    console.log("Cleveland has " + numberOfQuarterBacks + " since they returned in 1999");

    var hasNumberOnePick = true;
    if (hasNumberOnePick) {
        numberOfQuarterBacks++;
        console.log("Given Cleveland has the first pick in the draft then the number of quarterbacks will be " + numberOfQuarterBacks);
    }

    // Now go back and switch numberOfQuarterBacks to "nineteen" and see what happens when we use ++
    // We'll get NaN


    /*
    ########################
    Comparison Operators
    ########################
    */
    
    /* 
    Strict Equality
    ---------------
    
    Strict equality **`===`** or **`!==`** compares two values for equality. Neither value is implicitly converted to another value before comparison.
    */
    var num = 0;
    var obj = new String("0");
    var str = "0";
    var b = false;

    console.log(num === num); // true
    console.log(obj === obj); // true
    console.log(str === str); // true

    console.log(num === obj); // false
    console.log(num === str); // false
    console.log(obj === str); // false
    console.log(null === undefined); // false
    console.log(obj === null); // false
    console.log(obj === undefined); // false

    /*
    Loose Equality
    --------------
    
    Loose equality compares two values for equality after converting to a common type.
    */
    console.log(num == num); // true
    console.log(obj == obj); // true
    console.log(str == str); // true

    console.log(num == obj); // true
    console.log(num == str); // true
    console.log(obj == str); // true
    console.log(null == undefined); // true

    /*
    ########################
    TypeOf operator
    ########################
    
    The most common unary operator is `typeof`. The only operand supplied is the value that you want to get the type of.
    */

    console.log("num is " + typeof num);
    console.log("b is " + typeof b);
    console.log("str is " + typeof str);
    console.log("nameOfSportTeams is " + typeof nameOfSportTeams);
    console.log("undefinedValue is " + typeof undefinedValue);
    console.log("AddTwo is " + typeof AddTwo);

    /*
    ########################
    Calling Functions
    ########################
    */
    
    var addResult = AddTwo(5, 3);
    console.log("Result of addResult " + addResult);
    
    /* Note that functions can be invoked *before* they are declared */    
    var squareResult = Square(6);
    console.log("Result of squareResult " + squareResult);

    function Square(number) {
        return number * number;
    }
    
    /*
    ########################
    Built-In Functions
    ########################
    */
    
    // isNaN - Returns true if value is NaN (Not a Number)
    
    console.log("isNaN(123) : " + isNaN(123)); //false
    console.log("isNaN(-1.23) : " + isNaN(-1.23)); //false
    console.log("isNaN(5-2) : " + isNaN(5-2)); //false
    console.log("isNaN(0) : " + isNaN(0)); //false
    console.log("isNaN('123') : " + isNaN('123')); //false
    console.log("isNaN('Hello') : " + isNaN('Hello')); //true
    console.log("isNaN('2005/12/12') : " + isNaN('2005/12/12')); //true
    console.log("isNaN('') : " + isNaN('')); //false
    console.log("isNaN(true) : " + isNaN(true)); //false
    console.log("isNaN(undefined) : " + isNaN(undefined)); //true
    console.log("isNaN('NaN') : " + isNaN('NaN')); //true
    console.log("isNaN(NaN) : " + isNaN(NaN)); //true
    console.log("isNaN(0/0) : " + isNaN(0 / 0)); //true
    
    // parseFloat - Parses a string argument and returns a floating point number                            
    
    console.log("3.25 === parseFloat('3.25') : " + (3.25 === parseFloat('3.25')));
    
    //parseInt - Parses a string argument and returns an integer number representing that string         
    
    console.log("15 === parseInt('15') : " + (15 === parseInt('15')));
    
    //parseInt - Parses a string argument based on the base and returns decimal (i.e. base-10) representing that string
    
    console.log("15 === parseInt('1111', 2) : " + (15 === parseInt('1111', 2)));

    /*
    ########################
    Nested Functions with Variable Scope
    ########################
    
    This is more meant to show some of the pitfalls and dangers of not paying attention to variable scope
    */
    
    var otherResult = WeirdResult();
    console.log("Result of otherResult " + otherResult);

    function WeirdResult() {
        return addResult + squareResult;
    }

    addResult = 1;
    squareResult = 1;

    otherResult = WeirdResult();
    console.log("Result of otherResult " + otherResult);


    /*
    ########################
    Calling Functions with Missing Parameters
    ########################
    
    In Java or C#, if you invoke a method but do not pass along the required number of 
    parameters **your code will not compile**. Javascript, however, does *not* force 
    the user to pass values for all parameters in a function. Parameters left blank will 
    be assigned the value of `undefined`.
    */
    WelcomeMessage("Bill", "Good Morning");
    WelcomeMessage("Bill");
    WelcomeMessage("Bill", null);

    function WelcomeMessage(username, message)
    {
        console.log(username + " " + message);
    }

    /* Default Parameters
    
    In Javascript rather than checking if your parameters are undefined before assigning them a default value, you can use default parameters.
    */
    
    function WelcomeUser(userName, welcomeMessage = 'Good Morning') {
        console.log(userName + " "  + welcomeMessage + "!");
    }
    WelcomeUser("Bill", "Hello"); // Displays Bill Hello
    WelcomeUser("Bill"); // Displays Bill Good Morning
    WelcomeUser(); // Displays undefined Good Morning
    
    /*
    ########################
    Function Overloading
    ########################
    
    Function Overloading is not available in Javascript. If you declare a 
    function with the same name, more than one time in a script file, the 
    earlier ones are overriden and the most recent one will be used. 
    */
    
    function Add(num1, num2) {
        return num1 + num2;
    }

    function Add(num1, num2, num3) {
        return num1 + num2 + num3;
    }

    var Add2 = Add(10, 20); // num3 gets set to undefined
    console.log(Add2);
    var Add3 = Add(10, 20, 30);
    console.log(Add3);
    
    /* 
    ########################
    Math Library
    ########################
    
    A built-in `Math` object has properties and methods for mathematical constants and functions.
    */
    
    console.log("Math.PI : " + Math.PI);
    console.log("Math.LOG10E : " + Math.LOG10E);
    console.log("Math.abs(-10) : " + Math.abs(-10));
    console.log("Math.floor(1.99) : " + Math.floor(1.99));
    console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
    console.log("Math.random() : " + Math.random());
    
    /*
    ########################
    String Methods
    ########################
    */
    var word = "Tech Elevator";
    console.log(word + " using .length is " + word.length);
    console.log(word + " using .indexOf('lev') is " + word.indexOf('lev'));
    console.log(word + " using .indexOf('lev') is " + word.indexOf('levitate'));


    /*
    ########################
    Array Methods
    ########################
    */
    var groceries = ["Fruit", "Beer", "Noodles", "Pasta Sauce"];
    console.log("Length is " + groceries.length);
    console.log(groceries);

    groceries.push("Milk");
    console.log("Length is " + groceries.length);
    console.log(groceries);

    groceries[10] = "Cheese";
    console.log("Length is " + groceries.length);   //??????
    console.log(groceries);                         //What is that thing 10 showing up for like that in the output?

    groceries.length = 2;
    console.log("Length is " + groceries.length);
    console.log(groceries);

    // This will lead into some later discussion this week around objects in Javascript
    // On to the exercises!!
};


function AddTwo(number1, number2) {
    return number1 + number2;
}



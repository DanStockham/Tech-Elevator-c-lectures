/* #########################################
Function Expressions and Anonymous Functions
######################################### */

//We've seen function declarations that allow us to write reusable code like this: 

function speak(numberOfTimes) {
  for(var i = 0; i < numberOfTimes; i++) {
      console.log("WOOF");   
  }
}

speak(5);

/* We can assign a function to a variable. This is called a "function expression". 
When using this approach, we don't need to provide a function name (unless we want 
to recursively call it). */

// Note that we are assigning an anonymous function to a variable named `fly`.
var fly = function(num) {
    for(var i = 0; i < num; i++) {
        console.log("I'm flying!!");   
    }   
};

fly(3); // here we use the `fly` variable to invoke the function.

var makeDogSound = speak;

makeDogSound(10);

var thinkHappyThoughts = fly;

thinkHappyThoughts(20);

function filter(things, matcher) {
    var results = [];
    for(var i = 0; i < things.length; i++) {
        if(matcher(things[i])) {
            results.push(things[i]);
        }
    }
    return results;
}

function evenNumbers(num) {
    return num % 2 == 0;
}

function oddNumbers(num) {
    return num % 2 != 0;
}

var input = [1,2,3,4,5,6,7,8,9];

console.log(filter(input, evenNumbers));
console.log(filter(input, oddNumbers));



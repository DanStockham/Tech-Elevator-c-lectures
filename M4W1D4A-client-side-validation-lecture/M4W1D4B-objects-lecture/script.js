window.onload = function () { 

object1 = {};
console.log(object1);

object1[4] = 1;
object1[17] = 23;
console.log(object1);

object1[4] = "John";
object1[20] = "Bella";
console.log(object1);

object1["zip"] = "43209";
object1["number"] = "49";
console.log(object1);

object1.street = "Merkle";
object1.city = "Bexley";
console.log(object1);

var result = object1["street"];
console.log("result: "+ result);


var result = object1.city;
console.log("result: "+ result);

if (object1.street == "Merkle")
{
	console.log("Found Merkle at Street");
}

if (object1[17] == 23)
{
	console.log("Found 23 at 17");
}


var object2 = {number:49, direction:"N", street:"Merkle", city:"Bexley", state:"OH", zip:43209} ;
console.log(object2);


var object3 = new Object();
object3.address = object2;
console.log(object3);

object3.name = "John Fulton";
object3.email = "john@techelevator.com";
console.log(object3);

var key = "email"
var result = object3[key];
console.log("Result: " + result);


function showProps(obj, objName) {
  var result = '';
  for (var i in obj) {
    // obj.hasOwnProperty() is used to filter out properties from the object's prototype chain
    if (obj.hasOwnProperty(i)) {
      result += objName + '.' + i + ' = ' + obj[i] + '\n';
    }
  }
  return result;
}
  
var info = showProps(object1, "object1") 
console.log("object1:\n" + info);
  
info = showProps(object2, "object2") 
console.log("object2:\n" + info);
  
info = showProps(object3, "object3") 
console.log("object3:\n" + info);

  
 
 function Person(name, city, isProgrammer) {
  this.name = name;
  this.city = city;
  this.isProgrammer = isProgrammer;
}

var john = new Person("John", "Bexley", true);
var chris = new Person("Chris", "Columbus", false);

console.log("john:\n" + john);
info = showProps(john, "john") 
console.log("john:\n" + info);

var family = {john, chris};
console.log("family:\n" + family);
info = showProps(family, "family") 
console.log("family:\n" + info);


var object4 = {number:49, direction:"N", street:"Merkle", city:"Bexley", state:"OH", zip:43209} ;
console.log("object4:\n" + object4);
info = showProps(object4, "object4") 
console.log("object4:\n" + info);

JSON.stringify(object4)
console.log("object4 as JSON:\n" + object4);
info = showProps(object4, "object4") 
console.log("object4 as JSON:\n" + info);

};




$(document).ready(function () {

    //1. Getting an HTML element by id
    var box1 = $("#box1");    
    console.log(box1);
        
    //2. Getting an HTML element by class name
    var redBoxes = $(".red");
    console.log(redBoxes);

    //3. Getting HTML elements by tag name
    var divBoxes = $("div");
    console.log(divBoxes);   

    //4. Filtering the div boxes to include only odd-numbered boxes
    var oddNumberedBoxes = $("div").filter(":odd");
    console.log(oddNumberedBoxes);

    //5. Getting all list Items and filtering to only include special
    var specialItems = $("li").filter(".special");
    console.log(specialItems);
    //OR
    var specialItems2 = $("li.special");
    console.log(specialItems2);
      
    //6. Getting the last box
    var lastH2 = $("div.box").last();
    console.log(lastH2);

    //7. Getting the parent box of the .text class
    var parent = $(".text").parent();
    console.log(parent);

    //8. Getting the box after the blue-one
    var boxAfterList = $("div.blue").next();
    console.log(boxAfterList);

    //9. Getting all children inside the grey box except <br/>
    var greyBoxChildren = $(".grey").children().not("br");
    console.log(greyBoxChildren);

    //10. Getting the value of the text box
    var textBoxValue = $("#nameField").val();
    console.log(textBoxValue);

    //11. Setting the value of the text box to Tech Elevator
    $("#nameField").val("Tech Elevator");
    
    //12. Getting the value of the first <p> tag in the green box
    var greenBoxPTag = $(".green").children("p")    
    console.log("Before " + greenBoxPTag.html());

    //13. Changing the html
    greenBoxPTag.html("<b>This HTML was changed by JavaScript</b>");

    //14. Changing all of the li tags to something better
    $("li").text("Set the .text() through jQuery");

    //15. Changing the link attribute in the green box
    $(".green").children("a").attr("href", "http://www.techelevator.com");

    //16. Changing the boxes in the grey box    
    $(".grey").children(":checkbox").attr("checked", "checked");

    //17. Making all of the other boxes grey and the black box red
    //var blackBox = $(".grey");
    //var otherBoxes = $(".box").not(".grey");        
    //blackBox.removeClass("grey").addClass("red");
    //otherBoxes.removeClass().addClass("box").addClass("black");
    
    //18. Adding a new list item
    $("ul").append("<li>Item 6</li>")

    //19. Moving the even numbered items from the yellow box to the green box
    var list = $("li").filter(":even").detach();
    $(".green").children().filter("ol").append(list);
    

});
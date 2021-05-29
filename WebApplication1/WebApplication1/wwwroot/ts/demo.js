var message = 'Hello World';
console.log(message);
var blvalue = false;
console.log(blvalue);
var decimalval = 123;
console.log(decimalval);
var binaryv = 11010;
console.log(binaryv);
var color = "blue";
color = "red";
var list = [1, 2, 45];
console.log(list);
var list1 = [2, 4, 5];
console.log(list1);
var tple;
tple = ["sumon", 234];
console.log(tple[1]);
console.log(tple[0].substring(2, 4));
console.log(tple[1].toString());
//number method operation example 
var myNumber = 123456;
myNumber.toExponential(); // returns 1.23456e+5
myNumber.toExponential(1); //returns 1.2e+5
var myNumber2 = 10.8788;
myNumber2.toFixed(); // returns 11
myNumber2.toFixed(1); //returns 10.9
myNumber2.toFixed(2); //returns 10.88
var myNumber3 = 10667.987;
myNumber3.toLocaleString(); // returns 10,667.987 - US English
myNumber3.toLocaleString('de-DE'); // returns 10.667,987 - German
myNumber3.toLocaleString('ar-EG'); // returns 10667.987 in Arebic
var myNumber4 = 10.5679;
myNumber4.toPrecision(1); // returns 1e+1
myNumber4.toPrecision(2); // returns 11
myNumber4.toPrecision(3); // returns 10.6
myNumber4.toPrecision(4); // returns 10.57
var myNumber5 = 123; // 
myNumber5.toString(); // returns '123'
myNumber5.toString(2); // returns '1111011'  //convert 2 base number 
myNumber5.toString(4); // returns '1323'       
myNumber5.toString(8); // returns '173'  //convert 8 base number 
var Name = "sumon";
var Id = 123;
var address = 'the name of student is ${Name} and  id no is ${Id}';
var students;
(function (students) {
    students[students["sumon"] = 0] = "sumon";
    students[students["sujon"] = 1] = "sujon";
    students[students["suvo"] = 2] = "suvo";
    students[students["kajol"] = 3] = "kajol";
})(students || (students = {}));
var studentName = students.sumon;
var studentName2 = students[1];
var fruits = ["apple", "mango", "jackfruits"];
for (var index in fruits) {
    console.log(fruits[index]);
}
var fruits1 = ["apple", "mango", "banana"];
var information = ["apple", 23, "mango", 90, 65];
for (var i in information) {
    console.log(information[i]);
}
var address1 = ['sumon', 87, 'sujon', 87, 'kajol'];
var tple2 = ["sumon", 123];
var tplarray = [['sumon', 12], ['suvo', 90], ['kajol', 87]];
console.log(tplarray[1][0]);
//# sourceMappingURL=demo.js.map
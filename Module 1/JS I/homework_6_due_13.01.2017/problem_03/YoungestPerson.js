// Problem 03: Youngest person - BGCoder format
function solve(args) {	
    var input = args;
    var people = [];
  
    function constructPerson(firstName, lastName, age) {
        return {
            firstname: firstName,
            lastname: lastName,
            age: parseInt(age)
        };
    }
  
    function getYoungest(people) {
        var youngestPerson = people[0];
        for (var i = 1; i < people.length; i += 1) {
            if (people[i].age < youngestPerson.age) {
                youngestPerson = people[i];
            }
        }
        return youngestPerson;
    }
     
    while(input.length > 0) {
        var person = constructPerson.apply(this, (input.slice(0, 3)));
        people.push(person);
        input.splice(0, 3);
    }
 
    youngestPerson = getYoungest(people);
    console.log(youngestPerson.firstname + ' ' + youngestPerson.lastname); 
}
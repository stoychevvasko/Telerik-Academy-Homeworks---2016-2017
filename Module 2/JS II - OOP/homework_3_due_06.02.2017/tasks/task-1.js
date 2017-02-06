/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var Rules = function(parent) {
        return {
            validateTitle: function(titleString) {
                if (!titleString || (typeof titleString) != 'string') {
                    throw new Error('null or non-string title' + titleString);
                }

                if (/(^[ \[])|( $)|( {2})|(^.?$)/.test(titleString)) {
                    throw new Error('invalid title ' + titleString);
                }
                return titleString;
            },
            isValidTitle: function(titleArg) {
                return !/(^[ \[])|( $)|( {2})|(^.?$)/.test(titleArg);
            },
            validatePresentations: function(arrayOfPresentations) { 
                if (arrayOfPresentations === null) {
                    throw new Error('missing presentations');
                }

                if (arrayOfPresentations.length === 0) {
                    throw new Error('empty array');
                }

                arrayOfPresentations.forEach(p => Rules.validateTitle(p));
                return arrayOfPresentations.slice();
            },
            validateFullPersonalName: function(name) {
                if (!name || (typeof name) != 'string') {
                    throw new Error('null or non-string name');
                }

                if (!/^[A-Z][a-z]*( )[A-Z][a-z]*$/.test(name)) {
                    throw new Error('invalid name');
                }

                return name;
            },
            validateSinglePersonalName: function(name) {
                if (!name || (typeof name) != 'string') {
                    throw new Error('null or non-string name');
                }

                if (!/^[A-Z][a-z]*$/.test(name)) {
                    throw new Error('invalid name');
                }

                return name;
            },
            validateStudentIDInCourse: function(studentID, courseParameter) {
                if (!studentID || !courseParameter || (typeof studentID) != 'number') {
                    throw new Error('student id is not a number');
                }


                if (!courseParameter._students.some(s => s.id === studentID)) {
                    throw new Error('student not subscribed to course');
                }

                return studentID ;
            },
            validateHomeworkID: function(homeworkID, courseParameter) {

                if (!homeworkID || !courseParameter || (typeof homeworkID) != 'number') {
                    throw new Error('homework id is not a number');
                }

                if ((homeworkID < 0 || homeworkID > courseParameter._presentations.length || homeworkID % 1 != 0)) {
                    throw new Error('invalid homework id');
                }

                return homeworkID;
            }
        }
    }({});

    var Student = function(parent) {
        var lastId = 0,
            student = Object.create(parent, {
                name: {
                    get: function() {
                        return Rules.validateFullPersonalName(this._givenName + ' ' + this._surname);
                    },
                    set: function(nameValue) {
                        var names = Rules.validateFullPersonalName(nameValue).split(' ');
                        this._givenName = names[0];
                        this._surname = names[1];
                    }
                }
            });

        student.init = function(name) {
            this.id = lastId += 1;
            this.name = name;
            return this;
        }

        return student;
    }({});

    var Course = {
        init: function(courseTitle, coursePresentations) {
            this.title = courseTitle;
            this.presentations = coursePresentations;
            this.students = [];
            this.homeworks = [];
            return this;
        },
        get title() {
            return Rules.validateTitle(this._title);
        },
        set title(titleValue) {
            this._title = Rules.validateTitle(titleValue);
        },
        get presentations() {
            return this._presentations.slice();
        },
        set presentations(presentationsValue) {
            this._presentations = Rules.validatePresentations(presentationsValue);
        },
        get students() {
            return this._students.slice();
        },
        set students(studentsValue) {
            this._students = studentsValue.slice();
        },
        addStudent: function(name) {
            var studentForAdding = Object.create(Student).init(name);            
            this._students.push(studentForAdding);
            return studentForAdding.id;
        },
        getAllStudents: function() {
            var studentArray = [];
            this._students.forEach(s => studentArray.push({firstname: s._givenName, lastname: s._surname, id: s.id}));
            return studentArray;
        },
        get homeworks() {
            return this._homeworks.slice();
        },
        set homeworks(homeworksValue) {
            this._homeworks = homeworksValue.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            this._homeworks.push({sID: Rules.validateStudentIDInCourse(studentID, this), hwID: Rules.validateHomeworkID(homeworkID, this)});
        },
        pushExamResults: function(results) {
        },
        getTopStudents: function() {
        }
    };

    return Course;
};

module.exports = solve;

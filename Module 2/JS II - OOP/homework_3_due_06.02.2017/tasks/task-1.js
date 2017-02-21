function solve() {
    var Rules = function() {
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
    }();

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
            if (!results) {
                throw new Error("cannot push null exam results");
            }

            if (!results.all(r => r.StudentID) || (results.some(r => typeof r.StudentID != 'number')) || !results.all.score || (typeof results.some.score != 'number')) {
                throw new Error("cannot push exam results unexpected format");
            }
        },
        getTopStudents: function() {
        }
    };

    return Course;
};

module.exports = solve;

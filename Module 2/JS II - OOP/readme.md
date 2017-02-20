# JavaScript Object-Oriented Programming

##### Adding a read-only property to an object:    

`
Object.defineProperty(ObjectToExtend, 'name_of_read-only_property': {
    value: 'constant_value',
    writeable: false
});
`

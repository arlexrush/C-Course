var Persona = /** @class */ (function () {
    function Persona(nombre, edad) {
        this.edad = edad;
        this.nombre = nombre;
    }
    Persona.prototype.Beber = function (oCerveza) {
        console.log(this.nombre + "aquí se bebe cerveza:" + oCerveza.nombre);
    };
    return Persona;
}());
var oPersona = new Persona("Alejandro", 21);
function Mostrar(Ocerveza) {
    console.log(Ocerveza);
}
Mostrar({ nombre: "Eldinguer", alcohol: 12 });
console.log(oPersona.nombre + "Tiene una edad:" + oPersona.edad);

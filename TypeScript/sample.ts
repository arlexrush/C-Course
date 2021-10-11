interface Cerveza{
    nombre: string;
    alcohol: number;
}

class Persona{
    nombre: string;
    constructor(nombre: string, public edad:number){
        this.nombre =nombre;
    }

    Beber(oCerveza: Cerveza){
        console.log(this.nombre+"aquí se bebe cerveza:"+oCerveza.nombre);
    }
}

let oPersona= new Persona("Alejandro", 21);

function Mostrar(Ocerveza: Cerveza){
    console.log(Ocerveza);
}

Mostrar({nombre: "Eldinguer", alcohol: 12});
console.log(oPersona.nombre+"Tiene una edad:"+oPersona.edad)
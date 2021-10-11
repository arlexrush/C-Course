import {Component, Inject} from '@angular/core';
import { MatDialogRef,MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ClienteOrden } from 'src/app/models/clienteOrden';
import { ApiclienteService } from 'src/app/service/apicliente.service';
import {Response} from 'src/app/models/response';

@Component({
    templateUrl: 'dialogcliente.component.html'
})

export class DialogClienteComponent {
    
    public nombre: string="";
    

    constructor(
        public dialogRef: MatDialogRef<DialogClienteComponent>,
        public apiCliente: ApiclienteService,
        public snackBar: MatSnackBar,
        @Inject(MAT_DIALOG_DATA) public cliente: ClienteOrden 
    ){ 
        if(cliente !== null){
            this.nombre = cliente.nombre;
            
        }
        console.log(cliente);
    }

    ngOnInit(): void {
        
      }

    close(){
        this.dialogRef.close();
        
    }

    editClientes(){
        const cliente: ClienteOrden = {
            idCliente: this.cliente.idCliente,
            nombre: this.nombre
           
        };
        console.log(cliente);
        this.apiCliente.edit(cliente).subscribe(response => {
            if (response.exito === 1){
                this.dialogRef.close();
                this.snackBar.open("Client edited successfully",'',{duration:2000})
            }else
            {
                this.snackBar.open("Client Don´t added",'',{duration:2000})
            }
        })
    }

    addClientes(){
        const cliente: ClienteOrden = {
            nombre: this.nombre,
            idCliente: 0
        };
        this.apiCliente.add(cliente).subscribe(response => {
            if (response.exito === 1){
                this.dialogRef.close();
                this.snackBar.open("Cliente added successfully",'',{duration:2000})
            }else
            {
                this.snackBar.open("Cliente Don´t added",'',{duration:2000})
            }
        })
    }

    
}
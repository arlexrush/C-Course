import { Component, OnInit } from '@angular/core';
import { ApiclienteService } from '../service/apicliente.service';
import { Response } from '../models/response';
import {DialogClienteComponent} from './dialog/dialogcliente.component';
import {MatDialog} from '@angular/material/dialog';
import { ClienteOrden } from '../models/clienteOrden';
import { DialogDeleteComponent } from '../common/delete/dialogdelete.component';
import { MatSnackBar } from '@angular/material/snack-bar';


@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  public lst: any[] = [];
  public columnas: string[] = ['id', 'nombre', 'actions'];
  readonly width: string = '300';

  constructor(
    private apiCliente: ApiclienteService,
    public dialog: MatDialog,
    public snackBar: MatSnackBar
    ) {


  }

  ngOnInit(): void {
    this.getClientes();
  }

  getClientes(){
    this.apiCliente.get().subscribe(response => {
      this.lst=response.data;
    });
  }

  openAdd(){
    const dialogRef=this.dialog.open(DialogClienteComponent,{width: this.width});
    dialogRef.afterClosed().subscribe(result => {
      this.getClientes();
    })
  }

  openEdit(cliente: ClienteOrden){
    const dialogRef=this.dialog.open(DialogClienteComponent,{width: this.width, data: cliente});
    console.log(cliente);
    dialogRef.afterClosed().subscribe(result => {
      this.getClientes();
    })
  }

  openDelete(cliente: ClienteOrden){
    const dialogRef=this.dialog.open(DialogDeleteComponent,{width: this.width});
    dialogRef.afterClosed().subscribe(result => {
      if(result) {
        this.apiCliente.delete(cliente).subscribe(response => {
          if (response.exito === 1){
            dialogRef.close();
            this.getClientes();
            this.snackBar.open("Client deleted successfully",'',{duration:2000});
          }
        })
      }else
      {
        dialogRef.close();
        this.getClientes();
        this.snackBar.open("Client don't deleted", '', {duration:2000})
      }

    })
  }


}

import { Component, OnInit} from '@angular/core';
import {MatDialogRef} from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ApiclienteService } from 'src/app/service/apicliente.service';

@Component({
    templateUrl: './dialogdelete.component.html'
})
export class DialogDeleteComponent implements OnInit {
    constructor(
      public dialogRef: MatDialogRef<DialogDeleteComponent>,
      public snackBar: MatSnackBar,
      public apiCliente: ApiclienteService){

    }
    ngOnInit(): void {

    }


}

/// <reference path="main.ts" />
import { Component, NgZone, OnInit, ViewChild, OnDestroy, Pipe } from "@angular/core";
import { Router } from "@angular/router";
import {AgGridNg2} from "ag-grid-ng2/main";

@Component({
    selector: "my-app",
    templateUrl: "/partial/main",
    providers: []
})

export class AppComponent implements OnInit, OnDestroy {
    constructor(
        private router: Router
    ) { }

    isActive(instruction: string): boolean {        
        instruction = instruction === "" ? "/" : instruction;
        return this.router.url === instruction;
    }

    ngOnInit(): void { }

    ngOnDestroy(): void { }
}
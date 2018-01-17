// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

import { NgModule } from "@angular/core";

import { SharedModule } from '../shared/shared.module';

import { AdminRoutingModule } from "./admin-routing.module";

import { AdminComponent } from "./admin.component";
import { RoleListComponent } from "./role-list.component";
import { EditRoleDialogComponent } from "./edit-role-dialog.component";
import { RoleEditorComponent } from './role-editor.component';
import { UserListComponent } from "./user-list.component";
import { EditUserDialogComponent } from "./edit-user-dialog.component";

@NgModule({
    imports: [
        SharedModule,
        AdminRoutingModule
    ],
    declarations: [
        AdminComponent,
        RoleListComponent,
        EditRoleDialogComponent,
        RoleEditorComponent,
        UserListComponent,
        EditUserDialogComponent
    ],
    entryComponents: [
        EditUserDialogComponent,
        EditRoleDialogComponent
    ]
})
export class AdminModule
{

}
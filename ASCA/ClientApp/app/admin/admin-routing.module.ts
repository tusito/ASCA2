// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminComponent } from "./admin.component";
import { RoleListComponent } from './role-list.component';
import { UserListComponent } from './user-list.component';
import { PersonListComponent } from './person-list.component';
import { AuthService } from '../services/auth.service';
import { AuthGuard } from '../services/auth-guard.service';

const adminRoutes: Routes = [
    {
        path: 'admin',
        component: AdminComponent,
        children: [
            {
                path: 'users',
                component: UserListComponent,
                data: { title: "Admin | Users" }
            },
            {
                path: 'roles',
                component: RoleListComponent,
                data: { title: "Admin | Roles" }
            },
            {
                path: 'people',
                component: PersonListComponent,
                data: { title: "Admin | People" }
            },
        ]
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(adminRoutes)
    ],
    exports: [
        RouterModule
    ],
    providers: [
        AuthService, AuthGuard
    ]
})
export class AdminRoutingModule { }
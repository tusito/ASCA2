﻿// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

import { Component, NgModule } from '@angular/core';

@Component({
    selector: 'app-footer',
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.scss']
})
export class Footer
{
    getYear()
    {
        return new Date().getUTCFullYear();
    }
}

@NgModule({
    exports: [Footer],
    declarations: [Footer],
})
export class FooterModule { }
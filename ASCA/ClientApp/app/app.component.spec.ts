/// <reference path="../../node_modules/@types/jasmine/index.d.ts" />
// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

import { assert } from 'chai';

import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { QuickAppProMaterialModule } from "./modules/material.module";
import { FooterModule } from "./shared/footer.component";
import { ThemePickerModule } from "./shared/theme-picker.component";

import { AppComponent } from "./app.component";
import { LoginControlComponent } from "./components/login/login-control.component";
import { NotificationsViewerComponent } from "./components/controls/notifications-viewer.component";

import { TranslateModule, TranslateLoader } from "@ngx-translate/core";
import { ToastyModule } from 'ng2-toasty';

import { AuthService } from './services/auth.service';
import { AppTitleService } from './services/app-title.service';
import { AppTranslationService, TranslateLanguageLoader } from './services/app-translation.service';
import { ConfigurationService } from './services/configuration.service';
import { AlertService } from './services/alert.service';
import { LocalStoreManager } from './services/local-store-manager.service';
import { EndpointFactory } from './services/endpoint-factory.service';
import { NotificationService } from './services/notification.service';
import { NotificationEndpoint } from './services/notification-endpoint.service';
import { AccountService } from './services/account.service';
import { AccountEndpoint } from './services/account-endpoint.service';

describe('AppComponent', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            imports: [
                HttpClientModule,
                FormsModule, ReactiveFormsModule,
                BrowserAnimationsModule,
                RouterTestingModule,
                QuickAppProMaterialModule,
                FooterModule,
                ThemePickerModule,
                TranslateModule.forRoot({
                    loader: {
                        provide: TranslateLoader,
                        useClass: TranslateLanguageLoader
                    }
                }),
                ToastyModule.forRoot(),
            ],
            declarations: [
                AppComponent,
                LoginControlComponent,
                NotificationsViewerComponent
            ],
            providers: [
                AuthService,
                AlertService,
                ConfigurationService,
                AppTitleService,
                AppTranslationService,
                NotificationService,
                NotificationEndpoint,
                AccountService,
                AccountEndpoint,
                LocalStoreManager,
                EndpointFactory
            ]
        }).compileComponents();
    }));

    it('should create the app', async(() => {
        const fixture = TestBed.createComponent(AppComponent);
        const app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    }));

    it(`should have as title 'ASCA'`, async(() => {
        const fixture = TestBed.createComponent(AppComponent);
        const app = <AppComponent>fixture.debugElement.componentInstance;
        expect(app.appTitle).toEqual('ASCA');
    }));

    it(`should render 'ASCA' in a p tag`, async(() => {
        const fixture = TestBed.createComponent(AppComponent);
        fixture.detectChanges();
        const compiled = fixture.debugElement.nativeElement;
        expect(compiled.querySelector('p').textContent).toContain('QuicASCAkApp');
    }));
});

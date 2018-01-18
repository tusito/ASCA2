import { TranslateService } from '@ngx-translate/core';
import { MatPaginatorIntl } from '@angular/material';
import { Injectable } from '@angular/core';
import { AppTranslationService } from '../services/app-translation.service';

@Injectable()
export class CustomMatPaginatorIntl extends MatPaginatorIntl {
    constructor(private translate: TranslateService) {
        super();

        this.translate.onLangChange.subscribe((e: Event) => {
            this.getAndInitTranslations();
        });

        this.getAndInitTranslations();
    }

    getAndInitTranslations() {
        this.translate.get(['ITEMS_PER_PAGE', 'NEXT_PAGE', 'PREVIOUS_PAGE', 'OF_LABEL'])
            .subscribe(
                translation => {
                    //this.itemsPerPageLabel = this.translate.currentLang
                    this.itemsPerPageLabel = this.translate.instant('paginator.ItemsPerPageLabel');
                    this.previousPageLabel = this.translate.instant('paginator.PreviousPageLabel');
                    this.nextPageLabel = this.translate.instant('paginator.NextPageLabel');
                    
                    this.changes.next();
            });
    }

    getRangeLabel = (page: number, pageSize: number, length: number) => {
        if (length === 0 || pageSize === 0) {
            return `0 / ${length}`;
        }
        length = Math.max(length, 0);
        const startIndex = page * pageSize;
        const endIndex = startIndex < length ? Math.min(startIndex + pageSize, length) : startIndex + pageSize;
        return `${startIndex + 1} - ${endIndex}  ${this.translate.instant('paginator.OfLabel')}  ${length}`;
    }
}

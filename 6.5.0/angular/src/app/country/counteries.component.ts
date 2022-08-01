import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  CountryDto,
  CountryServiceProxy,
  CountryDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateCounteriesComponent } from './create-country/create-country-dialog.component';
import { EditCounteriesComponent } from './edit-country/edit-country-dialog.component';

class PagedCounteriesRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './counteries.component.html',
  animations: [appModuleAnimation()]
})
export class CounteriesComponent extends PagedListingComponentBase<CountryDto> {
  roles: CountryDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _counteriesService: CountryServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedCounteriesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._counteriesService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: CountryDtoPagedResultDto) => {
        this.roles = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(country: CountryDto): void {
    abp.message.confirm(
      this.l('Country will be deleted', country.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._counteriesService
            .delete(country.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('Successfully Deleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createRole(): void {
    this.showCreateOrEditRoleDialog();
  }

  editRole(role: CountryDto): void {
    this.showCreateOrEditRoleDialog(role.id);
  }

  showCreateOrEditRoleDialog(id?: number): void {
    let createOrEditRoleDialog: BsModalRef;
    if (!id) {
      createOrEditRoleDialog = this._modalService.show(
        CreateCounteriesComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
       createOrEditRoleDialog = this._modalService.show(
         EditCounteriesComponent,
         {
           class: 'modal-lg',
           initialState: {
             id: id,
           },
         }
       );
    }

    createOrEditRoleDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}

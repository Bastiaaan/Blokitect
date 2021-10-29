import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-translate-test',
  template: `
            <div>{{ 'CUSTOM' | translate:param}}</div>
            `,
  //templateUrl: './translate-test.component.html',
  styleUrls: ['./translate-test.component.scss']
})
export class TranslateTestComponent implements OnInit {
  param: any = { value: 'world' };

  constructor(private translate: TranslateService) {
    this.translate.setDefaultLang('en');
    this.translate.use('en');

    this.getTranslation();
  }

  ngOnInit(): void {
  }

  getTranslation() {
    this.translate.get('TRANSLATE_TEST', { value: 'world' }).subscribe((res: string) => {
      console.log(res);
    });
  }

  setTranslation() {
    this.translate.setTranslation('en', {
      CUSTOM: 'hello {{value}}'
    });
  }

}

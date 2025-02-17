import { Component, ChangeDetectionStrategy } from '@angular/core';
import { LoginStatusComponent } from '../components/login-status.component';
import { ListComponent } from './components/list.component';

@Component({
  selector: 'app-resources',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [ListComponent],
  template: `
    <p>Developer Resources</p>
    <app-resources-list />
  `,
  styles: ``,
})
export class ResourcesComponent {}

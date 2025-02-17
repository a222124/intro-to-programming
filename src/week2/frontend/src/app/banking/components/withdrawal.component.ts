import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { BankService } from '../services/bank.service';
import { BankStore } from '../services/bank.store';

@Component({
  selector: 'app-banking-withdraw',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [ReactiveFormsModule],
  template: `
    <form [formGroup]="form" (ngSubmit)="doWithdrawal()">
      <div class="form-control">
        <label for="amount" class="label"
          >Amount of Withdrawal
          <input
            formControlName="amount"
            class="input input-bordered input-md"
            type="number"
            id="amount"
          />
        </label>
        <button type="submit" class="btn btn-primary">Make Withdrawal</button>
      </div>
    </form>
  `,
  styles: ``,
})
export class WithdrawalComponent {
  service = inject(BankStore);
  form = new FormGroup({
    amount: new FormControl<number>(0, { nonNullable: true }),
  });

  doWithdrawal() {
    // do the withdrawal here.
    this.service.withdraw(this.form.controls.amount.value);
  }
}

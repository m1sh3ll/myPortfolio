import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BalanceComponent } from './balance/balance.component';
import { DepositComponent } from './deposit/deposit.component';
import { DepositCoinsComponent } from './deposit-coins/deposit-coins.component';
import { DepositNotesComponent } from './deposit-notes/deposit-notes.component';
import { WithdrawComponent } from './withdraw/withdraw.component';
import { PagenotfoundcomponentComponent } from './pagenotfoundcomponent/pagenotfoundcomponent.component';


const routes: Routes = [
  {
    path:'balance', component: BalanceComponent
  },{
    path:'deposit',
    component: DepositComponent,
    children: [
      {
        path:'coins', component: DepositCoinsComponent
      },
      {path:'notes', component: DepositNotesComponent}
    ]
  },{path:'withdraw', component:WithdrawComponent},
  {path:'**', component: PagenotfoundcomponentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const ArrayOfComponents = [BalanceComponent,
  DepositComponent, WithdrawComponent,
  DepositCoinsComponent,DepositNotesComponent]

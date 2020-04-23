/*
 * This file was automatically generated by Magic from servergardens.com
 */

import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatDate'
})
export class FormatDatePipe implements PipeTransform {
  transform(value: any, args: string[]): any {
    const date = new Date(value);
    return date.toLocaleString();
  }
}

import { Time } from '@angular/common';

export interface Eventt {
    id: number;
    name: string;
    description: string;
    createById: number;
    startDate: Date;
    startTime: Time;
    endDate:Date;
    endTime:Time;
}
import { signalStore } from '@ngrx/signals';

import { withEntities } from '@ngrx/signals/entities';

import { ResourceListItem } from '../types';

export const ResourceStore = signalStore(withEntities<ResourceListItem>());

 

declare var ko: any;

class PublishSummary {
	ActiveItem: string;
	PublishCollection: PublishItem[];

    constructor() {
					this.ActiveItem = ko.observable(this.ActiveItem);
			this.PublishCollection = ko.observableArray(this.PublishCollection);
    }
}


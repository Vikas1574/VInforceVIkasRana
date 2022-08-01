import { VineforceVikasTemplatePage } from './app.po';

describe('VineforceVikas App', function() {
  let page: VineforceVikasTemplatePage;

  beforeEach(() => {
    page = new VineforceVikasTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

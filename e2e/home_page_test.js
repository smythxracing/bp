const url = process.env.url || 'http://localhost:4433';

Feature('Home Page');

Scenario('test homepage loads', I => {
	I.amOnPage(url);
	I.see('Application uses');
});



const url = process.env.url || 'http://localhost:4433';
Feature('BP');

Scenario('test High Blood Pressure', I => {
	I.amOnPage(url + '/bloodpressure');
	I.see('BP Category Calculator');
	I.fillField('BP.Systolic', '160');
    I.pressKey('Enter');
    I.see('High Blood Pressure');
});

Scenario('test Pre-High Blood Pressure', I => {
	I.amOnPage(url + '/bloodpressure');
	I.see('BP Category Calculator');
	I.fillField('BP.Systolic', '140');
    I.pressKey('Enter');
    I.see('Pre-High Blood Pressure');
});

Scenario('test Low Blood Pressure', I => {
	I.amOnPage(url + '/bloodpressure');
	I.see('BP Category Calculator');
	I.fillField('BP.Systolic', '120');
    I.pressKey('Enter');
    I.see('Normal Blood Pressure');
});
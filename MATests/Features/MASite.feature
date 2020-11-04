Feature: MASite
	In normal circumstances I would put these tests in 2 different files
	because they cover different aspects of testing. But since there are only 2 tests
	I took the liberty to put them in one file for the easier reading.
	One las thing is that these tests should be divided into more tests 
	because one test shouldn't check separate things

@1 @file_downloading @Browser_Chrome @Browser_Firefox
Scenario: Downloading file and checking if font color of Contant Button changes.
	Given I am on the Main page
	When I go to Contact Page
	And I go to Media Pack page
	And I download Logotypy
	Then the file 'logotypy.zip' is dowloaded
	And file 'logotypy.zip' contains file 'MA_logo_standard_claim_MONO.pdf'
	And Contact button changes color when mouse get's over it

@2 @searching @Browser_Chrome @Browser_Firefox
Scenario: Search engine check and checking pagination
	Given I am on the Main page
	When I search 'Pocket ECG CRS'
	Then the websie is loaded correclty
	And page contains '10' results
	And results are on the '2' pages
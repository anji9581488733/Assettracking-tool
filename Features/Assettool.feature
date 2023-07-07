Feature: Asset tracking tool
Asset tarcking tool launching
Login the  tracking tool 
Navigate to asset request page 
And get the assets details into pdf

@mytag
Scenario Outline:1 To open the Asset tracking tol with different accounts  
	
	            Given enter credentials one by one<Employee Id> , <Passowrd>
				When  Navigate to Asset request page
	
                Examples:   
	            | Employee Id |  | Passowrd   |
	            | 11094       |  | Anji@12345 |
				| 11094       |  | Anji@12345 |
				| 11094       |  | Anji@12345 |